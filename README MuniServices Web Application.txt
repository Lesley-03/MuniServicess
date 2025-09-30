README: MuniServices Web Application

Overview
MuniServices is a web-based platform designed to help citizens report municipal issues such as potholes, sanitation problems, and electricity outages. The application streamlines issue reporting, tracks status, and allows users to provide feedback once issues are resolved.

Built using ASP.NET Core MVC and styled with Bootstrap, the app emphasizes clean architecture, responsive design, and intuitive user interaction.

Features
Report Municipal Issues 
Users can submit location, category, description, and required media.

Status Tracking
Submitted issues are listed with status indicators and feedback options.

Feedback Loop
Users can rate and comment on resolved issues, updating their status.

Responsive UI 
Clean green-themed interface with consistent styling across pages.

Media Upload
Required image upload with thumbnail preview in the status table.


Technical Highlights
Framework: ASP.NET Core MVC  
Styling: Bootstrap 5 (green theme)  
Data Structure: `List<Issue>` used to manage reported issues  
Event Handling: Razor-based form submissions and button actions  
Validation: Server-side and client-side validation using Data Annotations  
Routing: Clean controller-action routing with Razor helpers  
Architecture: Separation of concerns (Models, Views, Controllers)


How to Run the Application
1. Prerequisites
Ensure the following are installed:
- Visual Studio 2022 or later
- .NET 6.0 SDK or later
- A modern web browser (e.g., Chrome, Edge)

2. Open the Project
- Extract the project folder if it was sent as a ZIP
- Open the `.sln` file (e.g., `MuniServices.sln`) in Visual Studio

3. Build the Solution
- In Visual Studio, go to Build > Build Solution or press `Ctrl+Shift+B`
- Ensure there are no build errors

4. Run the Application
- Press `F5` or click the green Start button to launch the app
- The browser will open to a URL like `https://localhost:PORT/`

5. Navigate the App
- Go to `/Home/Index` to view the homepage
- Go to `/Issues/Report` to submit a municipal issue
- After submission, you’ll be redirected to `/Issues/Status` to view the issue
- Click **Give Feedback** to rate and comment on the issue

6. File Uploads
- Uploaded media files are saved to `wwwroot/uploads/`
- Ensure this folder exists before running the app (Visual Studio should create it automatically)

7. Troubleshooting
If the app doesn’t run:
- Confirm that the `.NET SDK` is installed
- Make sure the `wwwroot/uploads/` folder exists
- Rebuild the solution and try again

8. No Database Required
This version uses in-memory storage (`List<Issue>`) for simplicity. No database setup is needed.

