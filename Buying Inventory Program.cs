using System;
using buying_inventory;

class Program
{
    static void Main()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        string name = Console.ReadLine();
        Shop choice2 = new Shop();
        choice2.Choice = choice;
        choice2.Name = name;
        Console.WriteLine(choice2.getPrice());

    }
}
