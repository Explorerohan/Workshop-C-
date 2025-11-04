using System;

class Program
{
    static void Main()
    {
        DateTime birthDate = new DateTime(1998, 7, 15);
        DateTime currentDate = DateTime.Now;

        TimeSpan ageSpan = currentDate - birthDate;
        int ageInYears = (int)(ageSpan.Days / 365.25);

        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Current Date: {currentDate}");
        Console.WriteLine($"Age: {ageInYears} years");

        DateTime plusTenDays = birthDate.AddDays(10);
        Console.WriteLine($"Birthdate + 10 days: {plusTenDays.ToShortDateString()}");
    }
}
