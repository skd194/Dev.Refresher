namespace Preparation.BasicProblems
{

    internal class CheckBit : Problem<(int n, int i), bool>
    {
        public CheckBit()
            : base("Check whether i-th bit is set or not?")
        {
        }

        public override bool Solution((int n, int i) input)
        {
            return IsBitSet(input);
        }

        public static bool IsBitSet((int n, int i) input)
        {
            return ((input.n >> input.i) & 1) == 1;
        }

        public override void TestCases()
        {
            AddTestCase(input: (4, 2), expectedOutput: true);
            AddTestCase(input: (25, 2), expectedOutput: false);
            AddTestCase(input: (25, 3), expectedOutput: true);
        }
    }
}
