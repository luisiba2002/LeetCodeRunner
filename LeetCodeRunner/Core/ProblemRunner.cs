using System.Reflection;

namespace LeetCodeRunner.Core
{
    public static class ProblemRunner
    {
        public static Dictionary<int, (string Name, IProblem Instance)> Discover()
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IProblem).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .Select(t => new
                {
                    Type = t,
                    Attr = t.GetCustomAttribute<ProblemAttribute>()
                })
                .Where(x => x.Attr != null)
                .ToDictionary(
                    x => x.Attr.Id,
                    x => (x.Attr.Name, (IProblem)Activator.CreateInstance(x.Type)!)
                );
        }
    }
}
