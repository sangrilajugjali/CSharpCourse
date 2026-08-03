// Input two integers and display the larger one.

using System;
class Question7
{
    public void Larger()
    {
        int a;
        Console.WriteLine("Enter a number");
        a=Convert.ToInt32(Console.ReadLine());

        int b;
        b=Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"{a} is larger than {b}");
        }
        else if (a < b)
        {
            Console.WriteLine($"{a} is smaller than {b} ");
        }

        
        

    }
}