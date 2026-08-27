// Print a Multiplication Table**
// Create a function `MultiplicationTable()` with **no arguments and no return type**.

// The function should print the multiplication table of `5` from `1` to `10`.

using System;
class FunctionQuestion2
{
    public void MultiplicationTable()
    {
        for(int b = 1 ; b <= 10; b ++ )
        {
            int multiple = 5 * b ;
            Console.WriteLine($" 5 * {b} = {multiple} ");

        }
        
        
    }
}