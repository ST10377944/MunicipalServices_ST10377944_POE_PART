using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServices
{
    public partial class LocalEventsForm : Form
    {
        // ═══════════════════════════════════════════════════════════════
        // DATA STRUCTURES REQUIRED BY THE ASSIGNMENT
        // ═══════════════════════════════════════════════════════════════

        // 1. STACK - For recently viewed events (LIFO)
        private Stack<Event> recentlyViewedEvents = new Stack<Event>();

        // 2. QUEUE - For events waiting to be displayed (FIFO)
        private Queue<Event> eventQueue = new Queue<Event>();

        // 3. PRIORITY QUEUE - Implemented using a sorted list (high priority first)
        private List<Event> priorityQueue = new List<Event>();

        // 4. SORTED DICTIONARY - For organising events by date (key = date)
        private SortedDictionary<DateTime, List<Event>> eventsByDate =
            new SortedDictionary<DateTime, List<Event>>();

        // 5. DICTIONARY - For organising events by category (key = category)
        private Dictionary<string, List<Event>> eventsByCategory =
            new Dictionary<string, List<Event>>();

        // 6. HASH SET - For storing unique categories
        private HashSet<string> uniqueCategories = new HashSet<string>();

        // 7. HASH SET - For storing unique dates
        private HashSet<DateTime> uniqueDates = new HashSet<DateTime>();

        // 8. RECOMMENDATION TRACKING - User search patterns
        private Dictionary<string, int> searchHistory = new Dictionary<string, int>();
        private Dictionary<string, int> categoryViewCount = new Dictionary<string, int>();

        // Master list of all events
        private List<Event> allEvents = new List<Event>();

        public LocalEventsForm()
        {
            InitializeComponent();
        }

        // ═══════════════════════════════════════════════════════════════
        // FORM LOAD
        // ═══════════════════════════════════════════════════════════════
        private void LocalEventsForm_Load(object sender, EventArgs e)
        {
            LoadSampleEvents();
            PopulateCategoryFilter();
            UpdateStatus("Events loaded. Use search or filter to find events.");
        }

        // ═══════════════════════════════════════════════════════════════
        // LOAD SAMPLE EVENTS INTO ALL DATA STRUCTURES
        // ═══════════════════════════════════════════════════════════════
        private void LoadSampleEvents()
        {
            // Create sample events for a South African municipality
            allEvents = new List<Event>
            {
                new Event { EventId = 1, Title = "Community Clean-Up Day", Category = "Community",
                    EventDate = DateTime.Today.AddDays(3), Location = "Durban Beach Front",
                    Description = "Join us for a community clean-up at the beach. Bring gloves and bags.", Priority = 1 },

                new Event { EventId = 2, Title = "Water Maintenance Notice", Category = "Utilities",
                    EventDate = DateTime.Today.AddDays(1), Location = "Phoenix Area",
                    Description = "Water supply will be interrupted from 8am to 2pm for maintenance.", Priority = 1 },

                new Event { EventId = 3, Title = "Town Hall Meeting", Category = "Governance",
                    EventDate = DateTime.Today.AddDays(7), Location = "City Hall",
                    Description = "Monthly town hall meeting to discuss municipal budgets and projects.", Priority = 2 },

                new Event { EventId = 4, Title = "Road Closure - Main Street", Category = "Roads",
                    EventDate = DateTime.Today.AddDays(2), Location = "Main Street, CBD",
                    Description = "Main Street will be closed for resurfacing from Monday to Friday.", Priority = 1 },

                new Event { EventId = 5, Title = "Youth Skills Workshop", Category = "Education",
                    EventDate = DateTime.Today.AddDays(10), Location = "Community Centre",
                    Description = "Free workshop for youth on CV writing and interview skills.", Priority = 3 },

                new Event { EventId = 6, Title = "Electricity Load Shedding Update", Category = "Utilities",
                    EventDate = DateTime.Today, Location = "All Areas",
                    Description = "Load shedding scheduled for 6pm-8pm today. Please plan accordingly.", Priority = 1 },

                new Event { EventId = 7, Title = "Waste Collection Schedule Change", Category = "Waste",
                    EventDate = DateTime.Today.AddDays(4), Location = "All Residential Areas",
                    Description = "Waste collection will move from Tuesday to Wednesday next week.", Priority = 2 },

                new Event { EventId = 8, Title = "Library Reading Programme", Category = "Education",
                    EventDate = DateTime.Today.AddDays(14), Location = "Public Library",
                    Description = "Free reading programme for children aged 5-12 during school holidays.", Priority = 3 },

                new Event { EventId = 9, Title = "Sports Tournament", Category = "Community",
                    EventDate = DateTime.Today.AddDays(21), Location = "Sports Grounds",
                    Description = "Inter-community soccer and netball tournament. Register your team.", Priority = 3 },

                new Event { EventId = 10, Title = "Health Clinic Outreach", Category = "Health",
                    EventDate = DateTime.Today.AddDays(5), Location = "Mobile Clinic - Ward 12",
                    Description = "Free health screenings and vaccinations available.", Priority = 2 }
            };

            // Load into all data structures
            foreach (var evt in allEvents)
            {
                // Add to Queue (FIFO)
                eventQueue.Enqueue(evt);

                // Add to Priority Queue (sorted by priority)
                priorityQueue.Add(evt);

                // Add to Sorted Dictionary by Date
                if (!eventsByDate.ContainsKey(evt.EventDate.Date))
                {
                    eventsByDate[evt.EventDate.Date] = new List<Event>();
                }
                eventsByDate[evt.EventDate.Date].Add(evt);

                // Add to Dictionary by Category
                if (!eventsByCategory.ContainsKey(evt.Category))
                {
                    eventsByCategory[evt.Category] = new List<Event>();
                }
                eventsByCategory[evt.Category].Add(evt);

                // Add to Sets
                uniqueCategories.Add(evt.Category);
                uniqueDates.Add(evt.EventDate.Date);

                // Initialise search history counters
                if (!searchHistory.ContainsKey(evt.Category))
                {
                    searchHistory[evt.Category] = 0;
                }
                if (!categoryViewCount.ContainsKey(evt.Category))
                {
                    categoryViewCount[evt.Category] = 0;
                }
            }

            // Sort priority queue by priority (1 = highest)
            priorityQueue = priorityQueue.OrderBy(e => e.Priority).ThenBy(e => e.EventDate).ToList();

            // Display all events initially
            DisplayEvents(allEvents);

            // Update queue info label
            lblQueueInfo.Text = $"Priority Queue: {priorityQueue.Count} events | Unique Categories: {uniqueCategories.Count}";

            // Generate initial recommendations
            GenerateRecommendations();
        }

        // ═══════════════════════════════════════════════════════════════
        // POPULATE CATEGORY FILTER (using HashSet unique categories)
        // ═══════════════════════════════════════════════════════════════
        private void PopulateCategoryFilter()
        {
            cmbCategoryFilter.Items.Clear();
            cmbCategoryFilter.Items.Add("All Categories");

            // Use the HashSet of unique categories
            foreach (var category in uniqueCategories.OrderBy(c => c))
            {
                cmbCategoryFilter.Items.Add(category);
            }

            cmbCategoryFilter.SelectedIndex = 0;
        }

        // ═══════════════════════════════════════════════════════════════
        // DISPLAY EVENTS IN LISTBOX
        // ═══════════════════════════════════════════════════════════════
        private void DisplayEvents(List<Event> events)
        {
            lstEvents.Items.Clear();

            if (events.Count == 0)
            {
                lstEvents.Items.Add("No events found.");
                return;
            }

            foreach (var evt in events)
            {
                string priorityIcon = evt.Priority == 1 ? "🔴" : evt.Priority == 2 ? "🟡" : "🟢";
                lstEvents.Items.Add($"{priorityIcon} [{evt.EventDate:yyyy-MM-dd}] {evt.Title} ({evt.Category})");
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // SEARCH FUNCTIONALITY (uses Dictionary search history)
        // ═══════════════════════════════════════════════════════════════
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Record search pattern for recommendations
            RecordSearch(searchTerm);

            // Search across title, category, location, and description
            var results = allEvents.Where(evt =>
                evt.Title.ToLower().Contains(searchTerm) ||
                evt.Category.ToLower().Contains(searchTerm) ||
                evt.Location.ToLower().Contains(searchTerm) ||
                evt.Description.ToLower().Contains(searchTerm)
            ).OrderBy(evt => evt.EventDate).ToList();

            DisplayEvents(results);
            UpdateStatus($"Search results for '{searchTerm}': {results.Count} event(s) found.");

            // Generate recommendations based on search
            GenerateRecommendations();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbCategoryFilter.SelectedIndex = 0;
            DisplayEvents(allEvents.OrderBy(evt => evt.EventDate).ToList());
            UpdateStatus("Search cleared. Showing all events.");
        }

        // ═══════════════════════════════════════════════════════════════
        // CATEGORY FILTER (uses Dictionary eventsByCategory)
        // ═══════════════════════════════════════════════════════════════
        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoryFilter.SelectedItem == null) return;

            string selectedCategory = cmbCategoryFilter.SelectedItem.ToString();

            if (selectedCategory == "All Categories")
            {
                DisplayEvents(allEvents.OrderBy(evt => evt.EventDate).ToList());
                UpdateStatus("Showing all events.");
            }
            else
            {
                // Retrieve from Dictionary by category
                if (eventsByCategory.ContainsKey(selectedCategory))
                {
                    var categoryEvents = eventsByCategory[selectedCategory]
                        .OrderBy(evt => evt.EventDate).ToList();
                    DisplayEvents(categoryEvents);
                    UpdateStatus($"Showing {categoryEvents.Count} event(s) in '{selectedCategory}'.");

                    // Track category view for recommendations
                    if (categoryViewCount.ContainsKey(selectedCategory))
                    {
                        categoryViewCount[selectedCategory]++;
                    }
                }
            }

            GenerateRecommendations();
        }

        // ═══════════════════════════════════════════════════════════════
        // EVENT SELECTION - Show details (uses Stack for recently viewed)
        // ═══════════════════════════════════════════════════════════════
        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEvents.SelectedIndex < 0) return;

            string selectedText = lstEvents.SelectedItem.ToString();

            // Find the event that matches
            Event selectedEvent = allEvents.FirstOrDefault(evt =>
                selectedText.Contains(evt.Title));

            if (selectedEvent != null)
            {
                // Display details
                txtEventDetails.Clear();
                txtEventDetails.AppendText($"📌 {selectedEvent.Title}\n");
                txtEventDetails.AppendText($"═══════════════════════════════════\n\n");
                txtEventDetails.AppendText($"📂 Category: {selectedEvent.Category}\n");
                txtEventDetails.AppendText($"📅 Date: {selectedEvent.EventDate:dddd, dd MMMM yyyy}\n");
                txtEventDetails.AppendText($"📍 Location: {selectedEvent.Location}\n");
                txtEventDetails.AppendText($"⚠️ Priority: {GetPriorityText(selectedEvent.Priority)}\n\n");
                txtEventDetails.AppendText($"📝 Description:\n{selectedEvent.Description}\n");

                // Push to Stack (recently viewed)
                recentlyViewedEvents.Push(selectedEvent);

                // Keep stack size manageable
                if (recentlyViewedEvents.Count > 10)
                {
                    var tempList = recentlyViewedEvents.ToList();
                    tempList.RemoveAt(tempList.Count - 1);
                    recentlyViewedEvents = new Stack<Event>(tempList.AsEnumerable().Reverse());
                }
            }
        }

        private string GetPriorityText(int priority)
        {
            switch (priority)
            {
                case 1: return "HIGH 🔴";
                case 2: return "MEDIUM 🟡";
                case 3: return "LOW 🟢";
                default: return "Normal";
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // RECOMMENDATION FEATURE (30 marks)
        // ═══════════════════════════════════════════════════════════════
        private void RecordSearch(string searchTerm)
        {
            // Record search term frequency
            if (searchHistory.ContainsKey(searchTerm))
            {
                searchHistory[searchTerm]++;
            }
            else
            {
                searchHistory[searchTerm] = 1;
            }
        }

        private void GenerateRecommendations()
        {
            lstRecommendations.Items.Clear();

            // Algorithm: Score each event based on user behaviour
            // - Category view count (higher = more relevant)
            // - Search history match
            // - Upcoming date (sooner = more relevant)
            // - Priority (higher priority = more relevant)

            Dictionary<Event, int> eventScores = new Dictionary<Event, int>();

            foreach (var evt in allEvents)
            {
                int score = 0;

                // Factor 1: Category view frequency
                if (categoryViewCount.ContainsKey(evt.Category))
                {
                    score += categoryViewCount[evt.Category] * 10;
                }

                // Factor 2: Search history match
                foreach (var search in searchHistory)
                {
                    if (evt.Title.ToLower().Contains(search.Key) ||
                        evt.Category.ToLower().Contains(search.Key) ||
                        evt.Description.ToLower().Contains(search.Key))
                    {
                        score += search.Value * 5;
                    }
                }

                // Factor 3: Upcoming events get higher score
                int daysUntil = (evt.EventDate.Date - DateTime.Today).Days;
                if (daysUntil >= 0 && daysUntil <= 7)
                    score += 20;
                else if (daysUntil > 7 && daysUntil <= 14)
                    score += 10;
                else if (daysUntil > 14)
                    score += 5;

                // Factor 4: Priority
                if (evt.Priority == 1) score += 15;
                else if (evt.Priority == 2) score += 10;
                else score += 5;

                eventScores[evt] = score;
            }

            // Get top 5 recommendations
            var recommendations = eventScores
                .OrderByDescending(kv => kv.Value)
                .Take(5)
                .Select(kv => kv.Key)
                .ToList();

            if (recommendations.Count == 0)
            {
                lstRecommendations.Items.Add("No recommendations yet. Browse events to get suggestions.");
                return;
            }

            foreach (var evt in recommendations)
            {
                lstRecommendations.Items.Add($"⭐ [{evt.EventDate:yyyy-MM-dd}] {evt.Title} ({evt.Category})");
            }
        }

        private void lstRecommendations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRecommendations.SelectedIndex < 0) return;

            string selectedText = lstRecommendations.SelectedItem.ToString();

            Event selectedEvent = allEvents.FirstOrDefault(evt =>
                selectedText.Contains(evt.Title));

            if (selectedEvent != null)
            {
                txtEventDetails.Clear();
                txtEventDetails.AppendText($"⭐ RECOMMENDED EVENT\n");
                txtEventDetails.AppendText($"═══════════════════════════════════\n\n");
                txtEventDetails.AppendText($"📌 {selectedEvent.Title}\n");
                txtEventDetails.AppendText($"📂 Category: {selectedEvent.Category}\n");
                txtEventDetails.AppendText($"📅 Date: {selectedEvent.EventDate:dddd, dd MMMM yyyy}\n");
                txtEventDetails.AppendText($"📍 Location: {selectedEvent.Location}\n");
                txtEventDetails.AppendText($"⚠️ Priority: {GetPriorityText(selectedEvent.Priority)}\n\n");
                txtEventDetails.AppendText($"📝 Description:\n{selectedEvent.Description}\n");
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // LOAD EVENTS BUTTON (demonstrates Queue and Priority Queue)
        // ═══════════════════════════════════════════════════════════════
        private void btnLoadEvents_Click(object sender, EventArgs e)
        {
            // Demonstrate Priority Queue - load events by priority
            var orderedEvents = priorityQueue.OrderBy(evt => evt.Priority)
                                              .ThenBy(evt => evt.EventDate)
                                              .ToList();

            DisplayEvents(orderedEvents);
            UpdateStatus($"Loaded {orderedEvents.Count} events ordered by priority (High → Low).");

            // Demonstrate Queue - show FIFO order
            if (eventQueue.Count > 0)
            {
                lblQueueInfo.Text = $"Priority Queue: {priorityQueue.Count} events | Queue (FIFO): {eventQueue.Count} | Unique Categories: {uniqueCategories.Count}";
            }
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = message;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}