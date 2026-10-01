using System;
class Array5
{
    public void ThreeDA()
    {
        Console.Write("Enter a element  you want : ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a row");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a colume");
        int coloum = Convert.ToInt32(Console.ReadLine());

        int [,,] arrayInt = new int [size , row , coloum];

        Console.WriteLine("Enter a number");
        for(int i = 0; i < arrayInt.GetLength(0); i++)
        {
            
        }

        
    }
}