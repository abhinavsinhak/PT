using System;

class Program
{
    enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    static void Main()
    {
        DayOfWeek today = DayOfWeek.Wednesday;
        Console.WriteLine("Today is " + today);

        switch (today)
        {
            case DayOfWeek.Sunday:
            case DayOfWeek.Saturday:
                Console.WriteLine("It's the weekend!");
                break;
            default:
                Console.WriteLine("It's a weekday.");
                break;
        }

        Console.WriteLine("Days of the week:");
        foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
        {
            Console.WriteLine(day);
        }

        int dayIndex = (int)today;
        Console.WriteLine("Day index of today: " + dayIndex);

        DayOfWeek dayFromIndex = (DayOfWeek)3;
        Console.WriteLine("Day from index 3: " + dayFromIndex);
    }
}