using LeetCodeRunner.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeRunner.Arithmetic
{
    [Problem(3, "Q3_Palindrome")]
    public class Q3_Palindrome : IProblem
    {
        public void Run()
        {
            int num = 121;
            bool isPalindrome = IsPalindrome(num);
            Console.WriteLine($"Número: {num}, es palíndromo: {isPalindrome}");
        }

        public bool IsPalindrome(int num)
        {
            int numFirst = num;
            int longitud = num == 0 ? 1 : (int)Math.Floor(Math.Log10(Math.Abs(num))) + 1;
            int numLast = 0;
            int i = 0;
            while (num > 0)
            {
                numLast += (num % 10) * (10 ^ i);
                num /= 10;
                i++;
            }

            return numFirst == numLast;
        }

        public enum equivalencias
        {
            IV = 4,
            IX = 9,
            XL = 40,
            XC = 90,
            CD = 400,
            CM = 900
        }
    }
}
