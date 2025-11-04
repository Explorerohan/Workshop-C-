using System;

class Program
{
    static void Main()
    {
        byte b = 10;
        short s = 1000;
        int i = 42000;
        long l = 1000000L;
        float f = 3.14F;
        double d = 9.81;
        decimal dec = 123.45M;
        char c = 'A';
        bool isActive = true;

        string intToString = i.ToString();
        double stringToDouble = Convert.ToDouble("3.14");

        Console.WriteLine($"byte: {b}");
        Console.WriteLine($"short: {s}");
        Console.WriteLine($"int: {i}");
        Console.WriteLine($"long: {l}");
        Console.WriteLine($"float: {f}");
        Console.WriteLine($"double: {d}");
        Console.WriteLine($"decimal: {dec}");
        Console.WriteLine($"char: {c}");
        Console.WriteLine($"bool: {isActive}");
        Console.WriteLine($"Converted int to string: {intToString}");
        Console.WriteLine($"Converted string to double: {stringToDouble}");
    }
}
