using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Color = "silver";
            car1.Make = "Toyota";
            car1.Model = "Camry";

            car1.Driving();
            car1.Stopping();
        }
    }
}
