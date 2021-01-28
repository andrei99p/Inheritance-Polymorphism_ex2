using System;
using System.Collections.Generic;
using System.Text;

namespace Ex.Polymorphism
{
    class Car
    {
        public int km { get; set; }
        public string color { get; set; }

        public Car()
        { }
        public Car(int km, string color)
        {
            this.km = km;
            this.color = color;
        }

        public virtual void Details()
        {
            Console.WriteLine("This car is {0} and has {1} km",this.color, this.km);
        }

        public virtual void Repair()
        {
            Console.WriteLine("The car has been repaired");
        }
    }
}
