namespace AdventOfCode.Lib.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LinkAttribute : Attribute
    {
        public string Url { get; }

        public LinkAttribute(string url)
        {
            Url = url;
        }
    }
}