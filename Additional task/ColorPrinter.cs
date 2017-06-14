using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    class ColorPrinter :Printer
    {
        ConsoleColor backgroundColor;
        int paintCount;

        public ColorPrinter (int paintCount, ConsoleColor backgroundColor, ConsoleColor color) :base(color)
        {
            this.paintCount = paintCount;
            this.backgroundColor = backgroundColor;
        }

        public override void Print(string value)
        {
            if (paintCount > 0)
            {
                Console.BackgroundColor = backgroundColor;
                base.Print(value);
                paintCount--;
            } else
            {
                Console.WriteLine("Ink tray is empty!!!");
            }           
        }
    }
}
