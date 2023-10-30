namespace Preparation.BasicProblems
{
    internal class RepeatTwiceExceptTwo : Problem<int[], (int, int)>
    {
        public RepeatTwiceExceptTwo()
            : base("Every elemnt in the array repeats twice except two unique elements, Find the unique elements")
        {
        }

        public override (int, int) Solution(int[] input)
        {
            // xor complete elements
            // find first set bit positions
            // group the items into 2 categories with above found set bit in one and unset bit in another
            // xor each set independently

            var xor = Xor(input);
            var setBitIndex = FindFirstLsbSetBitIndex(xor);
            return GroupAndXor(input, setBitIndex);

        }

        private static (int, int) GroupAndXor(int[] input, int setBitIndex)
        {
            int set = 0, unset = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var item = input[i];
                if (((item >> setBitIndex) & 1) == 1) set ^= item;
                else unset ^= item;
            }
            return (set, unset);
        }

        private static int FindFirstLsbSetBitIndex(int value)
        {
            var index = -1;
            while (value > 0)
            {
                index++;
                if ((value & 1) == 1) return index;
                value >>= 1;
            }
            return index;
        }

        private static int Xor(int[] input)
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
            AddTestCase(new[] { 1, 2, 3, 4, 8, 3, 2, 1 }, (4, 8));
            AddTestCase(new[] { 1, 2 }, (1, 2));  
            AddTestCase(new[] { 25, 4, 8, 4, 8, 64, 2, 2 }, (25, 64));

            var N = 10;  
            for (int i = 0; i < N; i+= 2)
            {
                for (int j = 1; j <= i; j++)
                {
                    // do logic
                }
            }
        }
    }
}
