using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your marks: ");
        string marks = Console.ReadLine();
        int mark = int.Parse(marks);
        if (mark >= 90)
        {
            if (mark < 93)
            {
                Console.WriteLine("Grade is -A");
            }
            else
            {
                Console.WriteLine("Grade is A");
            }
        }
        else if (mark >= 80)
        {
            if (mark < 83)
            {
                Console.WriteLine("Grade is -B");
            }
            else if (mark > 87)
            {
                Console.WriteLine("Grade is +B");
            }
            else
            {
                Console.WriteLine("Grade is B");
            }
        }
        else if (mark >= 70)
        {
            if (mark < 73)
            {
                Console.WriteLine("Grade is -C");
            }
            else if (mark > 77)
            {
                Console.WriteLine("Grade is +C");
            }
            else
            {
                Console.WriteLine("Grade is C");
            }
        }
        else if (mark >= 60)
        {
            if (mark < 63)
            {
                Console.WriteLine("Grade is -D");
            }
            else if (mark > 67)
            {
                Console.WriteLine("Grade is +D");
            }
            else
            {
                Console.WriteLine("Grade is D");
            }
        }
        else
        {
            Console.WriteLine("Grade is E");
        }
    }
}