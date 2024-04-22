using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class ExpressionTree
    {
        public TreeNode Root { get; set; }

        public ExpressionTree(TreeNode root)
        {
            Root = root;
        }

        private void PreorderTraversal(TreeNode node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " ");
                PreorderTraversal(node.Left);
                PreorderTraversal(node.Right);
            }
        }

        public void PreorderTraversal()
        {
            PreorderTraversal(Root);
        }
    }
}
