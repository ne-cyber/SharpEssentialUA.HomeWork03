using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {



        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно: Створити клас Printer.
        // У тілі класу створіть метод void Print(string value), що виводить на екран значення аргументу.
        // Реалізуйте можливість того, щоб у разі успадкування від даного класу інших класів,
        // та виклику відповідного методу їх екземпляра, рядки, передані як аргументи методів,
        // виводилися різними кольорами. Обов'язково використовуйте типи.


        class Printer
        {
            public void Print(string value)
            {                
                Console.WriteLine(value);
            }
        }




        class ColorPrinter : Printer
        {
            public ConsoleColor color = ConsoleColor.Green;
            public new void Print(string value)
            {
                Console.ForegroundColor = color;
                base.Print(value);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Printer printer = new Printer();
            printer.Print("базовий принтер");
            Console.WriteLine(new string('-', 30));

            ColorPrinter colorPrinter = new ColorPrinter();
            colorPrinter.Print("кольоровий принтер");
            Console.WriteLine(new string('-', 30));

            (colorPrinter as Printer).Print("--данні--");

            Console.ReadKey();
        }
    }
}
