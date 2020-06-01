using System;
using System.Collections.Generic;

// Merge two sorted linked lists and return it as a new sorted list. The new list should be made by splicing together the nodes of the first two lists.

// Example:

// Input: 1->2->4, 1->3->4
// Output: 1->1->2->3->4->4


namespace mergeTwoSortedLists
{
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


    class Program
    {
        static void Main(string[] args)
        {
            List<int> testCase1 = new List<int>(new int[] {1,2,3,4,5});
            int[] testCase2 = {3,4,4,6};

            LinkedList<int> test1 = new LinkedList<int>(testCase1);
            LinkedList<int> test2 = new LinkedList<int>(testCase2);

            var fifth = new ListNode(testCase1[4], null);
            var fourth = new ListNode(testCase1[3], fifth);
            var third = new ListNode(testCase1[2], fourth);
            var second = new ListNode(testCase1[1], third);
            var head = new ListNode(testCase1[0], second);
            var newHead = ReverseList(head);
            while (newHead.next != null) {
                Console.WriteLine($"{newHead.val}, ");
                newHead = newHead.next;
            }
            Console.WriteLine(newHead.val);
            // ReverseList(test2.First;
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var currentNode1 = l1;
            var currentNode2 = l2;
            ListNode solution = new ListNode();

            while (currentNode1.next != null || currentNode2.next != null)
            {

            }


            return solution;
        }

        public static ListNode ReverseList(ListNode head)
        {
            ListNode nextNode = null;
            ListNode prevNode = null;
            ListNode currentNode = head;

            while (currentNode.next != null)
            {
                nextNode = currentNode.next;
                currentNode.next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
            }
            currentNode.next = prevNode;
            return currentNode;
        }

    }
}
