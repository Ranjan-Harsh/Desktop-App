# FormSubmissionApp

## Overview
This project consists of a Windows Desktop application built using Visual Basic and a backend server built using Node.js, Express, and TypeScript. The application allows users to create and view form submissions with a stopwatch feature. The backend stores submissions in a JSON file.

## Features
1. Create new submissions with Name, Email, Phone Number, and GitHub repo link.
2. View all submissions with navigation between them.
3. Stopwatch to measure time, which can be started and stopped.
4. All submissions are stored on the backend and can be retrieved using an API.

## Requirements
- Visual Studio (with Visual Basic support)
- Node.js
- npm

## Frontend Setup

### 1. Clone the Repository
```bash
git clone https://github.com/Ranjan-Harsh/Desktop-App.git
cd FormSubmissionApp
```

### 2. Open the Project in Visual Studio
- Open Visual Studio.
- Click on `File` > `Open` > `Project/Solution`.
- Navigate to the cloned repository directory and select `FormSubmissionApp.sln`.

### 3. Set Startup Form
- Ensure `MainForm` is set as the startup form.
  - Right-click on the project in the Solution Explorer and select `Properties`.
  - Go to the `Application` tab.
  - Set the `Startup form` to `MainForm`.

### 4. Build and Run the Project
- Build the solution by going to `Build` > `Build Solution`.
- Run the application by pressing `F5` or by going to `Debug` > `Start Debugging`.

## Usage

### Create a New Submission
- Open the application.
- Click on the "CREATE NEW SUBMISSION (CTRL + N)" button or press `Ctrl + N`.
- Fill in the fields and use the stopwatch if needed.
- Click "SUBMIT (CTRL + S)" or press `Ctrl + S` to save the submission.
- All text fields will be cleared after submission.

### View Submissions
- Click on the "VIEW SUBMISSIONS (CTRL + V)" button or press `Ctrl + V`.
- Use "PREVIOUS (CTRL + P)" and "NEXT (CTRL + N)" buttons or shortcuts to navigate through the submissions.

## Notes
- Ensure the backend server is running before using the frontend application to avoid any connectivity issues.
- The phone number field in the Create Submission form is limited to 10 digits.


