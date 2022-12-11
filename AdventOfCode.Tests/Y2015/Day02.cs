using AdventOfCode.Lib;
using AdventOfCode.Y2015.Day02;

namespace AdventOfCode.Tests.Y2015
{
    public class Day02
    {
        private readonly AbstractSolution day;

        public Day02()
        {
            day = new Solution();
        }

        [Fact]
        public void PartOne()
        {
            string actual = day.SolvePartOne();
            Assert.Equal("1588178", actual);
        }

        [Fact]
        public void PartTwo()
        {
            string actual = day.SolvePartTwo();
            Assert.Equal("3783758", actual);
        }
    }
}