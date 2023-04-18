using Algorithm;

var ad = new AddTwoNumbers_2();

var l1 = new ListNode(2);
var cur = l1;
cur.next = new ListNode(4);
cur.next.next = new ListNode(3);

var l2 = new ListNode(5);
var cur1 = l2;
cur1.next = new ListNode(6);
cur1.next.next = new ListNode(4);
ad.AddTwoNumbers(l1, l2);
