using AdventOfCode.Lib;
using AdventOfCode.Lib.Attributes;

namespace AdventOfCode.Y2015.Day03
{
    [Link("https://adventofcode.com/2015/day/3")]
    public class Solution : AbstractSolution
    {
        public Solution() : base(3, 2015, "Perfectly Spherical Houses in a Vacuum")
        {
        }

        [Answer(2592)]
        public override string SolvePartOne()
        {
            HashSet<House> visited = new HashSet<House>();

            House santaLocation = new House(0, 0);
            visited.Add(santaLocation);

            return Input.Aggregate(visited, (houses, direction) =>
            {
                santaLocation = Move(santaLocation, direction);
                visited.Add(santaLocation);

                return houses;
            }).Count.ToString();
        }

        [Answer(2360)]
        public override string SolvePartTwo()
        {
            HashSet<House> visited = new HashSet<House>();

            House santaLocation = new House(0, 0);
            House robotLocation = new House(0, 0);

            visited.Add(santaLocation);

            for (int i = 0; i < Input.Length; i += 2)
            {
                santaLocation = Move(santaLocation, Input[i]);
                robotLocation = Move(robotLocation, Input[i + 1]);

                visited.Add(santaLocation);
                visited.Add(robotLocation);
            }

            return visited.Count.ToString();
        }

        private House Move(House house, char direction)
        {
            return direction switch
            {
                '^' => new House(house.X, house.Y + 1),
                'v' => new House(house.X, house.Y - 1),
                '>' => new House(house.X + 1, house.Y),
                '<' => new House(house.X - 1, house.Y),
                _ => throw new InvalidDataException()
            };
        }
    }

    public record House(int X, int Y);
}