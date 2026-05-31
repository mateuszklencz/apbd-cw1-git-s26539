using System;
using System.Linq; // Required for .Sum()

namespace apbd1
{
    public class StatisticsHelper
    {
        public double CalculateAverage(int[] numbers)
        {
            // Arrays use .Length, not .Count
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("The array of numbers cannot be null or empty.");

            double sum = numbers.Sum(); // LINQ

            return sum / numbers.Length;
        }

    public int CalculateMax(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("The array of numbers cannot be null or empty.");
            return numbers.Max(); // LINQ
        }

    public int CalculateMin(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("The array of numbers cannot be null or empty.");
            return numbers.Min(); // LINQ
        }

    public int CalculateMode(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("The array of numbers cannot be null or empty.");

            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++; 
                }
                else
                {
                    counts[num] = 1; 
                }
            }

            int mode = numbers[0];
            int maxCount = 0;

            foreach (KeyValuePair<int, int> pair in counts)
            {
                if (pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    mode = pair.Key;
                }
            }

            return mode;
        }

    }
}