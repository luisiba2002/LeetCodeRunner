using LeetCodeRunner.Core;

namespace LeetCodeRunner.Problems
{
    [Problem (28, "Find the Index of the First Occurrence in a String")]
    public class P0028_IndexOfFirstOccurrenceInString : IProblem
    {
        public void Run()
        {
            string haystack = "hello";
            string needle = "ll";
            Console.WriteLine($"La primera ocurrencia de '{needle}' en '{haystack}' es en el índice: {StrStr(haystack, needle)}");
        }
        public int StrStr(string haystack, string needle)
        {
            if (!haystack.Contains(needle)) return -1;
            return haystack.IndexOf(needle);
        }
    }
}
