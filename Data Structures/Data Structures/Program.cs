using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            //list.AddToEnd(5);
            //list.AddToEnd(9);
            //list.AddToEnd(2);
            //list.AddToEnd(13);
            //list.AddToEnd(1);

            //list.AddToBegin(500);
            //list.AddToBegin(9);
            //list.AddToBegin(2);
            //list.AddToBegin(13);
            //list.AddToBegin(1);

            list.AddSort(5);
            list.AddSort(9);
            list.AddSort(2);
            list.AddSort(13);
            list.AddSort(1);

            list.Print();

            Console.Read();
        }
    }
}
