using AdventOfCode.Lib;
using AdventOfCode.Lib.Attributes;

namespace AdventOfCode.Y2015.Day2
{
    [Link("https://adventofcode.com/2015/day/2")]
    public class Solution : AbstractSolution
    {
        public Solution() : base(2, 2015, "I Was Told There Would Be No Math")
        {

        }

        protected override string LoadInput()
        {
            string[] input = FileReader.ReadAllLines(Day, Year);
            return string.Join(',', input);
        }

        [Answer(1588178)]
        public override string SolvePartOne()
        {
            string[] input = Input.Split(',');
            int output = 0;

            foreach (string box in input)
            {
                int[] dimensions = box.Split('x').Select(int.Parse).ToArray();

                int l = 2 * dimensions[0] * dimensions[1],
                    w = 2 * dimensions[1] * dimensions[2],
                    h = 2 * dimensions[2] * dimensions[0];

                output += l + w + h + new int[] { l / 2, w / 2, h / 2 }.Min();
            }

            return output.ToString();
        }

        [Answer(3783758)]
        public override string SolvePartTwo()
        {
            string[] input = Input.Split(',');
            int output = 0;

            foreach (string box in input)
            {
                int[] dimensions = box.Split('x').Select(int.Parse).ToArray();
                Array.Sort(dimensions);

                output += dimensions.Aggregate((n1, n2) => n1 * n2) + dimensions[0] * 2 + dimensions[1] * 2;
            }

            return output.ToString();
        }
    }
}
