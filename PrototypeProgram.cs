using System;
using The_Prototype;

class Program
{
    static void Main()
    {
        int pilotguess = Convert.ToInt32(Console.ReadLine());
        int hunterguess = Convert.ToInt32(Console.ReadLine());

        Prototype aProtoType = new Prototype();
        aProtoType.ChosenNumber = pilotguess;
        aProtoType.ChosenNumber2 = hunterguess;
        aProtoType.PlayGame();
    }
}
