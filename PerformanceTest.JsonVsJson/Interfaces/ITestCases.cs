using System.Collections.Generic;
using PerformanceTestHelper.Tests;

namespace PerformanceTest.JsonVsJson.Interfaces
{
    public interface ITestCases
    {
        IEnumerable<TestCase> GetTestCases();
    }
}