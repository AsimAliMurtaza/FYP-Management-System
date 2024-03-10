# FYP-Management-System

## Introduction
The Final Year Project Management System (FYPM) is a sophisticated software platform developed to streamline the management and evaluation of final year projects in academic institutions. It serves as a centralized hub for students, faculty advisors, and administrators to collaborate effectively throughout the entire lifecycle of final year projects, from project initiation to evaluation and grading.

### Purpose
The primary purpose of the FYPM system is to optimize and enhance the management, supervision, and evaluation processes associated with final year projects. By leveraging advanced technology and automation, the system aims to achieve the following objectives:
1. **Streamline Evaluation Procedures:** Through automated evaluation criteria and grading mechanisms, the system simplifies the process of project assessment for faculty members. It ensures consistency, fairness, and transparency in the evaluation process.
2. **Enhance Administrative Efficiency:** By centralizing project-related data and administrative tasks, the system reduces manual effort and administrative overhead. It enables administrators to manage project allocations, monitor project timelines, and generate reports efficiently.
3. **Improve Learning Outcomes:** By providing students with a structured platform for project management and supervision, the FYPM system enhances their learning experience. It fosters the development of essential skills such as project planning, execution, presentation, and teamwork.

### Significance
The FYPM system holds significant importance for various stakeholders within academic institutions:
- **For Faculty Advisors:** The system equips faculty advisors with tools and resources to supervise and evaluate multiple projects efficiently. It enables them to monitor progress and assess project outcomes objectively.
- **For Administrators:** The system enhances administrative efficiency by automating project-related tasks and data management processes. It enables administrators to allocate resources effectively, track project timelines, and generate insightful reports for decision-making purposes.

## Technology Stack
### Technologies, Frameworks, and Tools Used
- **Microsoft SQL Server (MS SQL):** Used as the relational database management system (RDBMS) to store and manage project-related data.
- **SQL Server Management Studio (SSMS):** Employed as the integrated environment for managing and administering MS SQL Server databases.
- **C#:** Utilized as the primary programming language for backend development, business logic implementation, and application logic.
- **.NET Framework 4.8:** Chosen as the development framework for building desktop, web, and mobile applications using C# and other languages.
- **Windows Forms (WinForms):** Utilized for developing desktop applications with a graphical user interface (GUI) in the Microsoft Windows operating system.
- **ADO.NET:** Employed as the data access technology for connecting to and interacting with the MS SQL Server database from the .NET application. ADO.NET provides classes and methods for performing database operations such as querying, inserting, updating, and deleting data.

## SQL Concepts
### Joins
- **Usage in Project:** Joins are extensively used in this project to retrieve data from multiple tables simultaneously. For example, in generating reports or fetching related information about students, advisors, groups, projects, and evaluations, joins are employed to link these entities together and obtain relevant data in a single query. Some commonly used joins in this project are:
  - Inner Join
  - Left Join

### Subqueries
- **Usage in Project:** Subqueries are utilized in this project to perform complex data retrieval operations. For instance, when filtering data based on aggregated results or obtaining specific information that depends on the outcome of another query, subqueries are employed to achieve such tasks efficiently.

### Aggregate Functions
- **Usage in Project:** Aggregate functions play a crucial role in this project for performing calculations on groups of data. Some commonly used aggregate functions in this project are:
  - SUM
  - AVG
  - COUNT
  - MAX
  - MIN

### Group by Clause
- **Usage in Project:** The GROUP BY clause is employed in this project to group data based on specific criteria. For instance, when calculating aggregate values such as total marks obtained by each student in evaluations or counting the number of evaluations conducted per advisor, the GROUP BY clause is utilized to organize data into logical groups before applying aggregate functions.

## Project Features
The FYP Management System offers the following key features:

### Manage Students
- Add new student records.
- Remove existing student records.
- Update student information.
- View a list of all students.

### Manage Advisors
- Add new advisor profiles.
- Update existing advisor profiles.
- View a list of all advisors.
- Delete advisor profiles.

### Manage Groups
- Create new student groups.
- View a list of all groups.
- Add students to existing groups.
- Allocate projects to groups.
- Allocate advisors to groups.

### Manage Evaluation
- Add new evaluations.
- Remove existing evaluations.
- Update evaluation details.
- View a list of all evaluations.
- Evaluate groups based on predefined criteria.

### Manage Projects
- Add new project details.
- View a list of all projects.
- Update project information.
- Delete project records.

### Manage Reports
- Generate various reports to track project progress.
- Generate reports on student performance.
- Generate reports on advisor activities.

## Deployment Process
### Server Configuration
- **Database Server:** Install and configure Microsoft SQL Server on the server machine to host the project’s database.

### Deployment Tools
- **Visual Studio 2022 Community:** Utilize Visual Studio for building, debugging, and deploying the WinForms application. Visual Studio provides integrated tools for publishing applications directly to the server.

### Dependencies
- **Guna2UI Framework:** Ensure that the Guna2UI framework is included in the deployment package. This framework provides UI components and controls for enhancing the visual appearance and functionality of the WinForms application.
- **iTextSharp Library:** Include the iTextSharp library in the deployment package. This library allows for the creation, modification, and extraction of PDF documents within the WinForms application.

### Deployment Process
1. **Build the Application:** Ensure that the WinForms application is properly built and tested within the development environment.
2. **Install Dependencies:** Install any required runtime dependencies or libraries on the server, such as .NET Framework, Guna2UI framework, and iTextSharp library.
3. **Configure Application Settings:** Update configuration files (if any) to reflect the production environment settings.
4. **Test Deployment:** Conduct thorough testing to ensure that the deployed WinForms application functions correctly in the production environment. Verify database connectivity, application functionality, and performance.
