using System.Diagnostics;

namespace LeetCodeRunner.Utils
{
    public static class Benchmark
    {
        public static void Run(Action action)
        {
            var sw = Stopwatch.StartNew();

            action();

            sw.Stop();
            Console.WriteLine($"\nTiempo: {sw.ElapsedMilliseconds} ms");
        }
    }

}
