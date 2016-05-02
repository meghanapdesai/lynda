using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 32;
            object objValue = intValue;
            string strValue;

            // Do a try-catch to catch any errors
            try
            {
                strValue = (string)objValue;
                Console.WriteLine("This is the string: " + strValue);
            }
            catch (InvalidCastException icException)
            {
                Console.WriteLine(icException.Message);
            }
        }
    }
}