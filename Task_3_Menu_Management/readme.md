# Menu Management


### Overview

`Program.cs` implements a simple interactive console application that manages an in-memory list of integers. The app displays a bordered menu and accepts a single-letter command (case-insensitive) to perform actions such as adding, printing, sorting, updating, deleting, and finding numbers, computing the mean, clearing the list, and quitting.

This project targets .NET 10 and uses a single-file top-level program (C# 14).

### Prerequisites

- .NET 10 SDK installed
- Visual Studio 2026 or the `dotnet` CLI


### Usage

When run, the program prints a bordered menu and waits for a single-letter command. Type the letter and press Enter. Some commands require additional input (numbers, counts, or pairs).

### Menu options

- `P` — Print Numbers: Display the current list.
- `A` — Add Number: Add one or more integers (duplicates are ignored).
- `M` — Calculate Mean: Compute and display the arithmetic mean.
- `S` — Find Smallest Number: Show the smallest value.
- `L` — Find Largest Number: Show the largest value.
- `F` — Find Number: Check whether a value exists in the list.
- `C` — Clear Numbers: Remove all entries.
- `O` — Sort Numbers Ascending: Sort the list in ascending order.
- `R` — Sort Numbers Descending: Sort the list in descending order.
- `W` — Swap Numbers: Swap the positions of two values.
- `U` — Update Number: Replace an existing value with a new one.
- `D` — Delete Number: Remove a specific value.
- `N` — Get Numbers Count: Show the number of items in the list.
- `Q` — Quit: Exit the program.

### Implementation notes

- The program stores data in an in-memory `List<int>` initialized with sample values.
- Local functions implement each operation (e.g., `printNumbers()`, `addNumber()`, `calculateMean()`, `findSmallestNumber()`, `findLargestNumber()`, `findNumber()`, `clearNumbers()`, `sortNumbersAscending()`, `sortNumbersDescending()`, `swapNumbers()`, `updateNumber()`, `deleteNumber()`, `getNumbersCount()`, `findIndexOfNumber()`).
- `addNumber` checks for duplicates using `findNumber` before inserting.
- Sorting is implemented with a simple restart-style swap loop (functional but O(n^2)). Prefer `numbers.Sort()` and `numbers.Reverse()` for production code.
- Input parsing assumes well-formed input; add validation for robustness.
- Methods that fail to find a value return `-1` or `false` and print a not-found message.

### Example session

1. Run the app.
2. Press `P` to print the default list (e.g., `8, 5, 3, 2, 0, 9`).
3. Press `A` and add `7`.
4. Press `O` to sort ascending and `P` to print.
5. Press `Q` to quit.




