using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class ClassRoom
    {
        Pupil[] classRoom = new Pupil[4];
        Random rand = new Random();

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            classRoom[0] = pupil1;
            classRoom[1] = pupil2;
            classRoom[2] = this.RandomPupil();
            classRoom[3] = this.RandomPupil();
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            classRoom[0] = pupil1;
            classRoom[1] = pupil2;
            classRoom[2] = pupil3;
            classRoom[3] = this.RandomPupil();
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            classRoom[0] = pupil1;
            classRoom[1] = pupil2;
            classRoom[2] = pupil3;
            classRoom[3] = pupil4;
        }


        private Pupil RandomPupil()
        {
            Pupil tmp = new BadPupil();
            switch (rand.Next(1, 4))
            {
                case 1: tmp = new GoodPupil(); break;
                case 2: tmp = new ExcelentPupil(); break;
                case 3: tmp = new BadPupil(); break;
            }
            return tmp;
        }

        public void Stady()
        {
            foreach (Pupil currentPupel in classRoom)
            {
                currentPupel.Study();
            }
        }

        public void Read()
        {
            foreach (Pupil currentPupel in classRoom)
            {
                currentPupel.Read();
            }
        }

        public void Write()
        {
            foreach (Pupil currentPupel in classRoom)
            {
                currentPupel.Write();
            }
        }

        public void Relax()
        {
            foreach (Pupil currentPupel in classRoom)
            {
                currentPupel.Relax();
            }
        }
    }
}
