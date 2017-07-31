using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.LinkedList
{
    public class Node
    {
        Node next;
        int data;

        public Node Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }

        public int Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
        public void AddToEnd(int d)
        {
            if (next == null)
            {
                next = new Node(d);
            }
            else
            {
                next.AddToEnd(d);
            }
        }
        public void AddSort(int d)
        {
            if (next == null)
            {
                next = new Node(d);
            }
            else if (d < next.data)
            {
                Node temp = new Node(d);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSort(d);
            }
        }
        public void Print()
        {
            Console.Write("|" + data + "->");
            if (next != null)
            {
                next.Print();
            }
        }
    }
}
