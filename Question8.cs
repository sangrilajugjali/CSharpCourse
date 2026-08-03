// Write a program to find the smaller of two numbers.

using System;
class Question8
{
    public void Smaller()
    {
        int a;
        Console.WriteLine("Enter a number");
        a=Convert.ToInt32(Console.ReadLine());

        int b;
        b=Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"{b} is smaller than {a}");
        }
        else if (a < b)
        {
            Console.WriteLine($"{a} is smaller than {b}");
        }
    }
}