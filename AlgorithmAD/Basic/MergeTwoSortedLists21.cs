using Algorithm.Util;
using AlgorithmAD.Util;

namespace AlgorithmAD.Basic;

public class MergeTwoSortedLists21
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 is null)
        {
            return list2;
        }

        if (list2 is null)
        {
            return list1;
        }

        var cur1 = list1;
        var cur2 = list2;
        var resHead = new ListNode();
        var cur = resHead;

        while (cur1 != null && cur2 != null)
        {
            var digit1 = cur1.val;
            var digit2 = cur2.val;

            if (digit1 < digit2)
            {
                cur.next = cur1!;
                cur1 = cur1!.next;
            }
            else
            {
                cur.next = cur2!;
                cur2 = cur2!.next;
            }
            cur = cur.next;
        }

        cur.next = (cur1 != null) ? cur1 : cur2;

        return resHead.next;
    }

    public void Test()
    {
        var values1 = new int[] { 1 };
        var values2 = new[] { 2 };

        var head1 = new MyLinkedList(values1).Head;
        var head2 = new MyLinkedList(values2).Head;

        var resHead = MergeTwoLists(head1, head2);
        Console.ReadLine();
    }
}
