using LeetCodeRunner.Core;

namespace LeetCodeRunner.Problems
{
    [Problem(14, "Longest Common Prefix")]
    public class P0014_LongestCommonPrefix : IProblem
    {
        public void Run()
        {
            string[] s1 = { "flower", "flow", "flight" };
            string[] s2 = { "dog", "racecar", "car" };
            Console.WriteLine($"El prefijo común más largo entre {s1} es: {LongestCommonPrefix(s1)}");
            Console.WriteLine($"El prefijo común más largo entre {s2} es: {LongestCommonPrefix(s2)}");
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";

            for (int i = 0; i < strs[0].Length; i++)
            {
                char c = strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != c)
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }

            return strs[0];
        }
    }
}
