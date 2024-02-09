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
            ListNode l1 = CreateListNode(new int[] { 2,4,3 });
            ListNode l2 = CreateListNode(new int[] { 5,6,4 });
            AddTwoNumbers(l1, l2);
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string value1 = ListNodeToString(l1);
            string value2 = ListNodeToString(l2);
            string value = NumbersStringToNumbersString(value1, value2);
            return CreateListNode(StringToIntArray(value));
        }

        private string NumbersStringToNumbersString(string val1, string val2)
        {
            string value = "";
            int transfer = 0;
            if (val2.Length > val1.Length)
            {
                string temp = val1;
                val1 = val2;
                val2 = temp;
            }
            for (int i = 0; i < val1.Length; i++)
            {
                int v1 = int.Parse(val1[i].ToString());
                int v2;
                if (val2.Length > i)
                {
                    v2 = int.Parse(val2[i].ToString());
                }
                else { v2 = 0; }
                int res = v1 + v2 + transfer;
                if (res > 9)
                {
                    transfer = res / 10;
                    value =value + res % 10;
                }
                else
                {
                    transfer = 0;
                    value = value + res;
                }
            }
            if (transfer > 0)
            {
                value = value + transfer;
            }
            return value;
        }

    private string ListNodeToString(ListNode listNode)
    {
        string value = "";
        while (listNode != null)
        {
            value = value + listNode.val.ToString();
            listNode = listNode.next;
        }
        return value;
    }

    private int[] StringToIntArray(string value)
    {
        int[] array = new int[value.Length];
        for (int i = 0; i < value.Length; i++)
        {
            array[i] = int.Parse(value[i].ToString());
        }
        return array;
    }

    private ListNode CreateListNode(int[] values)
    {
        ListNode listNode = new ListNode();
        ListNode newListNode = listNode;
        if (values.Length > 0)
        {
            listNode.val = values[0];
            if (values.Length > 1)
            {
                for (int i = 1; i < values.Length; i++)
                {
                    listNode.next = new ListNode();
                    listNode.next.val = values[i];
                    listNode = listNode.next;
                }
            }
        }
        return newListNode;
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
