using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    class LaserPrinter : Printer
    {
        ConsoleColor backgroundColor;

        public LaserPrinter(ConsoleColor backgroundColor, ConsoleColor color) : base(color)
        {
            this.backgroundColor = backgroundColor;
        }

        public override void Print(string value)
        {
            Console.BackgroundColor = backgroundColor;
            base.Print(value);
        }
    }
}
