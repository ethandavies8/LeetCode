using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace RemoveLinkedListElements
{
    class Solution
    {
        public static ListNode RemoveElements(ListNode head, int val)
        {
            while (head != null && head.val == val)
                head = head.next;
            if (head == null)
                return head;
            ListNode temp = head;
            while (temp.next != null)
            {
                if (temp.next.val == val)
                    temp.next = temp.next.next;
                else
                    temp = temp.next;
            }

            return head;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        static void Main(string[] args)
        {
            ListNode next = new ListNode(7);
            ListNode otherNext = new ListNode(7);
            next.next = otherNext;
            ListNode list = new ListNode(7, next);
            ListNode returnNode = RemoveElements(list, 7);
            Console.WriteLine(list);

        }
    }
}