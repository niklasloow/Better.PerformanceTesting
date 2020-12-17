namespace PerformanceTestHelper.Tests
{
    public static class PerformanceTester
    {
        public static TestCaseResult Run(TestCase testCase)
        {
            var runtime = MeasuringService.Measure(testCase.Action);
            var testCaseResult = CalculateResultService.Calculate(runtime, testCase);
            return testCaseResult;
        }
    }
}