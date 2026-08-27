# MunicipalServices
═══════════════════════════════════════════════════════════════════════════════
                     MUNICIPAL SERVICES APPLICATION
                              PROG7312 - POE
                           PART 1: REPORT ISSUES
═══════════════════════════════════════════════════════════════════════════════

📋 TABLE OF CONTENTS
───────────────────────────────────────────────────────────────────────────────
1. Overview
2. System Requirements
3. Installation Instructions
4. Compilation Instructions
5. How to Use the Application
6. Features Overview
7. Troubleshooting
8. Contact Information
9. Version History

═══════════════════════════════════════════════════════════════════════════════

1. OVERVIEW
───────────────────────────────────────────────────────────────────────────────

The Municipal Services Application is a C# .NET Framework Windows Forms 
application developed for a South African municipality to improve citizen 
engagement and service delivery. 

This application enables residents to:
✓ Report issues and request municipal services
✓ Attach images or documents to support their reports
✓ Track their engagement through gamification features
✓ View all submitted reports

This is Part 1 of the Portfolio of Evidence (POE) project for PROG7312/
AAPD7112/w - Advanced Application Development.

═══════════════════════════════════════════════════════════════════════════════

2. SYSTEM REQUIREMENTS
───────────────────────────────────────────────────────────────────────────────

HARDWARE REQUIREMENTS:
─────────────────────
• Processor: 1.6 GHz or faster
• RAM: 2 GB minimum (4 GB recommended)
• Hard Disk: 50 MB free space
• Screen Resolution: 1024 x 768 or higher

SOFTWARE REQUIREMENTS:
─────────────────────
• Operating System: Windows 7, 8, 10, or 11
• .NET Framework: Version 4.7.2 or higher
• Visual Studio: 2019 or 2022 (for compilation)

DEPENDENCIES:
────────────
• System.Windows.Forms
• System.Drawing
• System.IO

═══════════════════════════════════════════════════════════════════════════════

3. INSTALLATION INSTRUCTIONS
───────────────────────────────────────────────────────────────────────────────

METHOD A: RUN FROM EXECUTABLE (No Installation Required)
─────────────────────────────────────────────────────────

1. Navigate to the bin\Debug or bin\Release folder
2. Double-click MunicipalServices.exe
3. The application will launch immediately

METHOD B: INSTALL FROM SOURCE CODE
───────────────────────────────────

1. Extract the project files to your desired location
2. Open the solution file: MunicipalServices.sln
3. Build the solution (see Compilation Instructions below)
4. Run the application

═══════════════════════════════════════════════════════════════════════════════

4. COMPILATION INSTRUCTIONS
───────────────────────────────────────────────────────────────────────────────

USING VISUAL STUDIO (Recommended)
──────────────────────────────────

1. Open Visual Studio 2019 or 2022
2. Go to File → Open → Project/Solution
3. Navigate to the project folder and select MunicipalServices.sln
4. Click Open
5. Ensure the solution configuration is set to "Debug" or "Release"
6. Go to Build → Build Solution (or press Ctrl+Shift+B)
7. The compiled executable will be in:
   - Debug: bin\Debug\MunicipalServices.exe
   - Release: bin\Release\MunicipalServices.exe

USING COMMAND LINE (Advanced)
─────────────────────────────

1. Open Developer Command Prompt for Visual Studio
2. Navigate to the project directory:
   cd path\to\MunicipalServices
3. Compile using MSBuild:
   msbuild MunicipalServices.sln /p:Configuration=Debug

═══════════════════════════════════════════════════════════════════════════════

5. HOW TO USE THE APPLICATION
───────────────────────────────────────────────────────────────────────────────

MAIN MENU
─────────

Upon startup, you will see the Main Menu with three options:

┌─────────────────────────────────────────────────────────────┐
│  Municipal Services Application                           │
│  ════════════════════════════════════════════════════════  │
│  Welcome to Municipal Services!                          │
│  Please select one of the options below to continue.    │
│                                                         │
│  ┌─────────────────────────────────────────────────────┐ │
│  │  Report Issues              [ACTIVE]               │ │
│  └─────────────────────────────────────────────────────┘ │
│                                                         │
│  ┌─────────────────────────────────────────────────────┐ │
│  │  Local Events and Announcements (Coming Soon)      │ │
│  └─────────────────────────────────────────────────────┘ │
│                                                         │
│  ┌─────────────────────────────────────────────────────┐ │
│  │  Service Request Status (Coming Soon)              │ │
│  └─────────────────────────────────────────────────────┘ │
│                                                         │
│                                              ┌──────┐   │
│                                              │ Exit │   │
│                                              └──────┘   │
└─────────────────────────────────────────────────────────────┘

REPORT ISSUES FORM
──────────────────

1. Click the "Report Issues" button on the Main Menu
2. Fill in the following fields:
   a. Location: Enter the address or area of the issue
   b. Category: Select from the dropdown menu
   c. Description: Provide a detailed description
3. (Optional) Attach Media:
   a. Click "Attach Media" button
   b. Select an image or document file
   c. File types supported: .jpg, .jpeg, .png, .gif, .bmp, .pdf, .doc, .docx, .txt
4. Click "Submit" to report the issue
5. View your engagement progress:
   - Progress bar shows your reporting activity
   - Points increase with each report
   - Achievement messages appear for milestones
6. Use "View Reports" to see all submitted issues
7. Click "Clear" to reset the form
8. Click "Back to Menu" to return to the Main Menu

═══════════════════════════════════════════════════════════════════════════════

6. FEATURES OVERVIEW
───────────────────────────────────────────────────────────────────────────────

┌─────────────────────────────────────────────────────────────────────────────┐
│  FEATURE                    │  DESCRIPTION                                 │
├─────────────────────────────┼──────────────────────────────────────────────┤
│  Issue Reporting            │  Submit issues with location, category, and  │
│                             │  detailed description                       │
├─────────────────────────────┼──────────────────────────────────────────────┤
│  File Attachment            │  Attach images or documents using           │
│                             │  OpenFileDialog                             │
├─────────────────────────────┼──────────────────────────────────────────────┤
│  Gamification System        │  Points system:                             │
│                             │  • 10 points per report                     │
│                             │  • 5 bonus points for attachment            │
├─────────────────────────────┼──────────────────────────────────────────────┤
│  Achievement Badges         │  • First Report (1 report)                  │
│                             │  • Community Contributor (5 reports)        │
│                             │  • Community Champion (10 reports)          │
├─────────────────────────────┼──────────────────────────────────────────────┤
│  Progress Tracking          │  Visual progress bar showing engagement     │
│                             │  level up to 100 points                     │
├─────────────────────────────┼──────────────────────────────────────────────┤
│  View Reports               │  Display all submitted reports with         │
│                             │  details and status                         │
├─────────────────────────────┼──────────────────────────────────────────────┤
│  Form Validation            │  Required field validation with user        │
│                             │  feedback                                   │
├─────────────────────────────┼──────────────────────────────────────────────┤
│  Data Storage               │  Issues stored in memory using List         │
│                             │  data structure                             │
├─────────────────────────────┼──────────────────────────────────────────────┤
│  Navigation                 │  Clear, View Reports, and Back buttons      │
│                             │  for easy navigation                        │
└─────────────────────────────────────────────────────────────────────────────┘

═══════════════════════════════════════════════════════════════════════════════

7. TROUBLESHOOTING
───────────────────────────────────────────────────────────────────────────────

PROBLEM: Application won't start
─────────────────────────────────
• Solution: Ensure .NET Framework 4.7.2 or higher is installed
• Download from: https://dotnet.microsoft.com/download/dotnet-framework

PROBLEM: Compilation errors in Visual Studio
─────────────────────────────────────────────
• Solution: Check that all references are properly included
• Solution: Clean and rebuild the solution (Build → Clean Solution, then Build → 
  Rebuild Solution)

PROBLEM: Attachments not uploading
───────────────────────────────────
• Solution: Ensure files are under 5MB
• Solution: Check file permissions in the selected folder
• Solution: Verify file types are supported:
  Images: .jpg, .jpeg, .png, .gif, .bmp
  Documents: .pdf, .doc, .docx, .txt

PROBLEM: Form not displaying correctly
───────────────────────────────────────
• Solution: Check screen resolution (minimum 1024 x 768)
• Solution: Ensure Windows display scaling is set to 100%

PROBLEM: "ReportIssuesForm" not found error
────────────────────────────────────────────
• Solution: Ensure all project files are in the correct namespace
• Solution: Check that ReportIssuesForm.cs and .Designer.cs exist

PROBLEM: Data not persisting after application closes
─────────────────────────────────────────────────────
• Note: This version stores data in memory only
• Data will be lost when the application closes
• Part 2 of the POE will implement persistent storage

═══════════════════════════════════════════════════════════════════════════════

8. CONTACT INFORMATION
───────────────────────────────────────────────────────────────────────────────

For technical support or questions regarding this application:

Student Name: Sbonakaliso Madlopha
Student Number: ST10377944
Module: PROG7312 - Advanced Application Development

───────────────────────────────────────────────────────────────────────────────

9. VERSION HISTORY
───────────────────────────────────────────────────────────────────────────────

Version 1.0 (Part 1)
───────────────────
- Initial release
- Main Menu with three navigation options
- Report Issues form with full functionality
- File attachment using OpenFileDialog
- Gamification system (points, progress bar, achievements)
- View Reports functionality
- Form validation and user feedback
- Data storage using List data structure

Future Versions (Part 2)
───────────────────────
- Local Events and Announcements
- Service Request Status
- Persistent data storage
- Enhanced gamification features
- Reporting analytics

═══════════════════════════════════════════════════════════════════════════════
                             END OF README
═══════════════════════════════════════════════════════════════════════════════
