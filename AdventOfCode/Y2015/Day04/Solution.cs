using AdventOfCode.Lib;
using AdventOfCode.Lib.Attributes;
using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text;

namespace AdventOfCode.Y2015.Day04
{
    [Link("https://adventofcode.com/2015/day/4")]
    public class Solution : AbstractSolution
    {
        public Solution() : base(4, 2015, "The Ideal Stocking Stuffer")
        {

        }

        [Answer(117946)]
        public override string SolvePartOne()
        {
            return ParallelFind(Input, "00000").ToString();
        }

        [Answer(3938038)]
        public override string SolvePartTwo()
        {
            return ParallelFind(Input, "000000").ToString();
        }

        private int ParallelFind(string input, string prefix)
        {
            var q = new ConcurrentQueue<int>();

            Parallel.ForEach(
                Enumerable.Range(0, int.MaxValue),
                MD5.Create,
                (i, state, md5) => {
                    var hashBytes = md5.ComputeHash(Encoding.ASCII.GetBytes(input + i));
                    var hash = Convert.ToHexString(hashBytes);

                    if (hash.StartsWith(prefix))
                    {
                        q.Enqueue(i);
                        state.Stop();
                    }
                    return md5;
                },
                 (_) => { }
            );
            return q.Min();
        }
    }
}
