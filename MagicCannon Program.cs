using System;

class Program
{
    static void Main()
    {
        int totalTurns = 100;

        for (int turn = 0; turn < totalTurns; turn++)
        {
            if (turn % 3 == 0 && turn % 5 == 0)
            {
                Console.WriteLine("Shot "+ turn + " is Fire + Electric!");
            }
            else if (turn % 3 == 0)
            {
                Console.WriteLine("Shot "+turn + " is fire!");
            }
            else
            {
                Console.WriteLine("Shot " + turn + "is Nothing");
            }
        }
    }
    }
