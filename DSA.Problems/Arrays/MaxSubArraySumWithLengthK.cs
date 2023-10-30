namespace Preparation.Arrays
{
    internal class MaxSubArraySumWithLengthK : Problem<(int[] Array, int K), int>
    {
        public MaxSubArraySumWithLengthK()
            : base("Find max subarray sum with length = k")
        {

        }

        public override int Solution((int[] Array, int K) input)
        {
            // find the first sub array sum, the iterate and subtract one from left and add from right to get another set

            var n = input.Array.Length;
            var k = input.K;

            var subArraySum = 0;
            for (int i = 0; i < k; i++)
            {
                subArraySum += input.Array[i];
            }

            var maxValue = subArraySum;
            for (int i = k; i < n; i++)
            {
                subArraySum += input.Array[i] - input.Array[i - k];
                if (subArraySum > maxValue) maxValue = subArraySum;
            }
            return maxValue;
        }

        // TC : O(n^2)
        private static int SolutionBFApproach((int[] Array, int K) input)
        {
            var n = input.Array.Length;
            var maxSum = int.MinValue;
            for (int i = 0; i <= n - input.K; i++)
            {
                var endIndex = i + input.K - 1;
                var sum = 0;
                for (int j = i; j <= endIndex; j++)
                {
                    sum += input.Array[j];
                }
                if (sum > maxSum) maxSum = sum;
            }
            return maxSum;
        }

        public override void TestCases()
        {
            AddTestCase((new[] { -3, 4, -2, 5, 3, -2, 8, 2, -1, 4 }, 5), 16);
            AddTestCase((new[] { -2, 8, -4, 2, 1, 6, 8, 2, -1, 4 }, 6), 21);
            AddTestCase((new[] { -3, 4, -2, 5, 3, -2, 8, 2, -1, 4 }, 3), 9);
        }
    }
}
