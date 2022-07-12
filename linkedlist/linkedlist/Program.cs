using System;
using System.Collections.Generic;

namespace linkedlist
{
    public class LinkedList
    {
        ListNode head;
        ListNode current;
        public ListNode Head //Expose a public property to get to head of the list  
        {
            get { return head; }
        }
        public void Add(ListNode n)
        {
            if (head == null)
            {
                head = n; // point head to first added ListNode  
                current = head; // set current to head  
            }
            else
            {
                current.next = n; //Set current next to newly added ListNode.  
                current = current.next;  //Set new current to current next.  
            }
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int data)
        {
            this.val = data;
        }
    }
    class Program
    {
        public static void Addnum(ListNode list1, ListNode list2)
        {
            ListNode head1 = list1;
            ListNode head2 = list2;
            LinkedList result = new LinkedList(); ;


            int sum = 0;
            while (head1 != null || head2 != null)
            {
                sum = sum * 10 + (head1 != null ? head1.val : 0) + (head2 != null ? head2.val : 0);
                if (head1 != null)
                    head1 = head1.next;
                if (head2 != null)
                    head2 = head2.next;
                // result.Add(new ListNode(sum));
            }


        }
        public static void Middile(ListNode head)
        {
            //5 3 10 7
            ListNode fast = head;
            ListNode slow = head;

            while (fast != null)
            {
                slow = slow.next;
                if (fast.next != null)
                    fast = fast.next.next;




            }
            int x = slow.val;

        }
        public static void SwapPairs(ListNode head)
        {
            ListNode cur = head;
            ListNode next = cur.next;
            while (cur != null)
            {

                if (next != null)
                {
                    int temp = cur.val;
                    cur.val = next.val;
                    next.val = temp;


                }
                if (cur.next != null)
                {
                    cur = cur.next.next;
                    if (cur != null)
                        next = cur.next;
                }
                else
                {
                    break;
                }


            }
        }
        public static void DeleteKth(ListNode head)
        {
            //2 3 4 5 6 7 8 9
            int k = 1;
            int count = 1;
            ListNode prev = null;
            ListNode cur = head;
            if (k == 1)
            {
                head = null;

            }
            else
            {

                while (cur != null)
                {
                    if (count % k == 0)
                    {

                        prev.next = cur.next;
                    }
                    prev = cur;
                    cur = cur.next;
                    count++;
                }

            }

        }
        
        public static void SortList(ListNode head)
        {
            //2->3->9->1l
            ListNode curreent = head;
            ListNode next;
            ListNode final = curreent;
            while (curreent != null)
            {
                next = curreent.next;
                while (next != null)
                {
                    if (curreent.val > next.val)
                    {
                        int temp = next.val;
                        next.val = curreent.val;
                        curreent.val = temp;
                    }
                    next = next.next;

                }
                curreent = curreent.next;

            }

        }


        static void Main(string[] args)
        {
            LinkedList l1 = new LinkedList();
            l1.Add(new ListNode(1));
            l1.Add(new ListNode(2));
            l1.Add(new ListNode(3));
            l1.Add(new ListNode(4));
            l1.Add(new ListNode(5));
            // l1.Head.next.next.next.next = l1.Head.next;

            //LinkedList l2 = new LinkedList();
            //l2.Add(new ListNode(5));
            //l2.Add(new ListNode(6));
            //l2.Add(new ListNode(1));
            //l2.Add(new ListNode(8));
            //l2.Add(new ListNode(4));
            //l2.Add(new ListNode(5));
            //GetIntersectionNode(l1.Head,l2.Head);
            DeleteNode(l1.Head);
            Console.ReadLine();


        }
        public static ListNode MiddleListNode(ListNode head)
        {
            // 1 2 3 4 5
            ListNode[] array = new ListNode[100];
            int t = 0;
            while (head != null)
            {
                array[t++] = head;
                head = head.next;
            }
            return array[t / 2]; ;

        }
        public static ListNode MiddleListNodeOPT(ListNode head)
        {
            // 1 2 3 4 5
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;

        }
        public static void MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode final = new ListNode(-1);
            ListNode dummy = new ListNode(-1);

            final = dummy;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    dummy.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    dummy.next = list2;
                    list2 = list2.next;
                }
                dummy = dummy.next;

            }
            if (list1 == null)
                dummy.next = list2;
            else
                dummy.next = list1;

        }
        public static bool hasCycle(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            while (head != null)
            {
                if (set.Contains(head))
                {
                    return true;
                }

                set.Add(head);
                head = head.next;
            }
            return false;
        }
        public static void GetIntersectionNode(ListNode headA, ListNode headB)
        {
            
            ListNode a = headA;
            ListNode b = headB;
            // 1 2 3 4 5
            //10 3 4 5

            while (a != b)
            {
                a = a == null ? headB : a.next;
                b = b == null ? headA : b.next;
            }

            
        }
        public static ListNode ReverseList(ListNode head)
        {
            //1 2 3 4 5
            ListNode current = head;
            ListNode prev = null;
            while (current != null)
            {
                ListNode temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
               

                
            }
            return current;
        }

        public static void DeleteNode(ListNode node)
        {
            int k = 3;
            // 1 2 3 4 5
            ListNode prev = null;
            ListNode current = node;

            while (current != null)
            {
                if (current.val == k)
                {
                    prev.next = current.next;
                    current = current.next.next;
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
                

            }


        }
    }
}
