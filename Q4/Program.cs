using System;

class Program
{
    static void Main()
    {
        int[] favNumbers = { 5, 2, 9, 1, 7 };

        Array.Sort(favNumbers);
        Array.Reverse(favNumbers);

        Console.WriteLine("Reversed Sorted Array:");
        for (int i = 0; i < favNumbers.Length; i++)
        {
            Console.WriteLine(favNumbers[i]);
        }

        int searchNumber = 7;
        int position = Array.IndexOf(favNumbers, searchNumber);
        Console.WriteLine($"Position of {searchNumber} in array: {position}");
    }
}
