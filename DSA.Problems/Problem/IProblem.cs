using System.Collections.Generic;

namespace Preparation
{
    public interface IProblem 
    {
        public string Question { get; }
        IEnumerable<string> RunTestCases();
    }
}
