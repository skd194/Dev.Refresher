namespace Preparation.BasicProblems
{
    internal class IsPrime : Problem<int, bool>
    {
        public IsPrime()
            : base("Find a number is prime or not?")
        {
        }

        public override bool Solution(int input)
        {
            if (input <= 1) return false;

            for (int i = 2; i <= input / i; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public override void TestCases()
        {
            AddTestCase(1, false);
            AddTestCase(2, true);
            AddTestCase(100, false);
            AddTestCase(13, true);
            AddTestCase(0, false);
            AddTestCase(25, false);
        }
    }
}