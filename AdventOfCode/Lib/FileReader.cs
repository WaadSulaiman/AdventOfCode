namespace AdventOfCode.Lib
{
    internal static class FileReader
    {
        public static string ReadAllText(int day, int year)
        {
            string path = GetPath(day, year);

            if (File.Exists(path) && new FileInfo(path).Length > 0)
            {
                return File.ReadAllText(path);
            }

            return string.Empty;
        }

        public static string[] ReadAllLines(int day, int year)
        {
            string path = GetPath(day, year);

            if (File.Exists(path) && new FileInfo(path).Length > 0)
            {
                return File.ReadAllLines(path);
            }

            return Array.Empty<string>();
        }

        private static string GetPath(int day, int year)
        {
            string currentDay = day % 10 > 0 ? $"0{day}" : day.ToString();
            return Path.Combine(AppSettings.Path, $"Y{year}\\Day{currentDay}\\input.in");
        }
    }
}