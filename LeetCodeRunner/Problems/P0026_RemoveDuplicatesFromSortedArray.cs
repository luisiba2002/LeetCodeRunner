using LeetCodeRunner.Core;

namespace LeetCodeRunner.Problems
{
    [Problem (26, "Remove Duplicates from Sorted Array")]
    public class P0026_RemoveDuplicatesFromSortedArray :IProblem
    {
        public void Run()
        {
            int[] nums1 = { 1, 1, 2 };
            int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine ($"Test 1: {RemoveDuplicates(nums1)}");
            Console.WriteLine ($"Test 2: {RemoveDuplicates(nums2)}");
        }

        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int k = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
