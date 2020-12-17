namespace PerformanceTestHelper.Tests
{
    public class TestCaseResult
    {
        public double AverageRunTimePerIteration { get; set; }
        public double TotalRunTime { get; set; }
        public int NumberOfIterationsOfTest { get; set; }
        public string TestCaseName { get; set; }
    }
}