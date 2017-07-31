using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures.BinaryTree;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Data_Structures.LinkedList.LinkedList list = new LinkedList.LinkedList();

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

            Tree tree = new Tree();
            tree.Add(9);
            tree.Add(2);
            tree.Add(4);
            tree.Add(8);
            tree.Add(1);
            tree.Add(20);
            tree.Add(12);
            tree.Add(11);


            string s = "";
            tree.Print(null,ref s);

            Console.Read();
        }
    }
}
