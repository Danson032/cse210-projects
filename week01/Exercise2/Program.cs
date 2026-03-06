using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your marks: ");
        string marks= Console.ReadLine();
        int mark= int.Parse(marks);
        if (mark >= 90)
        {
            Console.WriteLine("Grade is A");
        }
        else if (mark >= 80)
        {
            Console.WriteLine("Grade is B");
        }
        else if (mark >= 70)
        {
            Console.WriteLine("Grade is C");
        }
        else if (mark >= 60)
        {
            Console.WriteLine("Grade is D");
        }
        else 
        {
            Console.WriteLine("Grade is E");
        }    
    }
}