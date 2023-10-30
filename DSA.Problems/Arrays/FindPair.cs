namespace Preparation.Arrays
{
    internal class FindPair : Problem<(int[] Array, int K), bool>
    {
        public FindPair()
            : base("Check if there exist a pair (i, j) such that (ar[i] + ar[]=k) and (i != j).")
        {

        }

        public override bool Solution((int[] Array, int K) input)
        {
            var array = input.Array;
            var n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if(array[i] + array[j] == input.K)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override void TestCases()
        {
            AddTestCase((new[] { 1, 2, 5, 6, 6, 6 }, 7), true);
            AddTestCase((new[] { 1, 2, 5, 6, 6, 6 }, 8), true);
            AddTestCase((new[] { 1, 2, 5, 6, 6, 6 }, 4), false);
            AddTestCase((new[] { 1, 2, 5, 6, 6, 4 }, 4), false);
            AddTestCase((new[] { 1, 2 }, 3), true);
        }
    }
}
