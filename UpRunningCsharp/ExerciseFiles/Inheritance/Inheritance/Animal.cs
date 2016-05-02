using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        private string type;
        private string color;
        private string weight;
        private string height;
        private int age;
        private int numOfLegs;

        public int Age {
            get;
            set {
                if (value < 0){
                    Console.WriteLine("Age cannot be less than 0");
                }
                else { this.age = value; }
            }
        }

        public string Color { get; set; }

        public void move(){
            Console.WriteLine("Moved");
        }

        public void makeNoise(){

        }
    }
}
