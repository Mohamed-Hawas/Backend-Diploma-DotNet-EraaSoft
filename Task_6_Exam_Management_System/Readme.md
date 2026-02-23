# Exam Management System

Simple console-based Exam Management System implemented in .NET 10.  
Supports three question types: True/False, Choose One (single correct), and MCQ (multiple correct). The system provides two modes: Teacher Mode (create exam) and Student Mode (take exam and get a result).

## Features
- Add questions interactively (Teacher Mode).
- Take the exam and collect student answers (Student Mode).
- Calculate and display final score.
- Question metadata: title, mark, level (easy/medium/hard).
- Basic in-memory model; no persistence.

## Project layout
- `Program.cs` — Console UI and interactive flows for Teacher and Student modes. Contains helper methods to create questions.
- `Exam.cs` — Holds `List<Question>` and computes overall result via `GetResult()`.
- `Question.cs` — Abstract base class, common properties (`QTitle`, `QType`, `QMark`, `QLevel`, `QChoices`) and abstract `GetResult()` method. Also defines `QuestionType` and `QuestionLevel` enums.
- `TrueOrFalse.cs` — `TrueOrFalse` question implementation.
- `ChooseOne.cs` — `ChooseOne` question implementation.
- `MCQ.cs` — `MCQ` (multiple correct answers) implementation.
- `Choices.cs` — Small wrapper around a `string[4]` to store choices.

## Example workflow
```text
**************************************************
*   1. Student Mode                              *
*   2. Teacher Mode                              *
*   3. Quit                                      *
**************************************************
Enter your option : 2

How many questions do you want to add in the exam ? : 3

Enter question 1 :
What is the type of question?
 1. True/False
 2. Choose one
 3. MCQ
Enter your choice:(1, 2 or 3) : 1
Enter the question level (easy, medium, hard) : easy
Enter the mark of the question : 1
Enter the question title : C# is a statically typed language.
Enter the number of correct answer (True or False): true

Enter question 2 :
What is the type of question?
 1. True/False
 2. Choose one
 3. MCQ
Enter your choice:(1, 2 or 3) : 2
Enter the question level (easy, medium, hard) : medium
Enter the mark of the question : 2
Enter the question title : Which keyword is used to define a method that can be overridden?
Enter choice 1 : static
Enter choice 2 : virtual
Enter choice 3 : sealed
Enter choice 4 : const
Enter the number of correct answer : 2

Enter question 3 :
What is the type of question?
 1. True/False
 2. Choose one
 3. MCQ
Enter your choice:(1, 2 or 3) : 3
Enter the question level (easy, medium, hard) : hard
Enter the mark of the question : 3
Enter the question title : Which of the following are valid C# collection types?
Enter choice 1 : List<T>
Enter choice 2 : 2DArray
Enter choice 3 : Stack<T>
Enter choice 4 : PointerArray
Enter the numbers of correct answer : 1 3

**************************************************
*   1. Student Mode                              *
*   2. Teacher Mode                              *
*   3. Quit                                      *
**************************************************
Enter your option : 1

========= Start Exam =========

Question 1
QType : TrueOrFalse   QMark : 1   QLevel : Easy
C# is a statically typed language.
1. True.
2. False.
Answer : true

Question 2
QType : ChooseOne   QMark : 2   QLevel : Medium
Which keyword is used to define a method that can be overridden?
1. static.
2. virtual.
3. sealed.
4. const.
Answer : 2

Question 3
QType : MCQ   QMark : 3   QLevel : Hard
Which of the following are valid C# collection types?
1. List<T>.
2. 2DArray.
3. Stack<T>.
4. PointerArray.
Answer : 1 3

Result : 6 / 6

**************************************************
*   1. Student Mode                              *
*   2. Teacher Mode                              *
*   3. Quit                                      *
**************************************************
Enter your option : 3
```

