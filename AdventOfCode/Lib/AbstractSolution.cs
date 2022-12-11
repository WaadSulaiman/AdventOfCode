namespace AdventOfCode.Lib
{
    public abstract class AbstractSolution
    {
        public int Day { get; }

        public int Year { get; }

        public string Name { get; }

        public string Input => LoadInput();

        protected AbstractSolution(int day, int year, string name)
        {
            Day = day;
            Year = year;
            Name = name;
        }

        protected virtual string LoadInput()
        {
            return FileReader.ReadAllText(Day, Year);
        }

        public abstract string SolvePartOne();

        public abstract string SolvePartTwo();
    }
}