using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Watchtower
{
    internal class WatchtowerClass
    {
        private int xValue = -999;

        private int yValue = -999;

        // gets and sets

        public int XValue
        {
            get { return xValue; }
            set { xValue = value; }
        }
        public int YValue
        {
            get { return yValue; }
            set { yValue = value; }
        }

        // methods

        public string GetDirection()
        {
            if (xValue == 0 && yValue == 0) 
            {
                return "The enemy is here!";
            }
            if (xValue < 0 && yValue > 0)
            {
                return "The enemy is to the NorthWest!";

            }
            if (xValue < 0 && yValue == 0) 
            {
                return "The enemy is to the West!";
            }
            if (xValue < 0 && yValue < 0)
            {
                return "The enemy is to the SouthWest!!";

            }
            if (xValue == 0 && yValue > 0)
            {
                return "The enemy is to the North!";

            }
            if (xValue == 0 && yValue < 0) 
            {
                return "The enemy is to the South!";
            }
            if (xValue > 0 && yValue > 0)
            {
                return "The enemy is to the NorthEast!";
            }
            if (xValue > 0 && yValue == 0)
            {
                return "The enemy is to the East!";
            }
            if (xValue > 0 && yValue < 0)
            {
                return "The enemy is to the SouthEast!";

            }

            return "Error";
        }
    }
}