using LeetCodeRunner.Core;

namespace LeetCodeRunner.Problems
{
    public class P0013_RomanToInteger : IProblem
    {
        public void Run()
        {
            string s1 = "III";
            string s2 = "LVIII";
            string s3 = "MCMXCIV";
            Console.WriteLine($"La conversión de {s1} es: {RomanToInt(s1)}");
            Console.WriteLine($"La conversión de {s2} es: {RomanToInt(s2)}");
            Console.WriteLine($"La conversión de {s3} es: {RomanToInt(s3)}");
        }

        public int RomanToInt(string s)
        {
            int result = 0;
            int i = 0;

            while (i < s.Length)
            {
                if (i + 1 < s.Length)
                {
                    string sub = s.Substring(i, 2);

                    if (Enum.TryParse(sub, out excepciones ex))
                    {
                        result += (int)ex;
                        i += 2;
                        continue;
                    }
                }

                string single = s.Substring(i, 1);

                if (Enum.TryParse(single, out valores val))
                {
                    result += (int)val;
                }

                i++;
            }

            return result;
        }

        public enum excepciones
        {
            IV = 4,
            IX = 9,
            XL = 40,
            XC = 90,
            CD = 400,
            CM = 900
        }

        public enum valores
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }
    }
}
