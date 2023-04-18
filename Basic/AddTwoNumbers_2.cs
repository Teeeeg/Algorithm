namespace Algorithm;

class AddTwoNumbers_2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode cur1 = l1;
        ListNode cur2 = l2;
        ListNode resHead = new ListNode();
        ListNode cur = resHead;
        int carry = 0;

        while (cur1 != null || cur2 != null)
        {
            int digit1 = 0;
            if (cur1 is not null)
            {
                digit1 = cur1.val;
                cur1 = cur1.next;
            }

            int digit2 = 0;
            if (cur2 is not null)
            {
                digit2 = cur2.val;
                cur2 = cur2.next;
            }

            int sum = digit1 + digit2 + carry;
            carry = Math.DivRem(sum, 10, out int digit);

            cur.next = new ListNode(digit);
            cur = cur.next;

        }

        if (carry != 0)
        {
            cur.next = new ListNode(carry);
        }

        return resHead.next;
    }


}