using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Ship : Vehicle
    {
        string homePort;
        uint numberOfPassengers;

        public Ship(uint speed, decimal price, string releaseData) : base(speed, price, releaseData)
        {
        }

        public Ship(int xLocation, int yLocation, uint speed, decimal price, string releaseData) : base(xLocation, yLocation, speed, price, releaseData)
        {
        }

        public string HomePort
        {
            get
            {
                return homePort;
            }

            set
            {
                if (value != "")
                {
                    homePort = value;
                }
            }
        }

        public uint NumberOfPassengers
        {
            get
            {
                return numberOfPassengers;
            }

            set
            {
                if (value != 0)
                {
                    numberOfPassengers = value;
                }
            }
        }
    }
}
