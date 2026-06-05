using LeetCodeRunner.Core;

namespace LeetCodeRunner.Problems
{
    [Problem (69, "Sqrt(x)")]
    public class P0069_SqrtX : IProblem
    {
        public void Run()
        {
            Console.WriteLine($"La raíz cuadrada entera de 4 es: {MySqrt(4)}");
            Console.WriteLine($"La raíz cuadrada entera de 8 es: {MySqrt(8)}");
        }

        public int MySqrt(int x)
        {
            if (x < 2) return x;

            int left = 1;
            int right = x / 2;
            int result = 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                long square = (long)mid * mid;

                if (square == x)
                {
                    return mid;
                }
                else if (square < x)
                {
                    result = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
    }
}
