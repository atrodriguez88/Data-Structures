using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class LinkedList
    {
        Node headNode;
        public LinkedList()
        {
            headNode = null;
        }
        public void AddToEnd(int d)
        {
            if (headNode == null)
            {
                headNode = new Node(d);
            }
            else
            {
                headNode.AddToEnd(d);
            }
        }
        public void AddToBegin(int d)
        {
            if (headNode == null)
            {
                headNode = new Node(d);
            }
            else
            {
                Node temp = new Node(d);
                temp.Next = headNode;
                headNode = temp;
            }
        }
        public void AddSort(int d)
        {
            if (headNode == null)
            {
                headNode = new Node(d);
            }
            else if(d < headNode.Data)
            {
                AddToBegin(d);
            }
            else
            {
                headNode.AddSort(d);
            }
        }
        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }
    }
}
