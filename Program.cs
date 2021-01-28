using System;
using System.Collections.Generic;

namespace Ex.Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var masini = new List<Car>
            {
                new Porsche(30000, "white", "911"),
                new Lamborghini(25555, "yellow", "Murcielago")
            };

            foreach(var a in masini)
            {
                a.Details();
            }

            Car car1 = new Porsche(11000, "red", "Spyder"); 
            car1.Repair();
            Porsche car2 = new Porsche(5000, "white", "711");
            car2.Repair();
            car2.Details();

            Car car3 = (Car)car2;
            car3.Repair();
            car3.Details();
            Console.ReadLine();
        }
    }
}
