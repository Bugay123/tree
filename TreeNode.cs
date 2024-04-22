using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class TreeNode
    {
        public char Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(char value)
        {
            Value = value;
        }
    }
}
