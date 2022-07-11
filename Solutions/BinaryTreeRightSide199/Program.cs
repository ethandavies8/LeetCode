using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeRightSide199
{
    class Program
    {
        //Leetcode problem: https://leetcode.com/problems/binary-tree-right-side-view/

        // Description:
        // Given the root of a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.


        // Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        #region recursiveSolution


        public IList<int> RecursiveRightSideView(TreeNode root)
        {
            List<int> list = new List<int>();
            recursiveHelper(root, list, 0);
            return list;

        }

        private static void recursiveHelper(TreeNode node, List<int> list, int depth)
        {
            if(node != null)
            {
                //if the size of the list is equal to the height of the node, we add the value (layer is over)
                if (depth == list.Count)
                    list.Add(node.val);

                recursiveHelper(node.right, list, depth + 1);
                recursiveHelper(node.left, list, depth + 1);
            }
        }

        #endregion



        static void Main(string[] args)
        {

        }
    }
}
