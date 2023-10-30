using System.Collections.Generic;

namespace Preparation
{
    public abstract class Problem<TInput, TOutput> : IProblem
        where TOutput : struct
    {
        private readonly ICollection<TestCase<TInput, TOutput>> _testCases;

        public Problem(string question)
        {
            Question = question;
            _testCases = new List<TestCase<TInput, TOutput>>();
        }

        public string Question { get; }

        public abstract TOutput Solution(TInput input);

        public IEnumerable<string> RunTestCases()
        {
            TestCases();
            var i = 0;
            foreach(var testCase in _testCases)
            {
                i++;
                var actualOutput = Solution(testCase.Input);
                if (testCase.ExpectedOutput.Equals(actualOutput))
                {
                    continue;
                }
                yield return $"     > Test case {testCase.Name}({i}) failed " +
                    $"> Expected Output : {testCase.ExpectedOutput}, Actual Output : {actualOutput}";
            }
        }

        public void AddTestCase(TInput input, TOutput expectedOutput)
        {
            _testCases.Add(new TestCase<TInput, TOutput>(input, expectedOutput));
        }

        public void AddTestCase(string name, TInput input, TOutput expectedOutput)
        {
            _testCases.Add(new TestCase<TInput, TOutput>(name, input, expectedOutput));
        }

        public abstract void TestCases();
    }
}
