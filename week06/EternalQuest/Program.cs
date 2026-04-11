using System;
using System.Collections.Generic;
using System.IO;

// I have added a leveling system where the user levels up every 1000 points.
// I also added a title system (Beginner, Goal Warrior, Ninja Unicorn) to make the program more engaging.

class Program
{
    static void Main()
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        while (true)
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine($"Score: {score}");

            int level = score / 1000;
            Console.WriteLine($"Level: {level}");

            string title = "";
            if (level >= 10)
                title = "Ninja Unicorn";
            else if (level >= 5)
                title = "Goal Warrior";
            else
                title = "Beginner";

            Console.WriteLine($"Title: {title}");
            Console.WriteLine("-------------------------");

            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("1. Simple  2. Eternal  3. Checklist");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    goals.Add(new SimpleGoal(name, desc, points));
                }
                else if (type == "2")
                {
                    goals.Add(new EternalGoal(name, desc, points));
                }
                else if (type == "3")
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }
            else if (choice == "2")
            {
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetDisplayString()}");
                }
            }
            else if (choice == "3")
            {
                Console.Write("Which goal #: ");
                int index = int.Parse(Console.ReadLine()) - 1;

                int earned = goals[index].RecordEvent();
                score += earned;

                Console.WriteLine($"You earned {earned} points.");
            }
            else if (choice == "4")
            {
                using (StreamWriter writer = new StreamWriter("goals.txt"))
                {
                    writer.WriteLine(score);

                    foreach (Goal g in goals)
                    {
                        writer.WriteLine(g.GetStringRepresentation());
                    }
                }

                Console.WriteLine("Progress saved.");
            }
            else if (choice == "5")
            {
                string[] lines = File.ReadAllLines("goals.txt");

                score = int.Parse(lines[0]);
                goals.Clear();

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(":");
                    string type = parts[0];
                    string[] data = parts[1].Split(",");

                    if (type == "SimpleGoal")
                    {
                        goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
                    }
                    else if (type == "EternalGoal")
                    {
                        goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    }
                    else if (type == "ChecklistGoal")
                    {
                        goals.Add(new ChecklistGoal(
                            data[0],
                            data[1],
                            int.Parse(data[2]),
                            int.Parse(data[4]),
                            int.Parse(data[5])
                        ));
                    }
                }

                Console.WriteLine("Progress loaded.");
            }
            else if (choice == "6")
            {
                break;
            }
        }
    }
}