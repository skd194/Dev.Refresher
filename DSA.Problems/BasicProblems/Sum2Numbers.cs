namespace Preparation.BasicProblems
{
    public class Sum2Numbers : Problem<(int, int), int>
    {
        public Sum2Numbers()
            : base("Find the sum of 2 Numbers")
        {
        }

        public override int Solution((int, int) input)
        {
            return input.Item1 + input.Item2;
        }

        public override void TestCases()
        {
            AddTestCase((1, 2), 3);
            AddTestCase("Case Wrong Test", (2, 4), 6);
        }
    }
}
