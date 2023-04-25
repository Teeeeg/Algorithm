using Algorithm.Util;

namespace AlgorithmAD.Util;

public class MyLinkedList
{
    private readonly int[] _values;
    private readonly ListNode _dummyHead = new ListNode();
    public ListNode Head { get => _dummyHead.next; }


    public MyLinkedList(int[] Values)
    {
        _values = Values;
        var cur = _dummyHead;

        foreach (var value in _values)
        {
            cur.next = new ListNode(value);
            cur = cur.next;
        }
    }
}
