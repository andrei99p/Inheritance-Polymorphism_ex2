using System;
using System.Collections.Generic;
using System.Text;

namespace Ex.Polymorphism
{
    class Porsche:Car
    {
        public string model { get; set; }
        private string brand = "Porsche";

        public Porsche(int km, string color, string model):base(km, color)
        {
            this.model = model;
        }

        public new void Details()
        {
            Console.WriteLine("This is the {0} {1}, it is {2} and has {3} km so far",this.brand,this.model, this.color, this.km);
        }

        public new void Repair()
        {
            Console.WriteLine("The {0} {1} {2} was repaired",this.color, this.brand, this.model);
        }
    }
}
