using System;

namespace PerformanceTestHelper.Tests
{
    public static class CalculateResultService
    {
        public static TestCaseResult Calculate(TimeSpan result, TestCase testCase)
        {
            return new TestCaseResult
            {
                AverageRunTimePerIteration = result.TotalMilliseconds / testCase.NumberOfIterationsOfTest,
                NumberOfIterationsOfTest = testCase.NumberOfIterationsOfTest,
                TotalRunTime = result.TotalMilliseconds,
                TestCaseName = testCase.Name
            };
        }
    }
}