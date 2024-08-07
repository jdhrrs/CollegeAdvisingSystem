# Advising System

## Overview
This project is part of the CISS 311 Advanced Agile Software Development course. It is an Advising System application developed using C# and Windows Forms. The system provides various functionalities to manage and update information related to advisors, advisees, and courses.

## Features
- **Add Advisee**: Add a new advisee to the system.
- **Add Course**: Add a new course to the system.
- **Update Advisee**: Update the name of an advisee.
- **Change Advisor**: Change the advisor assigned to an advisee.
- **Update Advisor**: Update the advisor's information.
- **Delete Course**: Delete a course from the system.
- **Close**: Exit the application.

## Getting Started
To run this project locally, follow these steps:

### Prerequisites
- Visual Studio 2022 or later
- .NET Framework 4.8 or later
- SQL Server or LocalDB

### Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/advising-system.git

2. Open AdvisingSystem.sln in visual studios.
3. Restore the NuGet Packages

### Database Setup
Create two databases: AdvisingDB and TeachingDB.
Use the provided SQL scripts to create the required tables and populate initial data.

### Configuration
Update the connection string for the database in Settings.setings with this: 
<connectionStrings>
  <add name="connStringAdvisingDB" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdvisingDB;Integrated Security=True;" providerName="System.Data.SqlClient" />
  <add name="connStringTeachingDB" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TeachingDB;Integrated Security=True;" providerName="System.Data.SqlClient" />
</connectionStrings>

### Run the Application: 
Build the solution in Visual Studio.
Run the application.

### Usage
Usage
Add Advisee: Click the "Add Advisee" button, fill in the required fields, and save.
Add Course: Click the "Add Course" button, fill in the required fields, and save.
Update Advisee: Click the "Update Advisee" button, enter the advisee ID, update the name, and save.
Change Advisor: Click the "Change Advisor" button, enter the advisee ID, select a new advisor, and save.
Update Advisor: Click the "Update Advisor" button to update advisor information.
Delete Course: Click the "Delete Course" button, enter the course ID, and delete the course.
Close: Click the "Close" button to exit the application.

### Authors
Justin Harris - Student Developer 
