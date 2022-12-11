using AdventOfCode.Lib;
using AdventOfCode.Y2015.Day01;

namespace AdventOfCode.Tests.Y2015
{
    public class Day01
    {
        private readonly AbstractSolution day;

        public Day01()
        {
            day = new Solution();
        }

        [Fact]
        public void PartOne()
        {
            string actual = day.SolvePartOne();
            Assert.Equal("280", actual);
        }

        [Fact]
        public void PartTwo()
        {
            string actual = day.SolvePartTwo();
            Assert.Equal("1797", actual);
        }
    }
}