using System;
using System.Linq;
using apbd1;

StatisticsHelper statsHelper = new StatisticsHelper(); // to make calculations available in the menu

// 1. Initial array input
int[] numbers = GetArrayFromUser();

while (true)
{
    // 2. Display the menu
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Show array");
    Console.WriteLine("2. Provide new array");
    Console.WriteLine("3. Calculate Average");
    Console.WriteLine("4. Find Maximum Value");
    Console.WriteLine("5. Find Minimum Value");
    Console.WriteLine("6. Exit");
    Console.Write("Select an option: ");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("Current array: " + string.Join(", ", numbers));
    }
    else if (choice == "2")
    {
        // 3. Override old array with validated new input
        numbers = GetArrayFromUser();
        Console.WriteLine("Array updated!");
    }
    else if (choice == "3")
    {
        double average = statsHelper.CalculateAverage(numbers);
        Console.WriteLine($"Average: {average:F2}"); // Formatted to 2 decimal places
    }
    else if (choice == "4")
    {
        int max = statsHelper.CalculateMax(numbers);
        Console.WriteLine($"Maximum value: {max}");
    }
    else if (choice == "5")
    {
        int min = statsHelper.CalculateMin(numbers);
        Console.WriteLine($"Minimum value: {min}");
    }
    else if (choice == "6")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid option. Please choose a number between 1 and 6.");
    }
}

// Reusable helper method to handle input and error messages
int[] GetArrayFromUser()
{
    while (true)
    {
        Console.Write("Enter numbers separated by commas (e.g., 2,3,5): ");
        string input = Console.ReadLine();

        // Split the strings and remove any extra spaces
        string[] rawTokens = input.Split(',').Select(t => t.Trim()).ToArray();
        int[] parsedNumbers = new int[rawTokens.Length];
        bool isValid = true;

        for (int i = 0; i < rawTokens.Length; i++)
        {
            // Try to parse. If it fails, trigger the error
            if (!int.TryParse(rawTokens[i], out parsedNumbers[i]))
            {
                Console.WriteLine($"\n[ERROR] '{rawTokens[i]}' is not a valid number. Please try again.\n");
                isValid = false;
                break; // Break the FOR loop to ask for input again
            }
        }

        if (isValid) return parsedNumbers; // Exit the function with the valid array
    }
}