using LeetCodeRunner.Core;

namespace LeetCodeRunner.Problems
{
    [Problem (66, "Plus One")]
    public class P0066_PlusOne : IProblem
    {
        public void Run()
        {
            int[] digits = { 1, 2, 3 };
            Console.WriteLine($"Resultado: {string.Join(", ", PlusOne(digits))}");

            digits = new int[] { 4, 3, 2, 1 };
            Console.WriteLine($"Resultado: {string.Join(", ", PlusOne(digits))}");

            digits = new int[] { 9 };
            Console.WriteLine($"Resultado: {string.Join(", ", PlusOne(digits))}");
        }

        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}
