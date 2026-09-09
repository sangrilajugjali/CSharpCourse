using System;
class array3
{
    public void display()
    {
        Console.Write("Enter how many element you want to store : ");
        int size = int.Parse(Console.ReadLine());

         decimal [] arrayDecimal = new decimal[size];

         Console.WriteLine("Enter the element of arrays : ");

         for (int i = 0; i < arrayDecimal.Length; i++)
        {
            Console.Write($"Enter elements {i + 1}: ");
            arrayDecimal[i]= Console.ReadLine();
        }
        Console.WriteLine("\nArray elements are :");

        foreach (decimal element in arrayDecimal)
        {
            Console.WriteLine(element);
        }

    }
}