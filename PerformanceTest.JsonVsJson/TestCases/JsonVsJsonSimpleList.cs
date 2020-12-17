using PerformanceTest.JsonVsJson.Interfaces;
using PerformanceTestHelper.Tests;
using System.Collections.Generic;
using System.Linq;

namespace PerformanceTest.JsonVsJson.TestCases
{
    public class JsonVsJsonSimpleList : ITestCases
    {
        public IEnumerable<TestCase> GetTestCases()
        {
            return new List<TestCase>()
            {
                new TestCase
                {
                    Action = () => Newtonsoft.Json.JsonConvert.SerializeObject(Enumerable.Repeat(new SimpleClass(), 1000)),
                    Name = "3. Simple list with Newton",
                    NumberOfIterationsOfTest = 10000
                },
                new TestCase
                {
                    Action = () => System.Text.Json.JsonSerializer.Serialize(Enumerable.Repeat(new SimpleClass(), 1000)),
                    Name = "4. Simple list with System",
                    NumberOfIterationsOfTest = 10000
                }
            };
        }
    }
}
