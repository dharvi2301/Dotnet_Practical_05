# Exception Handling in C#

## Overview
This project demonstrates **exception handling** in C# using a simple program that iterates through an array and handles an `IndexOutOfRangeException`.  
The program also showcases the use of **try, catch, and finally** blocks.

---

## Code Implementation
The program:
- Creates an integer array of size `5`.
- Iterates through the array using a loop that **intentionally exceeds its bounds**.
- Uses a **try block** to access the array elements.
- Catches the **IndexOutOfRangeException** and prints the error message.
- Executes a **finally block**, ensuring that a specific message is always printed.

---

### C# Code with Concept Explanation:
```csharp
using System;

class Program
{
    static void Main()
    {
        // 1. ARRAYS IN C#
        // An array is a collection of elements of the same data type.
        int[] numbers = { 1, 2, 3, 4, 5 };

        // 2. LOOPING (for loop)
        // Loop runs from 0 to 5, intentionally going out of bounds
        for (int i = 0; i <= 5; i++)  
        {
            try
            {
                // 3. TRY BLOCK - Code that may throw an exception
                Console.WriteLine($"Value at index {i}: {numbers[i]}");
            }
            catch (IndexOutOfRangeException ex) // 4. CATCH BLOCK
            {
                // Handling IndexOutOfRangeException
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
            finally // 5. FINALLY BLOCK
            {
                // This block always executes, even if an exception occurs
                Console.WriteLine("This is finally block");
            }
        }
    }
}
```
## Below is the SS of the final output:
![image](https://github.com/user-attachments/assets/f3e13fb5-1d51-42fe-b3e1-e42cb31c2be6)

