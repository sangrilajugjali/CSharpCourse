//Write a c# program to store numbers in jagged array.Array should be of 1D


using System;
class JaggedArray
{
    public void JaggedArrayOneD()
    {
        int [][] array = new int[2][];
        array [0] = new int[] {1 , 2 , 3 };
        array [1] = new int [] {3,5,6};
        
        {
            for (int i = 0 ; i < array.Length; i ++)
            {
                for (int j = 0 ; j < array[i].Length; j ++)
            
                {
                    Console.Write(array [i][j] + "" );
                }
            Console.WriteLine();
            
            
        }
    
        }
    }
}