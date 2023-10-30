using Preparation.Problem;
using System.Collections.Generic;

namespace Preparation.Arrays
{
    internal class FindEquilibriumIndexes : CollectionProblem<int[], int>
    {
        public FindEquilibriumIndexes()
            : base("Given an array, with N elements, count no. of equilibrium index. An index i is said to be equilibrium if " +
                  "sum of all element before ith index = sum of all element after ith index")
        {

        }

        public override IEnumerable<int> Solution(int[] input)
        {
            var prefixSumArray = new int[input.Length];
            prefixSumArray[0] = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                prefixSumArray[i] = prefixSumArray[i - 1] + input[i];
            }
            // 0, 1, 2 - indexes
            // 1,-2, 1 - items

            // 0, 1,-1
            //-1, 1, 0

            // 1,-1, 0 pf[i]

            // n = 3

            var n = input.Length;

            var indexes = new List<int>();

            if (prefixSumArray[n - 1] - prefixSumArray[0] == 0) indexes.Add(0);

            for (int i = 1; i < n; i++)
            {
                var leftSum = prefixSumArray[i - 1];
                var rightSum = prefixSumArray[n - 1] - prefixSumArray[i];
                if (leftSum == rightSum) indexes.Add(i);
            }

            return indexes;
        }
        public override void TestCases()
        {
            AddTestCase(new[] { 1, -2, 1 }, new[] { 1 });
            AddTestCase(new[] { -7, 1, 5, 2, -4, 3, 0 }, new[] { 3, 6 });
        }
    }
}
