using AdventOfCode.Lib;
using AdventOfCode.Y2015.Day1;

namespace AdventOfCode.Tests.Y2015
{
    public class Day1
    {
        private readonly AbstractSolution day;
        
        public Day1()
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
