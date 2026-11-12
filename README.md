═══════════════════════════════════════════════════════════════════════════════
                     MUNICIPAL SERVICES APPLICATION
                     AAPD7112/w - POE
                  PARTS 1, 2 & 3 IMPLEMENTATION
═══════════════════════════════════════════════════════════════════════════════

📋 TABLE OF CONTENTS
───────────────────────────────────────────────────────────────────────────────
1.  Overview
2.  System Requirements
3.  Compilation Instructions
4.  How to Run the Application
5.  How to Use the Application
6.  Data Structures Used (Implementation Report)
7.  Features Overview
8.  Troubleshooting
9.  Project Structure
10. Author Information
11. Version History

═══════════════════════════════════════════════════════════════════════════════

1. OVERVIEW
───────────────────────────────────────────────────────────────────────────────

The Municipal Services Application is a C# .NET Framework Windows Forms
desktop application developed for a South African municipality. The purpose
of this application is to improve citizen engagement and service delivery
by providing residents with an easy-to-use digital platform to:

  ✓ Report municipal issues (Part 1)
  ✓ Access information about local events and announcements (Part 2)
  ✓ Track the status of their service requests efficiently (Part 3)

This application forms part of the Portfolio of Evidence (PoE) for the
module AAPD7112/w - Advanced Application Development.

The application was developed as an individual assignment using Microsoft
Visual Studio and the C# programming language targeting the .NET Framework.

═══════════════════════════════════════════════════════════════════════════════

2. SYSTEM REQUIREMENTS
───────────────────────────────────────────────────────────────────────────────

HARDWARE REQUIREMENTS
─────────────────────
  • Processor:   1.6 GHz or faster
  • RAM:         2 GB minimum (4 GB recommended)
  • Hard Disk:   100 MB free space
  • Display:     1024 x 768 or higher resolution

SOFTWARE REQUIREMENTS
─────────────────────
  • Operating System:   Windows 7, 8, 10, or 11
  • .NET Framework:     Version 4.7.2 or higher
  • Visual Studio:      2019 or 2022 (for compilation only)
  • No additional database or server software is required

FRAMEWORKS AND LIBRARIES USED
─────────────────────────────
  • System.Windows.Forms   (Desktop UI framework)
  • System.Drawing         (Graphics and fonts)
  • System.Collections.Generic (Data structures)
  • System.Linq            (Query operations)
  • System.IO              (File operations for attachments)

═══════════════════════════════════════════════════════════════════════════════

3. COMPILATION INSTRUCTIONS
───────────────────────────────────────────────────────────────────────────────

OPTION A: USING VISUAL STUDIO (RECOMMENDED)
────────────────────────────────────────────

  1. Locate and open the solution file:
         MunicipalServices.sln

  2. Visual Studio will open the solution and restore any dependencies.

  3. From the menu bar, select:
         Build  →  Build Solution
     Or press:
         Ctrl + Shift + B

  4. Wait for the build to complete. The Output window should display:
         Build succeeded.

  5. The compiled executable will be located in:
         bin\Debug\MunicipalServices.exe
     (Or in bin\Release\ if you built in Release mode.)

OPTION B: USING MSBUILD FROM COMMAND LINE
─────────────────────────────────────────

  1. Open the Developer Command Prompt for Visual Studio.

  2. Navigate to the project folder:
         cd path\to\MunicipalServices

  3. Run:
         msbuild MunicipalServices.sln /p:Configuration=Debug

  4. The executable will appear in bin\Debug\.

═══════════════════════════════════════════════════════════════════════════════

4. HOW TO RUN THE APPLICATION
───────────────────────────────────────────────────────────────────────────────

METHOD A: FROM VISUAL STUDIO
────────────────────────────
  • Press F5 (with debugging) or Ctrl + F5 (without debugging).
  • The Main Menu form will appear.

METHOD B: FROM WINDOWS EXPLORER
───────────────────────────────
  • Navigate to the bin\Debug folder.
  • Double-click MunicipalServices.exe.
  • The Main Menu form will appear.

NOTE
────
  This application must run on a Windows operating system. It will not run
  on macOS or Linux without an emulation layer such as Wine or Mono.

═══════════════════════════════════════════════════════════════════════════════

5. HOW TO USE THE APPLICATION
───────────────────────────────────────────────────────────────────────────────

────────────────────────────
5.1  MAIN MENU
────────────────────────────

Upon launching the application, the Main Menu is displayed with three
options:

  1. 📋 Report Issues                                (Active)
  2. 📅 Local Events and Announcements               (Active)
  3. 📊 Service Request Status                       (Active)

To exit, click the ✖ Exit button at the bottom of the form.

────────────────────────────
5.2  REPORT ISSUES (Part 1)
────────────────────────────

  1. From the Main Menu, click "Report Issues".

  2. Fill in the required fields:

        • Location:      Type the address or area of the issue.
        • Category:      Select a category from the dropdown menu.
        • Description:   Type a detailed description of the issue.

  3. (Optional) Attach a file:
        • Click "📁 Attach Media".
        • Choose an image or document from your computer.
        • Supported files: .jpg, .jpeg, .png, .gif, .bmp, .pdf,
                           .doc, .docx, .txt

  4. Click "✓ Submit" to submit the report.
        • A success message will display with the report summary.
        • Points will be awarded to your account.

  5. Engagement features:
        • Each report = 10 points. Each attachment = 5 bonus points.
        • Earn achievements: First Report (1), Community Contributor (5), 
          Community Champion (10).
        • A progress bar shows your total engagement (maximum 100 points).

────────────────────────────
5.3  LOCAL EVENTS AND ANNOUNCEMENTS (Part 2)
────────────────────────────

  1. From the Main Menu, click "Local Events and Announcements".

  2. The form loads with a list of upcoming events. Events are colour-coded
     by priority (🔴 High, 🟡 Medium, 🟢 Low).

  3. Use the following features:
        • 🔍 Search box: Filter events by title, category, or location.
        • 📂 Category filter: Display only matching events.
        • 📥 Load Events: Display all events sorted by priority.

  4. Click any event in the left list to view its full details on the right.

  5. ⭐ Recommended for You:
     The application learns from your behaviour (searches and category views)
     and suggests upcoming, high-priority events you may be interested in.

────────────────────────────
5.4  SERVICE REQUEST STATUS (Part 3)
────────────────────────────

  1. From the Main Menu, click "Service Request Status".

  2. The form automatically loads sample service requests into the 
     advanced data structures.

  3. Search ID (BST):
     Type a Request ID (e.g., 103) into the search box and click "Search". 
     The AVL Tree will instantly locate and display the specific request.

  4. Process Priority (Min-Heap):
     Click the orange "⚠️ Process Priority" button. The Min-Heap will 
     extract and display the most urgent request (Priority 1) first, 
     followed by Priority 2, and so on. Click it multiple times to see 
     the order in which requests are processed.

  5. Optimise Routes (MST):
     Click the purple "🗺️ Optimise Routes" button. The Graph will 
     calculate the Minimum Spanning Tree (MST) to show the most efficient 
     routing between different service locations based on distance.

═══════════════════════════════════════════════════════════════════════════════

6. DATA STRUCTURES USED (IMPLEMENTATION REPORT)
───────────────────────────────────────────────────────────────────────────────

The application utilises various data structures across all three parts.

PART 2: LOCAL EVENTS AND ANNOUNCEMENTS
──────────────────────────────────────
  • Stack<Event>: Tracks recently viewed events (LIFO order).
  • Queue<Event>: Stores events in first-in-first-out order.
  • Priority Queue (List<Event>): Sorts events by priority (High → Low).
  • SortedDictionary: Organises events by date (automatically sorted).
  • Dictionary: Groups events by category for fast retrieval.
  • HashSet<string>: Stores unique category names to prevent duplicates.
  • HashSet<DateTime>: Stores unique event dates.
  • Dictionary<string, int>: Tracks search history for the recommendation engine.

PART 3: SERVICE REQUEST STATUS (Advanced Algorithms)
────────────────────────────────────────────────────
1. Binary Search Tree (AVL Tree)
   - Role: Used to store and retrieve service requests by their unique ID.
   - Contribution: By using a self-balancing AVL tree, search operations run 
     in O(log n) time. When a user enters an ID to check the status, the tree 
     is traversed rapidly, ensuring the UI remains responsive even with thousands 
     of requests.
   - Example: Searching for ID 103 traverses the root and branches left/right 
     based on the numerical value, instantly returning the request without 
     having to check every single record.

2. Min-Heap (Priority Queue)
   - Role: Used to manage the processing of urgent service requests.
   - Contribution: A Min-Heap ensures the request with the highest priority 
     (Priority 1) is always at the root. This allows the municipality to 
     extract the most critical issues first in O(log n) time.
   - Example: If a "Water Leak" (Priority 1) and a "Pothole" (Priority 3) are 
     logged, the heap structure ensures the water leak is automatically bubbled 
     to the top and extracted first by the maintenance team.

3. Graphs and Minimum Spanning Tree (MST)
   - Role: Used to represent the geographical relationships and distances 
     between different service requests in various wards.
   - Contribution: Kruskal's algorithm is used to find the MST. This optimises 
     municipal routing by determining the shortest possible path connecting all 
     related service issues, saving fuel and time for maintenance teams.
   - Example: If there are multiple requests in Ward 12 and Ward 8, the MST 
     calculates the shortest distance to connect them, ignoring longer, 
     redundant paths.

═══════════════════════════════════════════════════════════════════════════════

7. FEATURES OVERVIEW
───────────────────────────────────────────────────────────────────────────────

PART 1 - REPORT ISSUES
  ✓ Location, category, and description inputs.
  ✓ File attachment using OpenFileDialog.
  ✓ Gamification: points, progress bar, and achievements.
  ✓ Data stored in memory using List<IssueReport>.

PART 2 - LOCAL EVENTS AND ANNOUNCEMENTS
  ✓ Search by keyword and filter by category.
  ✓ Detailed event view on selection.
  ✓ Recommendation engine based on user behaviour.
  ✓ Scrollable, resizable, maximised interface.

PART 3 - SERVICE REQUEST STATUS
  ✓ View a well-organised list of submitted requests and their statuses.
  ✓ Search for specific requests using unique identifiers (AVL Tree).
  ✓ Process urgent requests using priority-based extraction (Min-Heap).
  ✓ Visualise efficient routing between service nodes (Graph/MST).
  ✓ Scrollable, resizable, maximised interface.

═══════════════════════════════════════════════════════════════════════════════

8. TROUBLESHOOTING
───────────────────────────────────────────────────────────────────────────────

PROBLEM:  The application will not start.
SOLUTION: • Verify that .NET Framework 4.7.2 or higher is installed.
          • Download it from: https://dotnet.microsoft.com/download/dotnet-framework

PROBLEM:  Compilation errors in Visual Studio.
SOLUTION: • Check that all references are included.
          • Perform: Build → Clean Solution, then Build → Rebuild Solution.
          • Verify that .NET desktop development workload is installed.

PROBLEM:  Attachments do not upload.
SOLUTION: • Make sure files are under 5 MB and are a supported file type.

PROBLEM:  The form is too small or the buttons are cut off.
SOLUTION: • The forms are resizable and scrollable.
          • Maximise the window or drag the edges to resize.

PROBLEM:  Data is lost when the application closes.
SOLUTION: • This is expected. The application stores data in memory only.
            Persistent storage (database) is recommended for future versions.

PROBLEM:  Search ID in Part 3 says "Not Found".
SOLUTION: • Ensure you are typing a valid ID from the list (e.g., 101, 102, 103).
          • Make sure you click "Load Data" first if the list is empty.

═══════════════════════════════════════════════════════════════════════════════

9. PROJECT STRUCTURE
───────────────────────────────────────────────────────────────────────────────

MunicipalServices/
│
├── MunicipalServices.sln              Solution file
├── README.txt                         This file
│
├── MainForm.cs / Designer             Main menu logic and UI
│
├── ReportIssuesForm.cs / Designer     Report Issues logic and UI (Part 1)
├── IssueReport.cs                     Issue data class (Part 1)
│
├── LocalEventsForm.cs / Designer      Local Events logic and UI (Part 2)
├── Event.cs                           Event data class (Part 2)
│
├── ServiceRequestForm.cs / Designer   Service Status logic and UI (Part 3)
├── ServiceRequest.cs                  Service request data class (Part 3)
├── DataStructures.cs                  AVL Tree, Min-Heap, Graph/MST (Part 3)
│
├── Program.cs                         Application entry point
│
└── Properties/
    └── AssemblyInfo.cs                Assembly metadata

═══════════════════════════════════════════════════════════════════════════════

10. AUTHOR INFORMATION
───────────────────────────────────────────────────────────────────────────────

  Student Name:      Sbonakaliso Sfiso Madlopha
  Student Number:    10377944
  Module:            PROG7312 / AAPD7112/w
  Module Title:      Advanced Application Development
  Institution:       Rosebank College
  Campus:            Durban
  Assessment:        Portfolio of Evidence (PoE) – Parts 1, 2 & 3
  Submission Date:   13 November 2026

═══════════════════════════════════════════════════════════════════════════════

11. VERSION HISTORY
───────────────────────────────────────────────────────────────────────────────

VERSION 1.0 — Part 1: Report Issues
  • Main Menu, Report Issues form, File attachment, Gamification.

VERSION 2.0 — Part 2: Local Events and Announcements
  • LocalEventsForm, Search/Filter, Recommendation engine.
  • 8 Data structures implemented (Stack, Queue, Dictionaries, Sets).

VERSION 3.0 — Part 3: Service Request Status
  • ServiceRequestForm created.
  • 3 Advanced Data Structures implemented:
        - AVL Tree (for fast ID searching)
        - Min-Heap (for priority extraction)
        - Graph & MST (for optimised routing)
  • Enabled the third option on the Main Menu.

FUTURE VERSIONS
───────────────
  • Persistent storage (SQL Server/Entity Framework).
  • Azure Maps / Google Maps integration for real GPS routing.
  • User accounts and login capabilities.
  • Push notifications for event reminders and status updates.

═══════════════════════════════════════════════════════════════════════════════
                              END OF README
═══════════════════════════════════════════════════════════════════════════════
