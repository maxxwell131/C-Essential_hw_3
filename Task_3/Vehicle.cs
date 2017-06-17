using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Vehicle
    {
        //В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
        //выпуска).
        readonly int xLocation;
        readonly int yLocation;
        readonly uint speed;
        readonly decimal price;
        readonly string releaseData;

        public int Xlocation
        {
            get { return xLocation; }
        }

        public int Ylocation
        {
            get { return Ylocation; }
        }

        public uint Speed
        {
            get { return speed; }
        }

        public decimal Price
        {
            get { return price; }
        }

        public string ReleaseDate
        {
            get { return releaseData; }
        }

        public Vehicle(int xLocation, int yLocation, uint speed, decimal price, string releaseData)
        {
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            this.speed = speed;
            this.price = price;
            this.releaseData = releaseData;
        }

        public Vehicle(uint speed, decimal price, string releaseData) : this(0, 0, speed, price,  releaseData)
        {

        }

    }
}
