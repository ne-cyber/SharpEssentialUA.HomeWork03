using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {



        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно: Створити клас Vehicle.
        // У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску).
        // Створіть 3 похідні класи Plane, Саг і Ship.
        // Для класу Plane має бути визначена висота та кількість пасажирів.
        // Для класу Ship – кількість пасажирів та порт приписки.
        // Написати програму, яка виводить на екран інформацію про кожен засіб пересування. 



        class Vehicle
        {
            protected int x, y;

            protected readonly double price;
            protected readonly double speed;
            protected readonly int productionYear;

            public virtual void PrintInfo()
            {
                Console.Write($"координати ({x},{y}), швидкість {speed}, рік випуску {productionYear} ");
            }



            protected Vehicle(int x, int y, double price, double speed, int productionYear)
            {
                this.x = x;
                this.y = y;

                this.price = price;
                this.speed = speed;
                this.productionYear = productionYear;
            }
        }

        class Plane : Vehicle
        {
            readonly double altitude;
            readonly int numberOfPassengers;

            public override void PrintInfo()
            {
                Console.Write("Літак ");
                base.PrintInfo();
                Console.WriteLine($"висота польоту літака {altitude}, кількість пасажирів літака {numberOfPassengers}");
            }



            public Plane(int x, int y, double price, double speed, int productionYear,
                         double altitude, int numberOfPassengers)
                : base(x, y, price, speed, productionYear)
            {
                this.altitude = altitude;
                this.numberOfPassengers = numberOfPassengers;
            }
        }

        class Car : Vehicle
        {
            public Car(int x, int y, double price, double speed, int productionYear)
                : base(x, y, price, speed, productionYear)
            {
            }

            public override void PrintInfo()
            {
                Console.Write("Машина ");
                base.PrintInfo();
                Console.WriteLine();
            }
        }

        class Ship : Vehicle
        {
            readonly int numberOfPassengers;
            readonly string homePort;

            public override void PrintInfo()
            {
                Console.Write("Корабель ");
                base.PrintInfo();
                Console.WriteLine($"кількість пасажирів судна {numberOfPassengers}, порт приписки судна {homePort}");
            }



            public Ship(int x, int y, double price, double speed, int productionYear,
                        int numberOfPassengers, string homePort)
                : base(x, y, price, speed, productionYear)
            {
                this.numberOfPassengers = numberOfPassengers;
                this.homePort = homePort;
            }
        }



        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            Car car = new Car(1, 1, 1000, 0.3, 1999);
            Plane plane = new Plane(10, 10, 100_000, 100, 2023, 10_000, 273);
            Ship ship = new Ship(200, 200, 2_000_000, 30, 2022, 980, "Одеса");


            Vehicle[] vehicle = new Vehicle[3] { car, plane, ship};
            foreach (Vehicle v in vehicle)
            {
                v.PrintInfo();
                Console.WriteLine(new string('-', 30));
            }

            Console.ReadKey();
        }
    }
}
