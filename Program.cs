using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    public class Program
    {
        public static void Main(string[] pArguments)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Root         = new BinaryTree.Node("0003");
            binaryTree.Root.Left    = new BinaryTree.Node("0002");
            binaryTree.Root.Right   = new BinaryTree.Node("0004");

            binaryTree.Root.Right.Right = new BinaryTree.Node("0006");

            binaryTree.Root.Right.Right.Right   = new BinaryTree.Node("0010");
            binaryTree.Root.Right.Right.Left    = new BinaryTree.Node("0005");

            Program.PrintRightSide(binaryTree);
        }

        public static void PrintRightSide(BinaryTree binaryTree)
        {
            BinaryTree.Node node = binaryTree.Root;

            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Right;
            }
        }
    }

    public class BinaryTree
    {
        private Node m_root;

        public BinaryTree()
        {
        }

        public Node Root
        {
            get { return this.m_root; }
            set { this.m_root = value; }
        }

        public class Node
        {
            private Node    m_right;
            private Node    m_left;
            private string  m_data;

            public Node(string data)
            {
                this.m_data     = data;
                this.m_right    = null;
                this.m_left     = null;
            }

            public Node Right
            {
                get { return this.m_right; }
                set { this.m_right = value; }
            }

            public Node Left
            {
                get { return this.m_left; }
                set { this.m_left = value; }
            }

            public string Data
            {
                get { return this.m_data; }
                set { this.m_data = value; }
            }
        }
    }
}
