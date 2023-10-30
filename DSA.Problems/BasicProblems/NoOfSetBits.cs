namespace Preparation.BasicProblems
{
    internal class NoOfSetBits : Problem<int, int>
    {
        public NoOfSetBits()
            : base("Calculate number of set bits")
        {
        }

        public override int Solution(int n)
        {
            var count = 0;
            while (n > 0)
            {
                if ((n & 1) != 0) count++;
                n >>= 1;
            }
            return count;
        }

        public override void TestCases()
        {
            AddTestCase(input: 25, expectedOutput: 3);
            AddTestCase(input: 40, expectedOutput: 2);
            AddTestCase(input: 35, expectedOutput: 3);
            AddTestCase(input: 16, expectedOutput: 1);

        }
    }
}
