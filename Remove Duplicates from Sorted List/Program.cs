using System;

namespace Remove_Duplicates_from_Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // test case = [1,1,2,3,3]
        }
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

    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return head;
            var current = head;
            while (head.next != null)
            {
                if (head.next != null && head.val == head.next.val)
                {
                    head.next = head.next.next;
                }
                else head = head.next;
            }

            return current;
        }
    }
}
