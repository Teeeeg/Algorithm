using Algorithm.Util;

namespace AlgorithmAD.Basic;

public class MiddleoftheLinkedList876
{
    public ListNode MiddleNode(ListNode head)
    {
        var left = head;
        var right = head;

        while (right is not null && right.next is not null)
        {
            left = left.next;
            right = right.next.next;
        }

        return left;
    }
}
