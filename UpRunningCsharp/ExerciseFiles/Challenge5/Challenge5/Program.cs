using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string,string> mySortList = new SortedList<string, string>();

            mySortList.Add("first", "String1");
            mySortList.Add("second", "newString");
            mySortList.Add("third", "Riddhi");
        }
    }
}
