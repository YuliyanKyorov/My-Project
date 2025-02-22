using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the start date (dd.MM.yyyy): ");
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

        Console.Write("Enter the starting shift (1 for first shift, 2 for second shift, 3 for night shift, P for rest): ");
        string startShift = Console.ReadLine();

        string[] shifts = { "1", "1", "2", "2", "3", "3", "P", "P" };
        int shiftIndex = Array.IndexOf(shifts, startShift);

        if (shiftIndex == -1)
        {
            Console.WriteLine("Invalid starting shift.");
            return;
        }

        int year = startDate.Year;
        DateTime endDate = new DateTime(year, 12, 31);

        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            Console.WriteLine($"{date.ToString("dd.MM.yyyy")} - {shifts[shiftIndex]}");
            shiftIndex = (shiftIndex + 1) % shifts.Length;
        }
    }
}