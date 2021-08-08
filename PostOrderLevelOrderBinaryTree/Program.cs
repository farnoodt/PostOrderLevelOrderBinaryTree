using System;

namespace PostOrderLevelOrderBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(1);
            tree.left = new Node(-1);
            tree.right = new Node(11);
            tree.right.left = new Node(21);
            tree.right.right = new Node(6);
            tree.left.left = new Node(-2);
            tree.left.right = new Node(-3);
            tree.left.right.right = new Node(5);

            LevelOrder LO = new LevelOrder(); 

            Console.WriteLine(string.Join( " , " , LO.PostOrder(tree)));
            Console.ReadKey();
        }
    }
}
