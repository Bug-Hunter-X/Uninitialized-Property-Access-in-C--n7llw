# Uninitialized Property Access in C#

This repository demonstrates a subtle error in C# that can occur when accessing properties of a class before they are explicitly initialized. While not always resulting in an immediate exception, it can lead to unpredictable behavior and hard-to-debug issues.

The `bug.cs` file showcases the problematic code. The `bugSolution.cs` file provides a corrected version.

## Problem

In C#, class properties are automatically initialized to their default values (e.g., 0 for integers, null for strings). However, relying on this default initialization can sometimes lead to unexpected behavior.

## Solution

The solution involves explicitly initializing the property in the constructor or before accessing it to ensure a defined state.