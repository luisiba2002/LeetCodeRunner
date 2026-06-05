using LeetCodeRunner.Core;

namespace LeetCodeRunner.Problems
{
    [Problem (27, "Remove Element")]
    public class P0027_RemoveElement : IProblem
    {
        public void Run()
        {
            int[] nums1 = { 3, 2, 2, 3 };
            int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
            Console.WriteLine($"Test 1: {RemoveElement(nums1, 3)}");
            Console.WriteLine($"Test 2: {RemoveElement(nums2, 2)}");
        }

        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
}
