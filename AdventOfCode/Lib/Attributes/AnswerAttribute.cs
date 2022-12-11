namespace AdventOfCode.Lib.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AnswerAttribute : Attribute
    {
        public object Answer { get; }

        public AnswerAttribute(object answer)
        {
            Answer = answer;
        }
    }
}