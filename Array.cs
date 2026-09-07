//Write a progam in c# to store number in 1d array from user and display their elements.

using System;
class Array
{
    public void Elements()
    {
        int []num=new int[3];
        Console.WriteLine("Enter a number");
        for(int i= 0; i <3; i++)
        {
            Console.WriteLine($"num[{i}]");
            num[i]=Convert.ToInt32(Console.ReadLine());
        }
    }
}