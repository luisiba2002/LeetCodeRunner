using LeetCodeRunner.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeRunner.Problems
{
    [Problem(1, "Two Sum")]
    public class P0001_TwoSum : IProblem
    {
        public void Run()
        {
            var nums = new[] { 2, 7, 11, 15 };
            int target = 9;

            var result = TwoSum(nums, target);

            Console.WriteLine($"Resultado: [{result[0]}, {result[1]}]");
        }

        private int[] TwoSum(int[] nums, int target)
        {
            var filtered = nums.Where(x => x <= target).ToArray();

            var numDict = new Dictionary<int, int>();

            for (int i = 0; i < filtered.Length; i++)
            {
                int complement = target - filtered[i];
                if (numDict.TryGetValue(complement, out int complementIndex))
                {
                    return new[] { complementIndex, i };
                }
                numDict[filtered[i]] = i;
            }

            throw new ArgumentException("No two sum solution");
        }
    }
}
