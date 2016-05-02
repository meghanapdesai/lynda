using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Car
    {
        private string make;
        private string model;
        private string color;

        public string Make {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Color {
            get {return this.color; }
            set {this.color = value; }
        }

        public void Driving() { Console.WriteLine("Driving"); }
        public void Stopping() { Console.WriteLine("Stopping"); }
    }
}
