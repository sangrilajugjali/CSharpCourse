// Input age and determine whether a person is eligible to vote (18 or above).


using System;
class Question9
{
    public void Age()
    {
        int age;
        Console.WriteLine("Enter a age");
        age=Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine($"Eligible to vote");
        }
        else
        {
            Console.WriteLine($"Not eligible to vote");
        }
    }
}