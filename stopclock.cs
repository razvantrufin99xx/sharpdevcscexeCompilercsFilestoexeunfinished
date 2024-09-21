using System;
using System.Diagnostics;
using System.Windows.Forms;

public class TimerDiagnostic
{
    private static Timer timer;
    private static Stopwatch stopwatch;

    public static void Main()
    {
        // Initialize the timer and stopwatch
        timer = new Timer();
        stopwatch = new Stopwatch();

        // Set the timer interval (e.g., 1000 milliseconds = 1 second)
        timer.Interval = 1000;
        timer.Tick += Timer_Tick;

        // Start the stopwatch and timer
        stopwatch.Start();
        timer.Start();

        // Keep the application running to observe the timer ticks
        Application.Run();
    }

    private static void Timer_Tick(object sender, EventArgs e)
    {
        // Stop the stopwatch
        stopwatch.Stop();

        // Get the elapsed time
        TimeSpan elapsed = stopwatch.Elapsed;

        // Display the elapsed time
        Console.WriteLine("Elapsed time: {0:00}:{1:00}:{2:00}.{3:00}",
            elapsed.Hours, elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds / 10);

        // Restart the stopwatch for the next tick
        stopwatch.Restart();
    }
}