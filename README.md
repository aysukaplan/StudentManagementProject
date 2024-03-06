# StudentManagementProject

## Overview
Welcome to the Student Management Project! This project was developed during an internship at Anadolu Sigorta, the first national insurance company in Turkey. The focus of the internship was on Backend development within the RH (Rücu-hasar) team, and the project aimed to familiarize me with the technologies used in the company, primarily the .Net Framework.

## Technologies Used
- **Backend Development:** .Net Framework
- **Frontend Development:** Bootstrap, HTML, CSS, JavaScript
- **IDE:** Visual Studio Code
- **API Testing:** Postman

## Project Details
### Purpose
The Student Management Project serves as a comprehensive system for managing students, teachers, and administrators.

### Features
- Create, Read, Update, and Delete (CRUD) operations for students, teachers, and admins.
- Focus on Restful API design.

### Frontend Features
- Student-specific operations.
- Add, edit, and delete student functionalities.

### Backend Features
- Models: Admin, Student, and Teacher, all inherited from the Person model.
- API controllers for Admin, Student, and Teacher with appropriate HTTP methods.
- Routes designed for API interactions.

### Project Workflow
1. **Add New Student:**
   - Clicking the "Add New Student" button opens a form to add a new student to the list.

2. **Edit Student's Information:**
   - Clicking the edit button allows for the modification of student information (excluding ID).

3. **Delete a Student:**
   - Confirming deletion removes the student from the list.

### Implementation Details
1. **Models and Data Generation:**
   - Models created for Admin, Student, and Teacher.
   - Random data generated for models using a Data Generator website.

2. **API Controllers and Routes:**
   - Separate controllers for Admin, Student, and Teacher with appropriate HTTP methods.
   - Admin Controller includes Post, Put, and Delete methods for all models.

3. **Frontend Development:**
   - Solid principles applied to facilitate future feature additions.
   - Bootstrap used for designing a data table for students.
   - jQuery Ajax calls to connect the API to the website.

4. **Database Management (Future Work):**
   - SQL intended for use in the project; however, time constraints during the internship prevented its implementation.

5. **Project Management Observations:**
   - Exposure to Scrum and Agile project management methods.

## Conclusion
The Student Management Project provides a hands-on experience in Backend and Frontend development, offering insights into Restful API design, data modeling, and project management methodologies. Feel free to explore and enhance the project further!
