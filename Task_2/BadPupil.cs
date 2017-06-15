using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil Stady");
        }

        public override void Read()
        {
            Console.WriteLine("BadPupil Read");
        }

        public override void Write()
        {
            Console.WriteLine("BadPupil Write");
        }

        public override void Relax()
        {
            Console.WriteLine("BadPupil Relax");
        }
    }
}
