using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            CheckEvenOrOdd(number);
            CheckSign(number);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }

    static void CheckEvenOrOdd(int num)
    {
        if (num % 2 == 0)
            Console.WriteLine($"{num} is even.");
        else
            Console.WriteLine($"{num} is odd.");
    }

    static void CheckSign(int num)
    {
        if (num > 0)
            Console.WriteLine($"{num} is positive.");
        else if (num < 0)
            Console.WriteLine($"{num} is negative.");
        else
            Console.WriteLine("The number is zero.");
    }


}
