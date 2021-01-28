using System;
using System.Collections.Generic;
using System.Text;

namespace Ex.Polymorphism
{
    class Lamborghini:Car
    {
        public string model { get; set; }
        private string brand = "Lamborghini";

        public Lamborghini(int km, string color, string model) : base(km, color)
        {
            this.model = model;
        }

        public override void Details()
        {
            Console.WriteLine("This car is a {0} {1} {2} and has {3} km", this.color, this.brand, this.model, this.km);
        }

        public override void Repair()
        {
            Console.WriteLine("The {0} {1} {2} was repaired", this.color, this.brand, this.model);
        }
    }
}
