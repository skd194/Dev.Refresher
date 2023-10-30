using Preparation.Problem;
using System.Collections.Generic;

namespace Preparation.Arrays
{
    internal class SubArrayStartEndIndexOfLenK : CollectionProblem<(int[] array, int length), (int startIndex, int endIndex)>
    {
        public SubArrayStartEndIndexOfLenK()
            : base("Find the start and end index of all subarrays of length = k")
        {

        }

        public override IEnumerable<(int startIndex, int endIndex)> Solution((int[] array, int length) input)
        {
            var n = input.array.Length;
            var result = new List<(int startIndex, int endIndex)>();
            for (var i = 0; i < n - input.length + 1; i++)
            {
                result.Add((i, i + input.length - 1));
            }
            return result;
        }

        public override void TestCases()
        {
            AddTestCase((new[] { 1, 2, 3, 4, 5, 6 }, 3), new[] { (0, 2), (1, 3), (2, 4), (3, 5) });
            AddTestCase((new[] { 1, 2, 3, 4, 5, 6 }, 5), new[] { (0, 4), (1, 5) });
        }
    }
}
