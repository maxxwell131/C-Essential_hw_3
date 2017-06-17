using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Plane : Vehicle
    {
        Tire[] tires = new Tire[3];
        uint height;
        uint numberOfPassengers;

        public Plane(uint speed, decimal price, string releaseData) : base(speed, price, releaseData)
        {
            SetTires();
        }

        public Plane(int xLocation, int yLocation, uint speed, decimal price, string releaseData) : base(xLocation, yLocation, speed, price, releaseData)
        {
            SetTires();
        }

        void SetTires()
        {
            tires[0] = new Tire("FL");
            tires[0] = new Tire("RL");
            tires[0] = new Tire("LF");
            tires[0] = new Tire("LR");
        }

        public uint Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value != 0)
                {
                    height = value;
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

        public Tire[] Tires => tires;
    }
}
