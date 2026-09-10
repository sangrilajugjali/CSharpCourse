using System;
class Array3
{
    public void display()
    {
        Console.Write("Enter how many element you want to store : ");
        int size = int.Parse(Console.ReadLine());

         double[] arrayDouble = new double [size];

         Console.WriteLine("Enter the element of arrays : ");

         for (int i = 0; i < arrayDouble.Length; i++)
        {
            Console.Write($"Enter elements {i + 1}: ");
            arrayDouble[i]=double.Parse( Console.ReadLine());
        }
        Console.WriteLine("\nArray elements are :");

        foreach (double element in arrayDouble)
        {
            Console.WriteLine(element);
        }

    }
}