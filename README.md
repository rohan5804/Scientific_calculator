# Scientific Calculator

A comprehensive C# console-based Scientific Calculator application built with .NET Framework.

## Features

- **Mathematical Operations**:
  - Power calculation
  - Highest Common Factor (HCF / GCD)
  - Lowest Common Multiple (LCM)
  - Simple Interest calculation
  - Compound Interest calculation
- **Array Operations**:
  - Array sorting, searching, and statistical computations
- **String Operations**:
  - Text manipulation, reverse, palindrome checks, and conversions
- **Number Operations**:
  - Prime checks, factorial, Fibonacci sequences, and number analysis
- **Modular Arithmetic Libraries**:
  - `Add` - Addition library
  - `Subtract` - Subtraction library
  - `Multiply` - Multiplication library
  - `Divide` - Division library
- **Session History**:
  - View calculation results history
  - Clear results cache

## Solution Structure

```text
Calculator/
├── Calculator.slnx          # Visual Studio Solution
├── Calculator/              # Main Console Application
│   ├── program.cs           # Main entry point & interactive menu
│   ├── Mathematical Operations.cs
│   ├── Array Operations.cs
│   ├── String Operations.cs
│   └── Number Operations.cs
├── Add/                     # Addition class library
├── Subtract/                # Subtraction class library
├── Multiply/                # Multiplication class library
└── Divide/                  # Division class library
```

## Getting Started

### Prerequisites

- Visual Studio 2022 or newer (with .NET Framework 4.7.2 support)
- .NET Framework 4.7.2 Developer Pack or SDK

### Building and Running

1. Open `Calculator.slnx` in Visual Studio.
2. Set `Calculator` as the startup project.
3. Build and run the solution (`F5` or `Ctrl + F5`).
