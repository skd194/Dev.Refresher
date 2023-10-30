using Preparation.Arrays;
using Preparation.BasicProblems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Preparation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var problems = new List<IProblem>
            {
                new FindEquilibriumIndexes(),
                new FindAllSubArraySum(),
                new MaxSubArraySumWithLengthK(),
                new SubArrayStartEndIndexOfLenK(),
                new RotateArrayRL(),
                new PrintSubArray(),
                new ReverseArray(),
                new FindPair(),
                new NonMaxElementsCount(),
                //Basic problems
                new RepeatTwiceExceptTwo(),
                new NoOfSetBits(),
                new CheckBit(),
                new OddOneInPair(),
                new FindPerfectSquareRoot(),
                new IsPrime(),
                new Sum2Numbers()
            };
            ProblemRunner.Run(problems);
        }

        internal class ProblemRunner
        {
            internal static void Run(List<IProblem> problems)
            {
                var i = 0;
                foreach (var problem in problems)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"{++i}, {problem.Question}");
                    string[] result ;
                    try
                    {
                        result = problem.RunTestCases()?.ToArray();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("######## Unhandled Exception: ----------------");
                        Console.WriteLine(e.ToString());
                        continue;
                    }
                    if (result.Length == 0)
                    {
                        Console.WriteLine("     - Test Cases ran successfully");
                        continue;
                    }
                    foreach (var item in result)
                    {
                        Console.WriteLine("    ERRORS......................");
                        Console.WriteLine(item);
                    }
                }
            }
        }

    }
}
