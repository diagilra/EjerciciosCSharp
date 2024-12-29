class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    // 1. Check what the counts were last week
    public static int[] LastWeek()
    {
        return new int[] { 2, 5, 0, 7, 4, 1 };
    }

    // 2. Check how many birds visited today
    public int Today()
    {
        return birdsPerDay[^-1];
    }

    // 3. Increment today's count
    public void IncrementTodaysCount()
    {
        return birdsPerDay[^-1]++;
    }

    // 4. Check if there was a day with no visiting birds
    public bool HasDayWithoutBirds()
    {
        
    }

    // 5. Calculate the number of visiting birds for the first number of days
    public int CountForFirstDays(int numberOfDays)
    {
        
    }

    // 6. Calculate the number of busy days
    public int BusyDays()
    {
        
    }
}