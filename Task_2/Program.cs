﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать класс, представляющий учебный класс ClassRoom.
    Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
    Write(), void Relax().
    Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса
    Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
    Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
    Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
    Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,
    писать, отдыхать.
*/


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new BadPupil();
            Pupil pupil2 = new GoodPupil();

            ClassRoom class1A = new ClassRoom(pupil1, pupil2);

            class1A.Read();
            Console.WriteLine(new string('*', 30));

            class1A.Stady();
            Console.WriteLine(new string('*', 30));

            class1A.Write();
            Console.WriteLine(new string('*', 30));

            class1A.Relax();
            Console.WriteLine(new string('*', 30));

            Console.ReadKey();
        }
    }
}
