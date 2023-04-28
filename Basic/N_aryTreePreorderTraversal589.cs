using AlgorithmAD.Util;

namespace AlgorithmAD.Basic;

public class N_aryTreePreorderTraversal589
{
    public IList<int> Preorder(Node root)
    {
        var result = new List<int>();

        preorderRecursive(root, result);

        return result;
    }

    private void preorderRecursive(Node root, IList<int> result)
    {
        if (root is null)
        {
            return;
        }

        result.Add(root.val);
        foreach (var childNode in root.children)
        {
            preorderRecursive(childNode, result);
        }
    }
}
