class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    // 1. Check what the counts were last week
    public int[] LastWeek()
    {
        if (birdsPerDay.Length <= 7)
        {
            return birdsPerDay;
        }
        return birdsPerDay[^7..];
    }

    // 2. Check how many birds visited today
    public int Today()
    {
        return birdsPerDay[^1]; // Último elemento
    }

    // 3. Increment today's count
    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
    }

    // 4. Check if there was a day with no visiting birds
    public bool HasDayWithoutBirds()
    {
        foreach (int cont in birdsPerDay)
        {
            if (cont == 0)
            {
                return true;
            }
        }
        return false;
    }

    // 5. Calculate the number of visiting birds for the first number of days
    public int CountForFirstDays(int numberOfDays)
    {
        int suma = 0;
        for (int i = 0; i < numberOfDays && i < birdsPerDay.Length; i++)
        {
            suma += birdsPerDay[i];
        }
        return suma;
    }

    // 6. Calculate the number of busy days
    public int BusyDays()
    {
        int busyDaysCount = 0;
        foreach (int cont in birdsPerDay)
        {
            if (cont >= 5)
            {
                busyDaysCount++;
            }
        }
        return busyDaysCount;
    }
}