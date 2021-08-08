using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOrderLevelOrderBinaryTree
{
    class LevelOrder
    {
        public Stack<int> PostOrder(Node root)
        {
            Stack<Node> S1 = new Stack<Node>();
            Stack<int> S2 = new Stack<int>();

            S1.Push(root);

            while (S1.Count != 0)
            {
                root = S1.Pop();
                S2.Push(root.data);

                if(root.left != null)
                    S1.Push(root.left); 

                if (root.right != null)
                    S1.Push(root.right);
            }

            return S2;
        }
    }
}
