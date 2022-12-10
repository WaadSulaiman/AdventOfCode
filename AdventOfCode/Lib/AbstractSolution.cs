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
            string inputPath = Path.Combine(AppSettings.Path, $"Y{Year}\\Day{Day}\\input.in");

            if (File.Exists(inputPath) && new FileInfo(inputPath).Length > 0)
            {
                return File.ReadAllText(inputPath);
            }

            return string.Empty;
        }

        public abstract string SolvePartOne();

        public abstract string SolvePartTwo();
    }
}
