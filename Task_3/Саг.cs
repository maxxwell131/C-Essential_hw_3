using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Саг : Vehicle
    {
        Tire[] tires = new Tire[4];

        public Саг(uint speed, decimal price, string releaseData) : base(speed, price, releaseData)
        {
            SetTires();
        }

        public Саг(int xLocation, int yLocation, uint speed, decimal price, string releaseData) : base(xLocation, yLocation, speed, price, releaseData)
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

        public Tire[] Tires => tires;
    }
}
