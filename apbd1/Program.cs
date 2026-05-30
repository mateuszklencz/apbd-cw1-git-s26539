using System;

Console.Write("Enter numbers in formatk like: 2, 3, 5 ");

// One-liner to read, split, parse, and store into an array
int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

// Verification (Just to prove it's in the array)
Console.WriteLine($"Saved {numbers.Length} items. First item is: {numbers[0]}");