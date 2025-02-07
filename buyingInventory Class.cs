using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buying_inventory
{
    internal class Shop
    {
        private int choice = 0;
        private string name = "Null";

        public int Choice
        {
            get { return choice; }
            set { choice = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int getPrice()
        {
            int price;
            price = choice switch
            {
                0 => -999999,
                1 => 10,
                2 => 16,
                3 => 24,
                4 => 2,
                5 => 20,
                6 => 200,
                7 => 2

            };
            if (Name == "William")
            {
                Console.WriteLine("test");
                price = price / 2;
            }
            return price;
        }

    }

    }