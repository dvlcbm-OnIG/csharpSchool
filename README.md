# SchoolRelated

This repo is a collection of my C# console activities for **Pre-Midterm** and **Midterm**.

## Clone This Repo (Start Here)

- Open **Visual Studio / VS Code** first.
- Open the built-in terminal there (do not use an external terminal).
- Run: `git clone https://github.com/dvlcbm-OnIG/csharpSchool.git`
- Move into the repo: `cd SchoolRelated`

Everything here is practice-focused:
- user input and output
- conversions (`Convert.ToInt32`, `Convert.ToDouble`, etc.)
- `if/else` and `switch`
- basic OOP (inheritance, overriding, sealed classes)
- simple math/computation exercises

## Tech Stack

- Language: C#
- Project type: .NET console apps
- Target framework: `net10.0`

## Repo Layout

```text
SchoolRelated/
  schoolRelated.slnx
  preMid/
    pmExam/
    quiz1/
    quiz2/
  midTerm/
    mtExam/
    quiz1/
    quiz2/
```

## What Each Project Does

### preMid/quiz1

Menu-driven app with 5 mini programs:
1. Gamer Profile
2. Tech Support Ticket
3. Smart Savings Tracker
4. Superhero Identity
5. RPG Inventory Check

Main focus:
- string input/output formatting
- integer conversion and basic arithmetic
- `switch` menu flow

### preMid/quiz2

Single run that asks inputs for 10 conditional/computation items, including:
- property discount
- fever alert
- grade check
- bulk order pricing
- password strength
- wage with overtime
- water state
- student discount flag
- menu char check (`S` or `E`)
- speed fine

Main focus:
- chained `if/else if/else`
- mixed data types (`double`, `float`, `int`, `decimal`, `bool`, `char`)

### preMid/pmExam

Small menu app with 2 options:
1. Calculate circle area from radius
2. Apply weight adjustment when weight is over threshold

Main focus:
- menu + condition handling
- input validation for radius and choice

### midTerm/quiz1

Simple geometry output app with methods for:
- cube
- rectangular prism
- cylinder
- cone
- sphere
- hemisphere

Main focus:
- writing reusable static methods
- printing computed results

### midTerm/quiz2

OOP-focused activity with 10 parts in one file, covering:
- inheritance (`Smartphone : ElectronicDevice`, etc.)
- method overriding (`Dog.MakeSound()`)
- sealed class example (`FinalReport`)
- field access through parent/child classes
- simple computation inside class methods

Main focus:
- class relationships and object usage
- practical OOP basics for class exercises

### midTerm/mtExam

Starter project right now (`Hello, World!`).

Main focus:
- project placeholder for midterm exam work

## How To Run

### Option 1: From VS Code

Open this folder and run the project you want from terminal.

### Option 2: From terminal (recommended)

From repo root, use one of these:

```bash
dotnet run --project preMid/quiz1/quiz1.csproj
dotnet run --project preMid/quiz2/quiz2.csproj
dotnet run --project preMid/pmExam/pmExam.csproj
dotnet run --project midTerm/quiz1/quiz1.csproj
dotnet run --project midTerm/quiz2/quiz2.csproj
dotnet run --project midTerm/mtExam/mtExam.csproj
```

## Notes

- Most projects end with `Console.ReadKey()` so the output stays visible.
- The solution file is `schoolRelated.slnx` and includes all 6 projects.
- There are also item-specific instructions in:
  - `preMid/quiz1/readme.md`
  - `preMid/quiz2/readme.md`

## Why This Repo Exists

This repo tracks my school progress topic by topic. It is not one big app; it is a set of focused console exercises to practice core C# skills.