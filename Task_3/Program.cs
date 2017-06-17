using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать класс Vehicle.
    В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
    выпуска).
    Создайте 3 производных класса Plane, Саг и Ship.
    Для класса Plane должна быть определена высота и количество пассажиров.
    Для класса Ship — количество пассажиров и порт приписки.
    Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
*/

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car();
            Plane plane = new Plane(850, 1000000, "12/10/2016");

            plane.NumberOfPassengers = 6;
            plane.Height = 5000;

            Console.WriteLine("Скорость {0}\n стоимость {1}\n дата выпуска {2}\n высота полета {3}\n кол-во пассаж. {4}\n кол-во колес {5}\n",
                plane.Speed, plane.Price, plane.ReleaseDate,plane.Height, plane.NumberOfPassengers, plane.Tires.Length);
            Console.ReadKey();
        }
    }
}
