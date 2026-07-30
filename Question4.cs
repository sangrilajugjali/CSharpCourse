// Declare three variables for Physics, Chemistry, and Mathematics marks, then calculate the total.

using System;

class Question4
{
    public void Marks()
    {
        int physics = 30;
        int chemistry = 40;
        int mathematics = 30;
        int totalmark =physics+chemistry+mathematics;
        Console.WriteLine($"The sum of marks is:{totalmark}");
    }
}