using AlgorithmAD.Util;

namespace AlgorithmAD.Basic;

public class ValidateBinarySearchTree98
{
    public bool IsValidBST(TreeNode root)
    {
        if (root is null)
        {
            return true;
        }

        var stack = new Stack<TreeNode>();
        var cur = root;
        int? preVal = null;

        while (cur is not null || stack.Count != 0)
        {
            while (cur is not null)
            {
                stack.Push(cur);
                cur = cur.left;
            }

            cur = stack.Pop();
            if (preVal != null && cur.val <= preVal)
            {
                return false;
            }
            preVal = cur.val;
            cur = cur.right;
        }

        return true;
    }

    public void Test()
    {
        var root = new TreeNode(2);
        root.left = new TreeNode(1);
        root.right = new TreeNode(3);

        System.Console.WriteLine(IsValidBST(root));
    }
}
