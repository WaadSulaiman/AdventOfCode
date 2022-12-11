using AdventOfCode.Lib;
using AdventOfCode.Y2015.Day03;

namespace AdventOfCode.Tests.Y2015
{
    public class Day03
    {
        private readonly AbstractSolution day;

        public Day03()
        {
            day = new Solution();
        }

        [Fact]
        public void PartOne()
        {
            string actual = day.SolvePartOne();
            Assert.Equal("2592", actual);
        }

        [Fact]
        public void PartTwo()
        {
            string actual = day.SolvePartTwo();
            Assert.Equal("2360", actual);
        }
    }
}