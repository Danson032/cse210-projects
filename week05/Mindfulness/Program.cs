using System;


// - Added spinner animation using backspaces
// - Added a session counter to track completed activities

class Program
{
    static int _activityCount = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
                _activityCount++;
            }
            else if (choice == "2")
            {
                new ReflectionActivity().Run();
                _activityCount++;
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
                _activityCount++;
            }
            else if (choice == "4")
            {
                Console.WriteLine($"You completed {_activityCount} activities. Goodbye!");
                break;
            }
        }
    }
}