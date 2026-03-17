using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction F1 = new Fraction();
        Fraction F2 = new Fraction(5);
        Fraction F3 = new Fraction(3, 4);

        Console.WriteLine(F1.GetFractionString());
        Console.WriteLine(F2.GetFractionString());
        Console.WriteLine(F3.GetFractionString());

        F1.SetTop(1);
        F1.SetBottom(3);

        Console.WriteLine(F1.GetTop());
        Console.WriteLine(F1.GetBottom());
        Console.WriteLine(F1.GetFractionString());
        Console.WriteLine(F1.GetDecimalValue());
    }
}