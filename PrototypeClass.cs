using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace The_Prototype
{
    internal class Prototype 
    {
        private int chosenNumber = -99;
        private int chosenNumber2 = -99;
        public int ChosenNumber
        {
            get { return chosenNumber; }
            set { this.chosenNumber = value; }
        }
        public int ChosenNumber2
        {
            get { return chosenNumber2; }
            set { this.chosenNumber2 = value; }
        }
        public void PlayGame()
        {
            bool playingGame = true;
            while (playingGame)
            {
                if (chosenNumber == chosenNumber2)
                {
                    playingGame = false;
                    Console.WriteLine("You won!");
                    return;
                }
                else
                {
                    Console.WriteLine("You lose! Input another guess.");
                    chosenNumber2 = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
