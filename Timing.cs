using System;
using System.Diagnostics;

public class Timing
{
    TimeSpan startingTime;
    TimeSpan duration;

    public Timing()
    {
        startingTime = new TimeSpan(0);
        duration = new TimeSpan(0);
    }

    public void StopTime()
    {
        Console.WriteLine("Timer Stopped!");
        Console.WriteLine("{0}", Process.GetCurrentProcess().Threads[0].UserProcessorTime);
        duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startingTime);
    }

    public void startTime()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine("Timer started!");
        startingTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
        Console.WriteLine("{0}", startingTime);
    }

    public TimeSpan Result()
    {
        //Console.WriteLine("duration is: ", )
        return duration;
    }
}

class TimingExcercise
{
    static void Main()
    {
        int[] nums = new int[10000];
        //BuildArray(nums);
        Timing tObj = new Timing();
        tObj.startTime();
        BuildArray(nums);
        tObj.StopTime();
        Console.WriteLine("time (.NET): {0}", tObj.Result().TotalSeconds);
    }

    static void BuildArray(int[] arr)
    {
        Console.WriteLine("in BuildArray");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
            //Console.WriteLine("got it");
        }

    }
}