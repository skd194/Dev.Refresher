namespace Preparation.Arrays
{
    internal class NonMaxElementsCount : Problem<int[], int>
    {
        public NonMaxElementsCount()
            : base("Count number of elements having atleast one element greater than itself")
        {

        }

        public override int Solution(int[] input)
        {
            var max = input[0];
            var maxCount = 1;
            for (int i = 1; i < input.Length; i++)
            {
                var item = input[i];
                if (item > max)
                {
                    max = item;
                    maxCount = 1;
                }
                else if (item == max)
                {
                    maxCount++;
                }
            }

            return input.Length - maxCount;
        }

        public override void TestCases()
        {
            AddTestCase(new[] { 1, 2, 5, 6, 6, 6 }, 3);
            AddTestCase(new[] { 4, 6, -5, 9, 10, 4 }, 5);
            AddTestCase(new[] { -1, -2, -5, -6 }, 3);
            AddTestCase(new[] { 6, 6, 6, 6, 6, 6 }, 0);
            AddTestCase(new[] { 6, 6, 5, 6, 6, 6 }, 1);
        }
    }
}
