using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Pupil
    {
        virtual public void Study()
        {
            Console.WriteLine("Pupil Stady");
        }

        virtual public void Read()
        {
            Console.WriteLine("Pupil Read");
        }

        virtual public void Write()
        {
            Console.WriteLine("Pupil Write");
        }

        virtual public void Relax()
        {
            Console.WriteLine("Pupil Relax");
        }
    }
}
