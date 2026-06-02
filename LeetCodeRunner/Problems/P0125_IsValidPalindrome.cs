using LeetCodeRunner.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeRunner.Problems
{
    public class P0125_IsValidPalindrome : IProblem
    {
        public void Run()
        {

        }

        public bool IsValidPalindrome(string s)
        {
            //Primero obtenemos puntero izquierdo y derecho
            int left = 0;
            int right = s.Length - 1;

            //Después, vamos recorriendo mientras los punteros sean de diferente valor
            while (left < right)
            {
                while (!char.IsLetterOrDigit(s[left])) left++;
                while (!char.IsLetterOrDigit(s[right])) right--;

                if (char.ToLower(s[left]) != char.ToLower(s[right])) return false;

                left++;
                right--;
            }
            return true;
        }
    }
}
