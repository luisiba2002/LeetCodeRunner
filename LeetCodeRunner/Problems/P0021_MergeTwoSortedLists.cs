using LeetCodeRunner.Core;

namespace LeetCodeRunner.Problems
{
    [Problem (21, "Merge two sorted lists")]
    public class P0021_MergeTwoSortedLists : IProblem
    {
        public void Run()
        {
            // Helper para imprimir listas
            void PrintList(ListNode node)
            {
                List<int> values = new List<int>();
                while (node != null)
                {
                    values.Add(node.val);
                    node = node.next;
                }
                Console.WriteLine(string.Join(" -> ", values));
            }

            // Helper para crear listas
            ListNode BuildList(params int[] values)
            {
                ListNode dummy = new ListNode(0);
                ListNode current = dummy;

                foreach (var v in values)
                {
                    current.next = new ListNode(v);
                    current = current.next;
                }

                return dummy.next;
            }

            var l1 = BuildList(1, 2, 4);
            var l2 = BuildList(1, 3, 4);
            Console.Write("Test 1: ");
            PrintList(MergeTwoLists(l1, l2));

            l1 = null;
            l2 = BuildList(0);
            Console.Write("Test 2: ");
            PrintList(MergeTwoLists(l1, l2));

            l1 = null;
            l2 = null;
            Console.Write("Test 3: ");
            PrintList(MergeTwoLists(l1, l2));

            l1 = BuildList(1, 3, 5, 7);
            l2 = BuildList(2);
            Console.Write("Test 4: ");
            PrintList(MergeTwoLists(l1, l2));

            l1 = BuildList(1, 1, 1);
            l2 = BuildList(1, 1);
            Console.Write("Test 5: ");
            PrintList(MergeTwoLists(l1, l2));

            l1 = BuildList(-3, -1, 2);
            l2 = BuildList(-2, 0, 3);
            Console.Write("Test 6: ");
            PrintList(MergeTwoLists(l1, l2));

            l1 = BuildList(1, 2, 3);
            l2 = BuildList(4, 5, 6);
            Console.Write("Test 7: ");
            PrintList(MergeTwoLists(l1, l2));
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            current.next = list1 ?? list2;
            return dummy.next;
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
