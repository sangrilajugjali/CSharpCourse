//Write a c# program to store numbers in jagged array.Array should be of 2D

using System;
class JaggedArray2
{
    public void JaggedArrayTwoD()
    {
        int [][,] jaggedOf2D=new int[][,]
        {
            new int[,]
            {
                {1,2,3},{7,4,9}
            },
           new int[,]
           {
               {2,3,4},{5,6,7}
           }
        };
        for ( int i = 0 ;i < jaggedOf2D.Length; i++)
        {
            for (int j = 0; j < jaggedOf2D[i].GetLength(0); j++)
            {
                for (int k = 0; k < jaggedOf2D[i].GetLength(1); k++)
                {
                    Console.Write($"{jaggedOf2D [i][j,k] + ""}");
                }
            }
            Console.WriteLine();
        }


    }
    
}