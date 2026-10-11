═══════════════════════════════════════════════════════════════════════════════
                     MUNICIPAL SERVICES APPLICATION
                     AAPD7112/w - POE
                      PARTS 1 & 2 IMPLEMENTATION
═══════════════════════════════════════════════════════════════════════════════

📋 TABLE OF CONTENTS
───────────────────────────────────────────────────────────────────────────────
1.  Overview
2.  System Requirements
3.  Compilation Instructions
4.  How to Run the Application
5.  How to Use the Application
6.  Data Structures Used
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
  ✓ (Future) Track the status of their service requests

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
  3. 📊 Service Request Status (Coming Soon)         (Disabled)

To exit, click the ✖ Exit button at the bottom of the form.

────────────────────────────
5.2  REPORT ISSUES (Part 1)
────────────────────────────

  1. From the Main Menu, click "Report Issues".

  2. Fill in the required fields:

        • Location:*      Type the address or area of the issue.
        • Category:*      Select a category from the dropdown menu:
                            - Sanitation
                            - Roads
                            - Utilities
                            - Public Safety
                            - Waste Management
                            - Housing
                            - Other
        • Description:*   Type a detailed description of the issue.

  3. (Optional) Attach a file:
        • Click "📁 Attach Media".
        • Choose an image or document from your computer.
        • Supported files: .jpg, .jpeg, .png, .gif, .bmp, .pdf,
                           .doc, .docx, .txt
        • The filename will appear next to the button.

  4. Click "✓ Submit" to submit the report.
        • A success message will display with the report summary.
        • Points will be awarded to your account.

  5. Engagement features:
        • Each report = 10 points.
        • Each attachment = 5 bonus points.
        • Earn achievements:
             - First Report             (1 report)
             - Community Contributor    (5 reports)
             - Community Champion       (10 reports)
        • A progress bar shows your total engagement (maximum 100 points).

  6. Use the buttons at the bottom of the form:
        • ✓ Submit          Submit the current report.
        • 🗑 Clear           Clear all fields.
        • 📋 View Reports   View all submitted reports.
        • ↩ Back to Menu    Return to the Main Menu.

  Fields marked with an asterisk (*) are mandatory.

────────────────────────────
5.3  LOCAL EVENTS AND ANNOUNCEMENTS (Part 2)
────────────────────────────

  1. From the Main Menu, click "Local Events and Announcements".

  2. The form loads with a list of upcoming events. Events are colour-coded
     by priority:

        🔴 High priority    (urgent matters such as water/power outages)
        🟡 Medium priority  (general service notices)
        🟢 Low priority     (community and recreational events)

  3. Use the following features:

        • 🔍 Search box      Type a keyword and click "Search" to filter
                             events by title, category, location or
                             description.

        • Clear button       Reset the search and show all events again.

        • 📂 Category filter Choose a specific category from the dropdown
                             to display only matching events. Categories:
                                - Community
                                - Utilities
                                - Governance
                                - Roads
                                - Education
                                - Waste
                                - Health

        • 📥 Load Events     Display all events sorted by priority
                             (High → Medium → Low).

  4. Click any event in the left list to view its full details on the right:
        - Title
        - Category
        - Date (day of the week, day, month, year)
        - Location
        - Priority
        - Full description

  5. ⭐ Recommended for You
        The application learns from your behaviour and suggests events you
        may be interested in. Recommendations are based on:
            • Categories you have browsed most often
            • Keywords you have searched for
            • Upcoming events (sooner = more relevant)
            • Events with a higher priority

  6. Click "↩ Back to Menu" to return to the Main Menu.

  TIP: If the form feels too small, the window is resizable and
       scrollbars will appear automatically. You can also maximise
       the window for a full-screen view.

────────────────────────────
5.4  SERVICE REQUEST STATUS (Future)
────────────────────────────

  This option is currently disabled and will be implemented in a future
  part of the POE.

═══════════════════════════════════════════════════════════════════════════════

6. DATA STRUCTURES USED
───────────────────────────────────────────────────────────────────────────────

The following data structures were implemented in the Local Events and
Announcements form (Part 2) as required by the assignment specification:

┌─────────────────────────┬─────────────────────────────────────────────────┐
│ DATA STRUCTURE          │ PURPOSE IN THE APPLICATION                      │
├─────────────────────────┼─────────────────────────────────────────────────┤
│ Stack<Event>            │ Tracks recently viewed events (LIFO order).    │
│                         │ The most recently viewed event is at the top.   │
├─────────────────────────┼─────────────────────────────────────────────────┤
│ Queue<Event>            │ Stores events in first-in-first-out order      │
│                         │ for sequential processing and display.          │
├─────────────────────────┼─────────────────────────────────────────────────┤
│ Priority Queue          │ Implemented using a sorted List<Event>.         │
│ (List<Event>)           │ Events are sorted by priority: High → Low,      │
│                         │ then by date.                                   │
├─────────────────────────┼─────────────────────────────────────────────────┤
│ SortedDictionary        │ Organises events by date. Keys are the event    │
│ <DateTime, List<Event>> │ dates and entries are automatically sorted by  │
│                         │ date.                                           │
├─────────────────────────┼─────────────────────────────────────────────────┤
│ Dictionary              │ Groups events by category so they can be        │
│ <string, List<Event>>   │ retrieved quickly by category name.             │
├─────────────────────────┼─────────────────────────────────────────────────┤
│ HashSet<string>         │ Stores unique category names. Prevents          │
│                         │ duplicates and is used to populate the          │
│                         │ category filter dropdown.                       │
├─────────────────────────┼─────────────────────────────────────────────────┤
│ HashSet<DateTime>       │ Stores unique event dates. Ensures that each    │
│                         │ date appears only once.                         │
├─────────────────────────┼─────────────────────────────────────────────────┤
│ Dictionary<string, int> │ Tracks search history (keyword frequency) and   │
│                         │ category view counts. Used by the               │
│                         │ recommendation algorithm.                       │
└─────────────────────────┴─────────────────────────────────────────────────┘

The Report Issues form (Part 1) uses a List<IssueReport> to store all
submitted reports in memory during the session.

═══════════════════════════════════════════════════════════════════════════════

7. FEATURES OVERVIEW
───────────────────────────────────────────────────────────────────────────────

PART 1 - REPORT ISSUES
─────────────────────
  ✓ Main Menu with three navigation options
  ✓ Report form with location, category and description inputs
  ✓ File attachment using OpenFileDialog
  ✓ Form validation with user feedback
  ✓ Gamification system:
        - Points (10 per report, 5 bonus per attachment)
        - Progress bar (maximum 100 points)
        - Achievement badges for milestones
        - Motivational messages
  ✓ View Reports feature
  ✓ Data stored in memory using List<IssueReport>

PART 2 - LOCAL EVENTS AND ANNOUNCEMENTS
───────────────────────────────────────
  ✓ Displays upcoming events and announcements
  ✓ Search by keyword (title, category, location, description)
  ✓ Filter by category
  ✓ Detailed event information on selection
  ✓ Colour-coded priority levels (High / Medium / Low)
  ✓ Recommendation engine based on user behaviour
  ✓ Uses eight different data structures as required
  ✓ Scrollable, resizable interface
  ✓ Auto-opens maximised for readability

DESIGN PRINCIPLES APPLIED
─────────────────────────
  • Consistency:  Uniform colour scheme (blue, white, red for exit)
  • Clarity:      Large, readable fonts and clear labels
  • Feedback:     MessageBox alerts for success and errors
  • Responsive:   Forms resize and scroll on any screen size
  • Accessibility: High-contrast colours and large touch-friendly buttons

═══════════════════════════════════════════════════════════════════════════════

8. TROUBLESHOOTING
───────────────────────────────────────────────────────────────────────────────

PROBLEM:  The application will not start.
SOLUTION: • Verify that .NET Framework 4.7.2 or higher is installed.
          • Download it from:
            https://dotnet.microsoft.com/download/dotnet-framework

PROBLEM:  Compilation errors in Visual Studio.
SOLUTION: • Check that all references are included.
          • Perform: Build → Clean Solution, then Build → Rebuild Solution.
          • Verify that .NET desktop development workload is installed in
            the Visual Studio Installer.

PROBLEM:  Attachments do not upload.
SOLUTION: • Make sure files are under 5 MB.
          • Verify the file type is supported.
          • Check that you have read permission for the file.

PROBLEM:  The form is too small or the buttons are cut off.
SOLUTION: • The forms are resizable and scrollable.
          • Maximise the window or drag the edges to resize.
          • Scrollbars will appear automatically when needed.

PROBLEM:  "ReportIssuesForm" or "LocalEventsForm" not found.
SOLUTION: • Ensure all form files (.cs and .Designer.cs) exist.
          • Check that all files belong to the namespace
            MunicipalServices.

PROBLEM:  Data is lost when the application closes.
SOLUTION: • This is expected. Part 1 and Part 2 store data in memory
            only. Persistent storage (database or file) will be
            implemented in a later part of the POE.

PROBLEM:  Events do not appear in the list.
SOLUTION: • Click the "📥 Load Events" button first.
          • Check that the category filter is set to "All Categories".

═══════════════════════════════════════════════════════════════════════════════

9. PROJECT STRUCTURE
───────────────────────────────────────────────────────────────────────────────

MunicipalServices/
│
├── MunicipalServices.sln              Solution file
├── README.txt                         This file
│
├── MainForm.cs                        Main menu logic
├── MainForm.Designer.cs               Main menu UI
│
├── ReportIssuesForm.cs                Report Issues logic (Part 1)
├── ReportIssuesForm.Designer.cs       Report Issues UI (Part 1)
│
├── LocalEventsForm.cs                 Local Events logic (Part 2)
├── LocalEventsForm.Designer.cs        Local Events UI (Part 2)
│
├── Event.cs                           Event data class (Part 2)
├── IssueReport.cs                     Issue data class (Part 1)
│
├── Program.cs                         Application entry point
│
├── Properties/
│   └── AssemblyInfo.cs                Assembly metadata
│
├── bin/                               Compiled output (auto-generated)
│   ├── Debug/
│   │   └── MunicipalServices.exe      Run this file
│   └── Release/
│
└── obj/                               Intermediate build files
                                       (auto-generated, safe to delete)

═══════════════════════════════════════════════════════════════════════════════

10. AUTHOR INFORMATION
───────────────────────────────────────────────────────────────────────────────

  Student Name:      Sbonakaliso Madlopha
  Student Number:    10377944
  Module:            PROG7312 / AAPD7112/w
  Module Title:      Advanced Application Development
  Institution:       Rosebank College
  Campus:            Durban
  Assessment:        Portfolio of Evidence (PoE) – Part 1 & Part 2
  Submission Date:   14 October 2026

═══════════════════════════════════════════════════════════════════════════════

11. VERSION HISTORY
───────────────────────────────────────────────────────────────────────────────

VERSION 1.0 — Part 1: Report Issues
───────────────────────────────────
  • Main Menu with three navigation options
  • Report Issues form (location, category, description)
  • File attachment using OpenFileDialog
  • Form validation and success messages
  • Gamification: points, progress bar, achievements
  • View Reports feature
  • Data stored in memory using List<IssueReport>

VERSION 2.0 — Part 2: Local Events and Announcements
────────────────────────────────────────────────────
  • Main Menu updated: Local Events option enabled
  • LocalEventsForm created
  • Ten sample municipal events loaded
  • Search by keyword (title, category, location, description)
  • Category filter dropdown
  • Detailed event view on selection
  • Priority-based ordering (High / Medium / Low)
  • Recommendation engine based on user behaviour
  • Eight data structures implemented:
        Stack, Queue, Priority Queue, SortedDictionary,
        Dictionary, two HashSets, and a search history Dictionary
  • Forms updated to be scrollable, resizable and maximised by default
  • Larger, more readable fonts throughout the application

FUTURE VERSIONS
───────────────
  • Service Request Status form (Part 3)
  • Persistent storage (database or file)
  • Real-time municipal data integration
  • User accounts and login
  • Push notifications for event reminders
  • Analytics dashboard for municipal officials

═══════════════════════════════════════════════════════════════════════════════
                              END OF README
═══════════════════════════════════════════════════════════════════════════════
