using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new();
        // The API used to communicate with the object
        Cycling cycling = new();
        cycling.setDistance(50.0);
        cycling.setDate("04-April-2023");
        cycling.setTime(23);
        
        Running running = new();
        running.setLength(100);
        running.setDate("11-April-2023");
        running.setTime(0.12);

        Swimming swimming = new();
        swimming.setLap(5);
        swimming.setSpeed(2.5);
        swimming.setDate("06-April-2023");
        swimming.setTime(10);

        activities.Add(cycling);
        activities.Add(running);
        activities.Add(swimming);

        foreach (var sport in activities)
        {
            Console.WriteLine(sport.GetSummary());
        }
    }
}