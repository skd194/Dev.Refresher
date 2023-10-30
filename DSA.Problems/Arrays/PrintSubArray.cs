using Preparation.Problem;

namespace Preparation.Arrays
{
    internal class PrintSubArray : PrintableProblem<int[]>
    {
        public PrintSubArray()
            : base("Print all the subarrays of an array")
        {

        }

        public override void Solution(int[] input)
        {
            input.PrintLine("Input >> ");
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    var subArray = new int[j - i + 1];
                    var m = 0;
                    for (int k = i; k <= j; k++)
                    {
                        subArray[m++] = input[k];
                    }
                    subArray.PrintLine();
                }
            }
        }

        public override void TestCases()
        {
            AddTestCase(new[] { 1, 2, 3});
            AddTestCase(new[] { 6, 7, 8, 3, 4, 9 });
            AddTestCase(new[] { 3 });
        }
    }
}
