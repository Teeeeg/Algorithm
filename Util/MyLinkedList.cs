using Algorithm.Util;
using AlgorithmAD.Extension;

namespace AlgorithmAD.Util;

public class MyLinkedList
{
    private readonly ListNode _dummyHead = new ListNode();
    public ListNode Head => _dummyHead.next;


    public MyLinkedList(IEnumerable<int> values)
    {
        var cur = _dummyHead;

        foreach (var value in values)
        {
            cur.next = new ListNode(value);
            cur = cur.next;
        }
    }

    public void Print()
    {
        var valuesToPrint = new List<int>();
        var cur = _dummyHead.next;

        while (cur is not null)
        {
            valuesToPrint.Add(cur.val);
            cur = cur.next;
        }

        valuesToPrint.Print();
    }
}
