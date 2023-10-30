namespace Preparation
{
    public class TestCase<TInput, TOutput> 
    {
        public TestCase(TInput input, TOutput expectedOutput)
            : this(string.Empty, input, expectedOutput)
        {
        }

        public TestCase(string name, TInput input, TOutput expectedOutput)
        {
            Name = name;
            Input = input;
            ExpectedOutput = expectedOutput;
        }
        public string Name { get; }
        public TInput Input { get;  }
        public TOutput ExpectedOutput { get;  }
    }
}
