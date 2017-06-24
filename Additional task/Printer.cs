using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    class Printer
    {
        private ConsoleColor prninterColor;

        public Printer(ConsoleColor color)
        {
            this.prninterColor = color;
        }

        public virtual void Print(string value)
        {
            Console.ForegroundColor = this.prninterColor;
            Console.WriteLine("Print base class - {0}", value);
            Console.ResetColor();
        }
    }
}
