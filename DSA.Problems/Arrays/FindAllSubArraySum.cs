namespace Preparation.Arrays
{
    internal class FindAllSubArraySum : Problem<int[], int>
    {
        public FindAllSubArraySum()
            : base("Find the sum of all subarrays")
        {

        }

        public override int Solution(int[] input)
        {
            /*
               eg: [1, 2, 8, 4, 5, 6]

                contribution of each item
                take 8

                3 contains in
                subarray starts from
                    [1, 2, 8]
                and end with
                    [8, 4, 5, 6]

                ie 3 * 4 * 8
                ie (i + 1) * (n - i) * A[i]
             */

            var sum = 0;
            var n = input.Length;
            for (int i = 0; i < n; i++)
            {
                sum += (i + 1) * (n - i) * input[i];
            }
            return sum;
        }



        public override void TestCases()
        {
            AddTestCase(new[] { 1, 8, -2, 3, 5}, 100);
        }
    }
}
