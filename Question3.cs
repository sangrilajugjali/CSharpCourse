// Store the dimensions of a room and calculate its volume.


using System;
class Question3
{
    public void Room()
    {
        int length = 5;
        int breath = 10;
        int height = 15;
        int volume;
        volume=length*breath*height;
        Console.WriteLine($"The volume of room is:{volume}");
    }
}