using Preparation.Problem;
using System.Collections.Generic;

namespace Preparation.Arrays
{
    internal class ReverseArray : CollectionProblem<int[], int>
    {
        public ReverseArray()
            : base("Given an array, reverse entire array")
        {

        }

        public override IEnumerable<int> Solution(int[] input)
        {
            int i = 0, j = input.Length - 1;
            while (i < j)
            {
                Swap(input, i, j);
                i++; j--;
            }
            return input;
        }

        private static void Swap(int[] input, int i, int j)
        {
            input[i] = input[i] + input[j];
            input[j] = input[i] - input[j];
            input[i] = input[i] - input[j];
        }

        public override void TestCases()
        {
            AddTestCase(new[] { 1, 4, 6, 9, 8 }, new[] { 8, 9, 6, 4, 1 });
            AddTestCase(new[] { 1, 2 }, new[] { 2, 1 });
            AddTestCase(new[] { 9, 8, 3 }, new[] { 3, 8, 9 });
        }
    }
}
