using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you helped someone.",
        "Think of a time when you did something difficult.",
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful to you?",
        "What did you learn?",
        "How did you feel when it was complete?",
        "What made this different?",
        "How can you use this again?"
    };

    public ReflectionActivity() : base(
        "Reflection Activity",
        "This activity helps you reflect on meaningful experiences.")
    { }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();

        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("Think about it...");
        ShowSpinner(4);

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.WriteLine("\n" + _questions[rand.Next(_questions.Count)]);
            ShowSpinner(4);
            elapsed += 4;
        }

        EndMessage();
    }
}