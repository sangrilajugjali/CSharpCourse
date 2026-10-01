using System;
class Array4
{
    public void TwoDA()
    {
        Console.WriteLine("Enter a row :");
        int row = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter a coloum: ");
        int coloum = int.Parse(Console.ReadLine()!);
        int [,] TwoArray = new int [row,coloum];
        for ( int i = 0; i<TwoArray.GetLength(0); i++)
        {
            for (int j = 1 ; j < TwoArray.GetLength(1); j++)
            {
                Console.Write($"Enter element {i + 1}");
                
                
            }
        }
    }

}