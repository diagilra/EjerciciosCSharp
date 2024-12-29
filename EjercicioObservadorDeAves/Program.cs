using System;


class Program
{
    static void Main(string[] args)
    {
        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        var birdCount = new BirdCount(birdsPerDay);

        Console.WriteLine("Last week: " + string.Join(", ", BirdCount.LastWeek()));
        Console.WriteLine("Today: " + birdCount.Today());

        birdCount.IncrementTodaysCount();
        Console.WriteLine("After increment, today: " + birdCount.Today());

        Console.WriteLine("Has day without birds: " + birdCount.HasDayWithoutBirds());
        Console.WriteLine("Count for first 4 days: " + birdCount.CountForFirstDays(4));
        Console.WriteLine("Number of busy days: " + birdCount.BusyDays());
    }
}