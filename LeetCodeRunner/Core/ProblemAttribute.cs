namespace LeetCodeRunner.Core
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ProblemAttribute : Attribute
    {
        public int Id { get; }
        public string Name { get; }

        public ProblemAttribute(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
