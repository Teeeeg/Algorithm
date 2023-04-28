using AlgorithmAD.Util;

namespace AlgorithmAD.Basic;

public class BinaryTreeLevelOrderTraversal102
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();
        var queue = new Queue<TreeNode>();

        if (root is null)
        {
            return result;
        }

        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            var levelCount = queue.Count;
            var levelList = new List<int>();

            for (int i = 0; i < levelCount; i++)
            {
                var cur = queue.Dequeue();
                levelList.Add(cur.val);

                if (cur.left is not null)
                {
                    queue.Enqueue(cur.left);
                }

                if (cur.right is not null)
                {
                    queue.Enqueue(cur.right);
                }
            }

            result.Add(levelList);
        }

        return result;
    }
}
