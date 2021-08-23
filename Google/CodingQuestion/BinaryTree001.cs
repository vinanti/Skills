using System;
using System.Collections.Generic;
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
public class BT001
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> levelOrder = new List<IList<int>>();
        levelOrder.Add(GetChieldNodeVals(new List<TreeNode> { root }));
        List<TreeNode> chieldNodes = GetChieldNodes(new List<TreeNode> { root });
        while (chieldNodes.Count > 0)
        {
            levelOrder.Add(GetChieldNodeVals(chieldNodes));
            chieldNodes = GetChieldNodes(chieldNodes);
        }
        return levelOrder;
    }
    public List<TreeNode> GetChieldNodes(List<TreeNode> nodes)
    {
        List<TreeNode> chieldNodes = new List<TreeNode>();
        foreach (TreeNode n in nodes)
        {
            if (n.left != null) chieldNodes.Add(n.left);
            if (n.right != null) chieldNodes.Add(n.right);
        }
        return chieldNodes;
    }
    public List<int> GetChieldNodeVals(List<TreeNode> nodes)
    {
        List<int> ChieldNodeVals = new List<int>();
        foreach (TreeNode n in nodes)
        {
            ChieldNodeVals.Add(n.val);
        }
        return ChieldNodeVals;
    }

}