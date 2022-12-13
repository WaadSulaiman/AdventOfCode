using AdventOfCode.Lib;
using AdventOfCode.Y2015.Day04;

namespace AdventOfCode.Tests.Y2015
{
    public class Day04
    {
        private readonly AbstractSolution day;

        public Day04()
        {
            day = new Solution();
        }

        [Fact]
        public void PartOne()
        {
            string actual = day.SolvePartOne();
            Assert.Equal("117946", actual);
        }

        [Fact]
        public void PartTwo()
        {
            string actual = day.SolvePartTwo();
            Assert.Equal("3938038", actual);
        }
    }
}