using System;
using System.Linq;

// 1. Get the initial array
Console.Write("Enter numbers (e.g., 2,3,5): ");
int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

while (true)
{
    // 2. Display the menu
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Show array");
    Console.WriteLine("2. Provide new array");
    Console.WriteLine("3. Exit");
    Console.Write("Select an option: ");

    string choice = Console.ReadLine();

    // 3. Handle the choices
    if (choice == "1")
    {
        Console.WriteLine("Current array: " + string.Join(", ", numbers));
    }
    else if (choice == "2")
    {
        Console.Write("Enter new numbers (will override old): ");
        // This overrides the existing 'numbers' variable entirely
        numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        Console.WriteLine("Array updated!");
    }
    else if (choice == "3")
    {
        Console.WriteLine("Goodbye!");
        break; // Breaks the while loop to exit the program
    }
}