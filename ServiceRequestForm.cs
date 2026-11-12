using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServices
{
    public partial class ServiceRequestForm : Form
    {
        // Instantiate our advanced data structures
        private RequestAVLTree requestTree = new RequestAVLTree();
        private RequestMinHeap priorityHeap = new RequestMinHeap();
        private MunicipalGraph requestGraph = new MunicipalGraph();
        private List<ServiceRequest> allRequests = new List<ServiceRequest>();

        public ServiceRequestForm()
        {
            InitializeComponent();
        }

        private void ServiceRequestForm_Load(object sender, EventArgs e)
        {
            // Automatically load data when form opens
            btnLoadData_Click(sender, e);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            // Clear everything first to prevent duplicates if clicked multiple times
            requestTree = new RequestAVLTree();
            priorityHeap = new RequestMinHeap();
            requestGraph = new MunicipalGraph();
            allRequests.Clear();
            lstRequests.Items.Clear();
            rtbDetails.Clear();

            // Create sample requests
            var r1 = new ServiceRequest(101, "Water Leak", "Ward 12", 1, "Pending"); // High Priority
            var r2 = new ServiceRequest(102, "Pothole", "Main St", 3, "In Progress");
            var r3 = new ServiceRequest(103, "Power Outage", "Ward 4", 1, "Pending"); // High Priority
            var r4 = new ServiceRequest(104, "Broken Streetlight", "Ward 12", 2, "Resolved");
            var r5 = new ServiceRequest(105, "Refuse Collection", "Ward 8", 3, "Pending");

            allRequests.AddRange(new[] { r1, r2, r3, r4, r5 });

            // 1. Populate AVL Tree (Search by ID)
            foreach (var req in allRequests)
            {
                requestTree.Root = requestTree.Insert(requestTree.Root, req);
                priorityHeap.Insert(req); // 2. Populate Min-Heap (Priority)
            }

            // 3. Populate Graph (Connecting requests by "Distance")
            // Indices map to requests: 101=0, 102=1, 103=2, 104=3, 105=4
            requestGraph.AddEdge(0, 3, 5);  // Ward 12 to Ward 12
            requestGraph.AddEdge(1, 2, 10); // Main St to Ward 4
            requestGraph.AddEdge(3, 4, 2);  // Ward 12 to Ward 8
            requestGraph.AddEdge(0, 1, 15); // Ward 12 to Main St

            RefreshList(allRequests);
            rtbDetails.Text = "Data loaded successfully into Trees, Heaps, and Graphs.\n" +
                              "Use the buttons below to test each data structure.";
        }

        private void RefreshList(List<ServiceRequest> list)
        {
            lstRequests.Items.Clear();
            foreach (var req in list)
            {
                lstRequests.Items.Add($"ID: {req.RequestId} | {req.IssueType} | Priority: {req.Priority} | Status: {req.Status}");
            }
        }

        // --- 1. AVL TREE SEARCH ---
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchId.Text, out int id))
            {
                var result = requestTree.Search(requestTree.Root, id);
                if (result != null)
                {
                    rtbDetails.Text = $"--- 🔍 SEARCH RESULT (AVL Tree) ---\n\n" +
                                      $"ID: {result.RequestId}\n" +
                                      $"Type: {result.IssueType}\n" +
                                      $"Location: {result.Location}\n" +
                                      $"Status: {result.Status}\n" +
                                      $"Priority: {result.Priority}";
                }
                else
                {
                    MessageBox.Show("Request ID not found in the AVL Tree.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID (e.g., 101).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- 2. MIN-HEAP EXTRACTION ---
        private void btnProcessPriority_Click(object sender, EventArgs e)
        {
            var highestPriority = priorityHeap.ExtractMin();
            if (highestPriority != null)
            {
                rtbDetails.Text = $"--- ⚠️ MIN-HEAP EXTRACTION ---\n\n" +
                                  $"The most urgent request has been extracted from the heap:\n\n" +
                                  $"ID: {highestPriority.RequestId}\n" +
                                  $"Type: {highestPriority.IssueType}\n" +
                                  $"Priority Level: {highestPriority.Priority} (1 is highest)\n" +
                                  $"Status: {highestPriority.Status}";
            }
            else
            {
                MessageBox.Show("Heap is empty. All urgent requests processed.", "Empty Heap", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- 3. GRAPH & MST ---
        private void btnShowMST_Click(object sender, EventArgs e)
        {
            var mst = requestGraph.GetMST();
            string mstString = "--- 🗺️ MINIMUM SPANNING TREE (MST) ---\n\n" +
                               "Optimised routing between service nodes:\n\n";

            if (mst.Count == 0)
            {
                mstString += "No edges found in the graph.";
            }

            foreach (var edge in mst)
            {
                // Map the integer index back to the Request ID
                int id1 = 101 + edge.Source;
                int id2 = 101 + edge.Destination;
                mstString += $"Connection: Request {id1} <--> Request {id2}\n" +
                             $"Distance/Weight: {edge.Weight}\n" +
                             $"-----------------------------------\n";
            }

            rtbDetails.Text = mstString;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}