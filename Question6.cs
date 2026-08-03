// Write a C# program that checks whether a given integer is even or odd.

using System;

class Question6
{
    public void EvenOdd()
    {
        int num;
        Console.WriteLine("Enter a number");
         num=Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} is even");
        }
        else
        {
             Console.WriteLine($"{num} is odd" );
        }
    }
        
        
}