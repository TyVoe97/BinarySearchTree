using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void add(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                bool loop = true;
                while (loop)
                {
                    parent = current;
                    if (data < current.Data)
                    {
                        if(current.left == null)
                        {
                            current.left = newNode;
                        }
                        if(current.left == newNode)
                        {
                            loop = false;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                        if(current.right == newNode)
                        {
                            loop = false;
                        }
                         
                    }
                }
            }
        }
    }
}
