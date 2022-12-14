namespace TopInterviewQuestions;

/// <summary>
/// Add Two Numbers
/// <see href="https://leetcode.com/problems/add-two-numbers/"/>
/// </summary>
public class AddTwoNumbers
{
    public static ListNode ReverseOrderSum(ListNode l1, ListNode l2)
    {
        var dummyHead = new ListNode();
        var curr = dummyHead;
        var carry = 0;
        while (l1 != null || l2 != null || carry != 0) {
            var x = l1?.val ?? 0;
            var y = l2?.val ?? 0;
            var sum = carry + x + y;
            carry = sum / 10;
            curr.next = new ListNode(sum % 10);
            curr = curr.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }
        return dummyHead.next;
    }
}

public class ListNode {
    public int val;
    public ListNode? next;
    public ListNode(int val=0, ListNode? next=null) {
        this.val = val;
        this.next = next;
    }
}