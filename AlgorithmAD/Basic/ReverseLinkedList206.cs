namespace Algorithm.Util;

class ReverseLinkedList206
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode? pre = null;
        ListNode cur = head;
        ListNode? post = null;

        while (cur != null)
        {
            post = cur.next;
            cur.next = pre;
            pre = cur;
            cur = post;
        }

        return pre;
    }
}