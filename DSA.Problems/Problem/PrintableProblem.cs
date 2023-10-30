using System;
using System.Collections.Generic;

namespace Preparation.Problem
{
    public abstract class PrintableProblem<TInput> : IProblem
    {
        private readonly ICollection<TInput> _testCases;

        public PrintableProblem(string question)
        {
            Question = question;
            _testCases =  new List<TInput>();
        }

        public string Question { get; }

        public abstract void Solution(TInput input);

        public IEnumerable<string> RunTestCases()
        {
            TestCases();
            var i = 0;
            foreach (var input in _testCases)
            {
                i++;
                Console.WriteLine($"Output  for case-{i}");
                Solution(input);
            }
            return Array.Empty<string>();
        }

        public void AddTestCase(TInput input)
        {
            _testCases.Add(input);
        }

        public abstract void TestCases();
    }
}
