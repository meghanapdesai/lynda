using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non-generic Collections
            ArrayList arrList = new ArrayList();

            arrList.Add(24);
            arrList.Add("a string");

            Stack myStack = new Stack(); // LIFO
            myStack.Push(25);
            myStack.Push("a new string");
            myStack.Peek();
            myStack.Pop();

            Queue myQueue = new Queue(); // FIFO
            myQueue.Enqueue(28);
            myQueue.Dequeue();

            SortedList srtList = new SortedList();
            srtList.Add(25);
            srtList.Add(1);
            srtList.Add(3,266);

            // Generic Collections
            Stack<int> intStack = new Stack<int>();
            Queue<char> charQ = new Queue<char>();
            SortedList<string, string> strList = new SortedList<string, string>();

        }
    }
}
