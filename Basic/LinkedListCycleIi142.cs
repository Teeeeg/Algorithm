using Algorithm.Util;

namespace AlgorithmAD.Basic;

public class LinkedListCycleIi142
{
    public ListNode DetectCycle(ListNode head)
    {
        var left = head;
        var right = head;

        while (right is not null && right.next is not null)
        {
            left = left.next;
            right = right.next.next;

            if (left == right)
            {
                var collide = left;
                var start = head;

                while (collide != start)
                {
                    collide = collide.next;
                    start = start.next;
                }

                return start;

            }
        }

        return null;
    }
}
