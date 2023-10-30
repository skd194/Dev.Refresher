namespace Preparation.BasicProblems
{
    internal class OddOneInPair : Problem<int[], int>
    {
        public OddOneInPair() 
            : base("Given N array elements, every elements repeats twice except one number, find the unique number?")
        {
        }

        public override int Solution(int[] input)
        {
            var xor = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                xor ^= input[i];
            }

            return xor;
        }

        public override void TestCases()
        {
            AddTestCase(input: new[] { 1, 2, 3, 2, 1 }, expectedOutput: 3);
            AddTestCase(new[] { 1, 2, 4, 2, 1 }, 4);
            AddTestCase(new[] { 4, 6, 6, 3, 3, 5, 5 }, 4);
        }
    }
}
