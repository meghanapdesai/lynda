using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("a string");
            myStack.Push(23);
            myStack.Push(myStack);

            myStack.Pop();

            //new Stack that holds strings ONLY
            Stack<string> strStack = new Stack<string>();
            strStack.Push("a string");
        }
    }
}
