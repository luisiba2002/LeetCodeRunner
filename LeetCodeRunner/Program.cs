using LeetCodeRunner.Core;
using LeetCodeRunner.Utils;

namespace LeetCodeRunner
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var problems = ProblemRunner.Discover();

            Console.WriteLine("Problemas disponibles:");
            foreach (var p in problems)
            {
                Console.WriteLine($"{p.Key}: {p.Value.Name}");
            }

            Console.Write("\nSelecciona problema: ");
            int choice = int.Parse(Console.ReadLine()!);

            if (problems.TryGetValue(choice, out var problem))
            {
                Console.WriteLine($"\n|> Ejecutando: {problem.Name}\n");

                Benchmark.Run(problem.Instance.Run);
            }
            else
            {
                Console.WriteLine(">< Problema no encontrado");
            }

        }
    }
}
