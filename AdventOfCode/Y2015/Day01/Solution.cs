using AdventOfCode.Lib;
using AdventOfCode.Lib.Attributes;

namespace AdventOfCode.Y2015.Day01
{
    [Link("https://adventofcode.com/2015/day/1")]
    public class Solution : AbstractSolution
    {
        public Solution() : base(1, 2015, "Not Quite Lisp")
        {
        }

        [Answer(280)]
        public override string SolvePartOne()
        {
            return Input.Aggregate(0, (current, character) => character switch
            {
                '(' => current + 1,
                ')' => current - 1,
                _ => throw new InvalidDataException(),
            }).ToString();
        }

        [Answer(1797)]
        public override string SolvePartTwo()
        {
            int floor = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] == '(') floor++;
                else floor--;

                if (floor == -1) return (i + 1).ToString();
            }

            return floor.ToString();
        }
    }
}