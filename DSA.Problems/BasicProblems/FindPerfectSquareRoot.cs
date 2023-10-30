using System;

namespace Preparation.BasicProblems
{
    internal class FindPerfectSquareRoot: Problem<int, int>
    {
        public FindPerfectSquareRoot()
            : base("Find Square root of a positive perfect square numbers? - O(logN)")
        {

        }

        public override int Solution(int input)
        {
            if (input == 0 || input == 1) return input;

            var lowerBound = 1;
            var upperBound = input;

            while (lowerBound < upperBound)
            {
                var mid = (lowerBound + upperBound) / 2;
                if (mid > input / mid) upperBound = mid - 1;
                else if (mid < input / mid) lowerBound = mid + 1;
                else lowerBound = upperBound = mid;
            }
            return lowerBound;
        }

        public override void TestCases()
        {
            AddTestCase(100, 10);
            AddTestCase(25, 5);
            AddTestCase(9, 3);
            AddTestCase(16, 4);
            AddTestCase(1, 1);
            AddTestCase(1, 1);
        }
    }
}