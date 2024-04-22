namespace tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode a = new TreeNode('A');
            TreeNode b = new TreeNode('B');
            TreeNode c = new TreeNode('C');
            TreeNode d = new TreeNode('D');
            TreeNode e = new TreeNode('E');
            TreeNode f = new TreeNode('F');
            TreeNode g = new TreeNode('G');

            a.Left = b;
            a.Right = c;
            b.Left = d;
            b.Right = e;
            c.Left = f;
            c.Right = g;

            ExpressionTree tree = new ExpressionTree(a);

            Console.WriteLine("Preorder traversal:");
            tree.PreorderTraversal();
        }
    }
}
