
using System;
class Array2
{
    public void User()
    {
        Console.Write("Enter how many elements you want to store :");
        int size = int.Parse(Console.ReadLine());

        string[] arrayString = new string[size];

        Console.WriteLine("Enter the element of arrays : ");
        
        for (int i = 0; i < arrayString.Length; i++)
        {
            Console.Write($"Enter elemnts {i + 1}:");
            arrayString[i] = Console.ReadLine();

        }
        Console.WriteLine("\nArray elements are :");

        foreach (string element in arrayString)
        {
            Console.WriteLine(element);
        }

    }
}