using System;

class Circle
{
    // Declare a constant PI
    public const double PI = 3.14;

    // Method to calculate Area
    public double Area(double radius)
    {
        return PI * radius * radius;
    }

    // Method to calculate Perimeter (Circumference)
    public double Perimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {
        Circle c = new Circle();

        double radius = 5;

        Console.WriteLine($"Area = {c.Area(radius)}");
        Console.WriteLine($"Perimeter = {c.Perimeter(radius)}");

        // Tried to modify PI (This will cause a compilation error)
        // Circle.PI = 3.14159;
    }
}
