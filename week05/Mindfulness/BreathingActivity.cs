using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by guiding your breathing.")
    { }

    public void Run()
    {
        StartMessage();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(3);

            Console.Write("\nBreathe out... ");
            ShowCountdown(3);

            elapsed += 6;
        }

        EndMessage();
    }
}