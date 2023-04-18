namespace Algorithm;

class ReverseLinkedList_206
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