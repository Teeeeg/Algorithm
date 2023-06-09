using AlgorithmAD.Util;

namespace AlgorithmAD.Basic;

public class LowestCommonAncestorofaBinaryTree235
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        return LowestCommonAncestorRecursive(root, p, q);
    }

    private TreeNode LowestCommonAncestorRecursive(TreeNode root, TreeNode p, TreeNode q)
    {
        if ((p.val <= root.val && root.val <= q.val) ||
            (p.val >= root.val && root.val >= q.val))
            return root;

        if (root.val < p.val) return LowestCommonAncestorRecursive(root.right, p, q);

        return LowestCommonAncestorRecursive(root.left, p, q);
    }
}