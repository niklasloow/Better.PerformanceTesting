using PerformanceTest.JsonVsJson.Interfaces;
using PerformanceTestHelper.Tests;
using System.Collections.Generic;
using System.Linq;

namespace PerformanceTest.JsonVsJson.TestCases
{
    class ToListCountVsCount : ITestCases
    {
     public IEnumerable<TestCase> GetTestCases()
     {

         return new List<TestCase>
         {
             new TestCase()
             {
                 NumberOfIterationsOfTest = 100000,
                 Action = () => Enumerable.Repeat(new SimpleClass(), 100000).Count(),
                 Name = "With out Tolist"
             },
             new TestCase()
             {
                 NumberOfIterationsOfTest = 100000,
                 Action = () => Enumerable.Repeat(new SimpleClass(), 100000).ToList(),
                 Name = "With tolist"
             }
         };
     }
    }
}
