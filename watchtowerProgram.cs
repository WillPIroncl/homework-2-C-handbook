using System;
using System.Collections;
using System.Collections.Generic;

namespace Watchtower
{
    class Program()
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter an X coordinate: ");
            string userXInput = Console.ReadLine();

            if (int.TryParse(userXInput, out int userX))
            {
                Console.WriteLine($"You entered: {userX}");
                userX = 0;
            }
            else
            {
                Console.WriteLine("That's not a valid integer. Please try again");
            }
            Console.Write("Please enter an Y coordinate: ");
            string userYInput = Console.ReadLine();

            if (int.TryParse(userYInput, out int userY))
            {
                Console.WriteLine($"You entered: {userY}");
            }
            else
            {
                Console.WriteLine("That's not a valid integer. Please try again");
                userY = 0;
                
            }
            WatchtowerClass WatchTowerObject = new WatchtowerClass();
            WatchTowerObject.XValue = userX;
            WatchTowerObject.YValue = userY;
            Console.WriteLine(WatchTowerObject.GetDirection());
        }
    }
}