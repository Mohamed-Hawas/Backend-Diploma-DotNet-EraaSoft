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
1. Start app.
2. Choose `2. Teacher Mode` → add questions (e.g., 3).
3. Choose `1. Student Mode` → answer questions.
4. See final score.

