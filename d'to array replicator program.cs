using System;

class Program
{
    static void Main()
    {
        int[] originalArray = new int[5]; 
        int[] copiedArray = new int[5]; 

        Console.WriteLine("Enter 5 numbers");
        for (int i = 0; i < originalArray.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            originalArray[i] = int.Parse(Console.ReadLine()); 
        }

      
        for (int i = 0; i < originalArray.Length; i++)
        {
            copiedArray[i] = originalArray[i];
        }

        Console.WriteLine("Original Array:");
        foreach (int num in originalArray)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("Copied Array:");
        foreach (int num in copiedArray)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("The Replicator of D’To works!");
    }
}
