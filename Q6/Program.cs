using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };
        fruits.Add("Orange");
        fruits.Remove("Banana");

        Console.WriteLine("Fruits List:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitDict = new Dictionary<int, string>()
        {
            {1, "Apple"},
            {2, "Mango"},
            {3, "Orange"}
        };

        fruitDict.Add(4, "Grapes");

        Console.WriteLine("\nFruit Dictionary:");
        foreach (var kvp in fruitDict)
        {
            Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
        }
    }
}
