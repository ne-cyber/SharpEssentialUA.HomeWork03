using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {


        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно: Створити клас, який представляє навчальний клас ClassRoom.
        // Створіть клас учень Pupil. У тілі класу створіть методи void Study(), void Read(), void Write(), void Relax().
        // Створіть 3 похідні класу ExcelentPupil, GoodPupil, BadPupil від класу базового класу Pupil
        // і перевизначте кожен із методів, залежно від успішності учня.
        // Конструктор класу ClassRoom приймає аргументи типу Pupil, клас має складатися із 4 учнів.
        // Передбачте можливість, що користувач може передати 2 або 3 аргументи.
        // Виведіть інформацію про те, як усі учні екземпляра класу ClassRoom вміють вчитися, читати, писати, відпочивати.



        class Pupil
        {
            public virtual void Study()
            {
                Console.WriteLine("Учень вчиться");
            }

            public virtual void Read()
            {
                Console.WriteLine("Учень читає");
            }
            public virtual void Write()
            {
                Console.WriteLine("Учень пише");
            }
            public virtual void Relax()
            {
                Console.WriteLine("Учень відпочиває");
            }
        }



        class ExelentPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("Учень вчиться на відмінно!");
            }
            public override void Read()
            {
                Console.WriteLine("Ученб читає на відмінно!");
            }
            public override void Write()
            {
                Console.WriteLine("Учень пише відмінно!");
            }
            public override void Relax()
            {
                Console.WriteLine("Учень відпочиває мало :)");
            }
        }
        class GoodPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("Учень вчиться добре.");
            }
            public override void Read()
            {
                Console.WriteLine("Учень читає добре.");
            }
            public override void Write()
            {
                Console.WriteLine("Учень пише добре.");
            }
            public override void Relax()
            {
                Console.WriteLine("Учень віпочиває достатньо.");
            }
        }
        class BadPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("Учень вчиться погано :(");
            }
            public override void Read()
            {
                Console.WriteLine("Учень читає погано :(");
            }
            public override void Write()
            {
                Console.WriteLine("Учень пише погано :(");
            }
            public override void Relax()
            {
                Console.WriteLine("Учень постійно відпочиває!");
            }
        }



        class ClassRoom
        {
            Pupil[] pupiles;

            public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
            {
                pupiles = new Pupil[4] { p1, p2, p3, p4 };
            }

            public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
            {
                pupiles = new Pupil[3] { p1, p2, p3 };
            }

            public ClassRoom(Pupil p1, Pupil p2)
            {
                pupiles = new Pupil[2] { p1, p2 };
            }



            public void ClassRoomStudy()
            {
                foreach (Pupil p in pupiles)
                {
                    p.Study();
                }
            }

            public void ClassRoomRead()
            {
                foreach (Pupil p in pupiles)
                {
                    p.Read();
                }
            }

            public void ClassRoomWrite()
            {
                foreach (Pupil p in pupiles)
                {
                    p.Write();
                }
            }

            public void ClassRoomRelax()
            {
                foreach (Pupil p in pupiles)
                {
                    p.Relax();
                }
            }


        }



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            ClassRoom classRoom = new ClassRoom(new ExelentPupil(), new GoodPupil(), new BadPupil());
            classRoom.ClassRoomStudy();

            Console.WriteLine(new string('-', 30));

            classRoom.ClassRoomRead();

            Console.WriteLine(new string('-', 30));

            classRoom.ClassRoomWrite();

            Console.WriteLine(new string('-', 30));

            classRoom.ClassRoomRelax();

            Console.ReadKey();
        }
    }
}