using LeetCodeRunner.Core;

namespace LeetCodeRunner.Problems
{
    [Problem (70, "Climbing Stairs")]
    public class P0070_ClimbingStairs : IProblem
    {
        public void Run()
        {
            Console.WriteLine($"Número de formas de subir 2 escaleras: {ClimbStairs(2)}");
            Console.WriteLine($"Número de formas de subir 3 escaleras: {ClimbStairs(3)}");
            Console.WriteLine($"Número de formas de subir 4 escaleras: {ClimbStairs(4)}");
        }

        public int ClimbStairs(int n)
        {
            if (n <= 2)
            {
                return n;
            }

            int a = 1, b = 2;

            for (int i = 3; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}
