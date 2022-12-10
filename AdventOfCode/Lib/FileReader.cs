namespace AdventOfCode.Lib
{
    internal static class FileReader
    {
        public static string ReadAllText(int day, int year)
        {
            string inputPath = Path.Combine(AppSettings.Path, $"Y{year}\\Day{day}\\input.in");

            if (File.Exists(inputPath) && new FileInfo(inputPath).Length > 0)
            {
                return File.ReadAllText(inputPath);
            }

            return string.Empty;
        }

        public static string[] ReadAllLines(int day, int year)
        {
            string inputPath = Path.Combine(AppSettings.Path, $"Y{year}\\Day{day}\\input.in");

            if (File.Exists(inputPath) && new FileInfo(inputPath).Length > 0)
            {
                return File.ReadAllLines(inputPath);
            }

            return Array.Empty<string>();
        }
    }
}
