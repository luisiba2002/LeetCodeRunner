using LeetCodeRunner.Core;

namespace LeetCodeRunner.Problems
{
    [Problem(9, "Palindrome Number")]
    public class P0009_PalindromeNumber : IProblem
    {
        public void Run()
        {
            Console.WriteLine("¿Is 121 a palindrome?" + IsPalindrome(121));
            Console.WriteLine("¿Is -121 a palindrome?" + IsPalindrome(-121));
            Console.WriteLine("¿Is 10 a palindrome?" + IsPalindrome(10));
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;
            int reversed = 0;
            while (x > reversed)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }

            return x == reversed || x == reversed / 10;
        }
    }
}
