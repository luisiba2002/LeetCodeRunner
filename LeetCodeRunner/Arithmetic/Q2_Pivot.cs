using LeetCodeRunner.Core;

namespace LeetCodeRunner.Arithmetic
{
    public class Q2_Pivot : IProblem
    {
        public void Run()
        {
            int num = new Random().Next(1000);
            int pivot = GetPivot(num);
            Console.WriteLine($"Número: {num}, Pivot: {pivot}");
        }

        public int GetPivot(int num)
        {
            if (num == 1)
            {
                return 1;
            }

            int pivot = -1;
            int rightSum = GetTotalSum(num);
            int leftSum = 0;

            for (int i = 1; i<= num; i++)
            {
                leftSum += i;
                rightSum -= i - 1;

                if (leftSum == rightSum)
                {
                    pivot = i;
                    break;
                }
            }

            return pivot;
        }

        public int GetTotalSum(int num)
        {
            int suma = 0;

            for (int i = 1; i <= num; i++)
            {
                suma += i;
            }

            return suma;
        }
    }
}
