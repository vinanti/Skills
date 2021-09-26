using System;

namespace Coding_Q0654
{
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
    class Q0654
    {
        static void Main654()
        {
            ConstructMaximumBinaryTree(new int[] { 3, 2, 1, 6, 0, 5 });
        }
        public static TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            int index = MaxValueIndex(nums);
            TreeNode tree = new TreeNode(nums[index]);
            if (index == 0)
                tree.left = null;
            else
            {
                int[] leftArr = new int[index];
                for (int i = 0; i < index; i++)
                    leftArr[i] = nums[i];
                tree.left = ConstructMaximumBinaryTree(leftArr);
            }
            if (index == nums.Length - 1)
                tree.right = null;
            else
            {
                int[] rightArr = new int[nums.Length - (index + 1)];
                int j = 0;
                for (int i = index + 1; i < nums.Length; i++)
                {
                    rightArr[j] = nums[i];
                    j++;
                }
                tree.right = ConstructMaximumBinaryTree(rightArr);
            }
            return tree;
        }
        public static int MaxValueIndex(int[] nums)
        {
            int max = -1, index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
