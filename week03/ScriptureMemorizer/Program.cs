/* I have added a difficulty option to the program so the user can choose how many words
 get hidden each time they press Enter. This lets the user control how fast the
 scripture becomes hidden, making the program more flexible for the
 different levels of memorization.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose difficulty: easy / medium / hard");
        string difficulty = Console.ReadLine().ToLower();

        int wordsToHide = 3;

        if (difficulty == "easy")
        {
            wordsToHide = 1;
        }
        else if (difficulty == "hard")
        {
            wordsToHide = 5;
        }


        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {

                break;
            }

            Console.WriteLine("\nPress ENTER to continue or type 'quit'");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(wordsToHide);
        }
    }
}