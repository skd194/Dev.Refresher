using System.Collections.Generic;

namespace Preparation.Problem
{
    public abstract class CollectionProblem<TInput, TOutput> : IProblem
           where TOutput : struct
    {
        private readonly ICollection<TestCase<TInput, IEnumerable<TOutput>>> _testCases;

        public CollectionProblem(string question)
        {
            Question = question;
            _testCases = new List<TestCase<TInput, IEnumerable<TOutput>>>();
        }

        public string Question { get; }

        public abstract IEnumerable<TOutput> Solution(TInput input);

        public IEnumerable<string> RunTestCases()
        {
            TestCases();
            var i = 0;
            foreach (var testCase in _testCases)
            {
                i++;
                var actualOutput = Solution(testCase.Input);
                if (testCase.ExpectedOutput.IsEquals(actualOutput))
                {
                    continue;
                }
                yield return $"     > Test case {testCase.Name}({i}) failed " +
                    $"> Expected Output : {ArrayString(testCase.ExpectedOutput)}, Actual Output : {ArrayString(actualOutput)}";
            }
        }

        private static string ArrayString<T>(IEnumerable<T> items)
            where T : struct
        {
            return $"[ {string.Join(",", items)} ]";
        }

        public void AddTestCase(TInput input, IEnumerable<TOutput> expectedOutput)
        {
            _testCases.Add(new TestCase<TInput, IEnumerable<TOutput>>(input, expectedOutput));
        }

        public void AddTestCase(string name, TInput input, IEnumerable<TOutput> expectedOutput)
        {
            _testCases.Add(new TestCase<TInput, IEnumerable<TOutput>>(name, input, expectedOutput));
        }

        public abstract void TestCases();
    }
}
