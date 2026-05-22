using LeetCodeRunner.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeRunner.Arithmetic
{
    [Problem(1, "Q1_Sequence")]
    internal class Q1_Sequence : IProblem
    {
        public void Run()
        {
            var nums = new[] { 1, 2, 4};

            bool result = CanMakeArithmeticProgression(nums);

            Console.WriteLine($"Resultado: {result}");
        }

        public bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            int difference = arr[1] - arr[0];
            for (int i = 2; i < arr.Length; i++)
            {
                int actualDifference = arr[i] - arr[i - 1];
                if (actualDifference != difference)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
