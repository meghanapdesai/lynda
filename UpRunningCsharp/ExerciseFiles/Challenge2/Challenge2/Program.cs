using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum2Ints(23,24);
        }

        static void Sum2Ints(int one, int two) {
            int sum = one + two;
            Console.WriteLine(sum);
        }
    }
}
