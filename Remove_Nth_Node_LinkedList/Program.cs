static void Main(string[] args)
{
    Console.WriteLine("Hello World!");
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null!)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode(- 1);
        dummy.next = head;
        ListNode slow = dummy;
        ListNode fast = dummy;
        while (fast.next != null)
        {
            fast = fast.next;
            if (n-- <= 0)
            {
                slow = slow.next;
            }
        }

        slow.next = slow.next.next;
        return dummy.next;
    }
}