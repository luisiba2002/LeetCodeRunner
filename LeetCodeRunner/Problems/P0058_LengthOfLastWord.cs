using LeetCodeRunner.Core;

namespace LeetCodeRunner.Problems
{
    [Problem (58, "Length of Last Word")]
    public class P0058_LengthOfLastWord : IProblem
    {
        public void Run()
        {
            string input = "Hello World";
            string input2 = "   fly me   to   the moon  ";
            string input3 = "luffy is still joyboy";
            Console.WriteLine($"La longitud de la última palabra en '{input}' es: {LengthOfLastWord(input)}");
            Console.WriteLine($"La longitud de la última palabra en '{input2}' es: {LengthOfLastWord(input2)}");
            Console.WriteLine($"La longitud de la última palabra en '{input3}' es: {LengthOfLastWord(input3)}");
        }

        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            int valor = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (!char.IsLetterOrDigit(s[i]))
                {
                    break;
                }
                valor++;
            }
            return valor;
        }
    }
}
