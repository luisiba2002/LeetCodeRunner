using LeetCodeRunner.Core;

namespace LeetCodeRunner.Problems
{
    [Problem (35, "Search Insert Position")]
    public class P0035_SearchInsertPosition : IProblem
    {
        public void Run()
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 5;
            Console.WriteLine($"El índice de inserción para {target} es: {SearchInsert(nums, target)}");

            target = 2;
            Console.WriteLine($"El índice de inserción para {target} es: {SearchInsert(nums, target)}");

            target = 7;
            Console.WriteLine($"El índice de inserción para {target} es: {SearchInsert(nums, target)}");

            target = 0;
            Console.WriteLine($"El índice de inserción para {target} es: {SearchInsert(nums, target)}");
        }

        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
