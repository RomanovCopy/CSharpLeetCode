using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002AddTwoNumbers
{
    internal class Solution
    {

        public Solution()
        {
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));
            AddTwoNumbers(l1, l2);
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode l3 = new ListNode();
            ListNode l = l3;
            int transfer = 0;
            while (l1 != null || l2 != null)
            {
                int value = l1.val + l2.val + transfer;
                l3.next = new ListNode(0);
                if (value > 9)
                {
                    transfer = value / 10;
                    value = value % 10;
                }
                else
                {
                    transfer = 0;
                }
                l3.val = value;
                l3 = l3.next;
                l1 = l1.next;
                l2 = l2.next;
            }
            return l;
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

    }
}
