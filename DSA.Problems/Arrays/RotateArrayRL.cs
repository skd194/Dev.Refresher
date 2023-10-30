using Preparation.Problem;
using System.Collections.Generic;

namespace Preparation.Arrays
{
    internal class RotateArrayRL : CollectionProblem<(int[] array, int r), int>
    {
        public RotateArrayRL()
            : base("Rotate array from right to left")
        {

        }

        public override IEnumerable<int> Solution((int[] array, int r) input)
        {
            /* 0 1 2 3 4 5 6 7 8
               1 2 3 4 5
                 1 2 3 4 5
                   1 2 3 4 5
                     1 2 3 4 5
                       1 2 3 4 5
             CI NI
             0  1
             1  2
             2  3
             3  4
             4  5 -> 0
            CI: Current Index

             */

            var n = input.array.Length;
            var rotatedArray = new int[n];
            for(int i = 0; i < n; i++)
            {
                rotatedArray[(n + input.r + i) % n] = input.array[i];
            }
            return rotatedArray;
        }

        public override void TestCases()
        {
            AddTestCase((new[] { 1, 2, 3, 4, 5 }, 1), new[] { 5, 1, 2, 3, 4 });
            AddTestCase((new[] { 1, 2, 3, 4, 5 }, 2), new[] { 4, 5, 1, 2, 3 });
            AddTestCase((new[] { 1, 2, 3, 4, 5 }, 6), new[] { 5, 1, 2, 3, 4 });
            AddTestCase((new[] { 1, 2, 3, 4, 5 }, 4), new[] { 2, 3, 4, 5, 1 });
            AddTestCase((new[] { 1, 2, 3, 4, 5, 6, 7 }, 5), new[] { 3, 4, 5, 6, 7, 1, 2 });
            AddTestCase((new[] { 1 }, 5), new[] { 1 });
        }
    }
}
