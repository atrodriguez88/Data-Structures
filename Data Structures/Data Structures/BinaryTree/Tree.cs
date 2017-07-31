using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.BinaryTree
{
    public class Tree
    {
        Node top;
        public Tree()
        {
            top = null;
        }
        public Tree(int d)
        {
            top = new Node(d);
        }
        public void Add(int d)
        {
            //No Recursive
            if (top == null)
            {
                //Add item as the base node
                Node node = new Node(d);
                top = node;
                return;
            }
            Node currentNode = top;
            bool added = false;
            do
            {
                //traverse tree
                if (d < currentNode.data)
                {
                    //go left
                    if (currentNode.left == null)
                    {
                        //Add the item
                        Node newNode = new Node(d);
                        currentNode.left = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                if (d >= currentNode.data)
                {
                    //go right
                    if (currentNode.right == null)
                    {
                        //Add the item
                        Node newNode = new Node(d);
                        currentNode.right = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            } while (!added);
        }
        public void AddRecursive(int d)
        {
            // Recursive
            //Public interface for the recuirsive definition of Add ... called to start the recursion at the top of the tree
            AddRecursive(ref top, d);
        }
        private void AddRecursive(ref Node N, int d)
        {
            // Recursive version for Add
            if (N == null)
            {
                //Node doesn't exist add it here
                Node newNode = new Node(d);
                N = newNode; // Set the old Node reference to the newly created node this attaching it the tree
                return;
            }
            if (d < N.data)
            {
                AddRecursive(ref N.left, d);
                return;
            }
            if (d >= N.data)
            {
                AddRecursive(ref N.right, d);
                return;
            }

        }
        public void Print(Node N, ref string s)
        {
            //write out the tree in sorted order to the string newstring
            // implement using recursive
            if (N == null) { N = top; }
            if (N.left != null)
            {
                Print(N.left, ref s);
                s = s + N.data.ToString().PadLeft(3);
                Console.WriteLine(s);
            }
            else
            {
                s = s + N.data.ToString().PadLeft(3);
            }
            if (N.right != null)
            {
                Print(N.right, ref s);
                Console.WriteLine(s);
            }
        }
    }
}
