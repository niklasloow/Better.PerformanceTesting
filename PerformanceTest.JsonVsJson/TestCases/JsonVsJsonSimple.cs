using PerformanceTest.JsonVsJson.Interfaces;
using PerformanceTestHelper.Tests;
using System.Collections.Generic;

namespace PerformanceTest.JsonVsJson.TestCases
{
    public class JsonVsJsonSimple : ITestCases
    {
        public IEnumerable<TestCase> GetTestCases()
        {
            return new List<TestCase>()
            {
                new TestCase
                {
                    Action = () => Newtonsoft.Json.JsonConvert.SerializeObject(new SimpleClass()),
                    Name = "Simple class with Newton",
                    NumberOfIterationsOfTest = 1000
                },
                new TestCase
                {
                    Action = () => System.Text.Json.JsonSerializer.Serialize(new SimpleClass()),
                    Name = "Simple class with System",
                    NumberOfIterationsOfTest = 1000
                }
            };
        }
    }
}
