# Student Management System (C# Console App)

## Overview
This is a console-based Student Management System written in C#. It allows managing students, instructors, and courses, and supports enrollment and search operations using an interactive menu-driven interface.

The project focuses on practicing:
- Object-Oriented Programming (OOP)
- Collections (List<T>)
- Basic user input handling
- Separation of concerns (Program vs Manager vs Entities)

---

## Features
- Add students with auto-generated IDs
- Add instructors and assign them to courses
- Create courses linked to instructors
- Enroll students in courses
- Display all students, courses, and instructors
- Search students by ID or name
- Search courses by ID or name
- Check if a student is enrolled in a specific course
- Get instructor name by course name or ID

---

## Project Structure
```
Task_5_Student_Management_System/
│
├── Program.cs
├── StudentManager.cs
├── Student.cs
├── Instructor.cs
├── Course.cs
├── Window.cs
└── README.md
```

---

## Core Classes

### Program
- Entry point of the application
- Displays menu options
- Handles user input
- Calls `StudentManager` methods based on user choices

### StudentManager
- Central controller for the system
- Holds collections of:
  - Students
  - Courses
  - Instructors
- Responsible for:
  - Adding entities
  - Searching entities by ID or name

### Student
- Properties:
  - Id (Guid)
  - Name
  - Age
  - Courses (List<Course>)
- Methods:
  - Enroll(Course)
  - PrintDetails()

### Instructor
- Properties:
  - Id (Guid)
  - Name
  - Department
- Methods:
  - PrintDetails()

### Course
- Properties:
  - Id (Guid)
  - Title
  - Instructor
- Methods:
  - PrintDetails()

### Window
- Responsible for UI formatting
- Displays menu options with a fixed width
- Handles option selection and validation

---

## How It Works
1. The application starts and displays a numbered menu
2. The user selects an operation
3. Input is read from the console
4. The system performs validation and processing
5. Results are printed to the console
6. The loop continues until the user chooses Exit

---

## Sample Operations
- Add a student by entering name and age
- Create a course by linking it to an existing instructor
- Enroll a student in a course by name
- Search entities using either ID (Guid) or name

---

## Error Handling
- Basic validation for missing entities
- Graceful messages when student, course, or instructor is not found
- Invalid menu selections are handled

---

## Requirements
- .NET SDK (6.0 or later)
- Console environment

---

## How to Run
1. Clone the repository
2. Open the project in Visual Studio or VS Code
3. Build the solution
4. Run the application
5. Follow the on-screen menu

---

## Notes
- Data is stored in memory only
- No database or file persistence
- IDs are generated using `Guid`
- Designed for educational and practice purposes

---

## Future Improvements
- Add data persistence (JSON or database)
- Improve input validation
- Add update and delete operations
- Refactor UI layer for better separation
- Add unit tests

