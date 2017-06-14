using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Задание
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создайте класс Printer.
    В теле класса создайте метод void Print(string value), который выводит на экран значение
    аргумента.
    Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
    соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
    выводились разными цветами.
    Обязательно используйте приведение типов. 
 */

namespace Additional_task
{
    class Program
    {
        static void Main(string[] args)
        {
            LaserPrinter laserPrinter = new LaserPrinter(ConsoleColor.White, ConsoleColor.Black);
            laserPrinter.Print("Hello laserPrinter");

            Printer printer = (laserPrinter as LaserPrinter);
            if (printer != null)
            {
                printer.Print("Hello printer");
            }

            Printer cp = new ColorPrinter(3,ConsoleColor.Red, ConsoleColor.Black);
            cp.Print("printer- color printer");

            ColorPrinter colorPrinter = new ColorPrinter(3, ConsoleColor.Yellow, ConsoleColor.DarkBlue);
            colorPrinter.Print("Hello Color printer");

            Console.ReadKey();
        }
    }
}
