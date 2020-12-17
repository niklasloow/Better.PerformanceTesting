using System;
using System.Collections.Generic;
using System.Linq;
using PerformanceTest.JsonVsJson.TestCases;
using PerformanceTestHelper.Tests;

namespace PerformanceTest.JsonVsJson
{
    class Program
    {
        //All test was ran in newtonsoft 12.0.3 and ASP.NET CORE 3.1
        //Baseline test it to verify that tests are repeatable and not giving a false result
        //TODO - Add an average offset between iterations, how many that are of by more than X% from average (Start with highest and lowest)
        //TODO - Clean up way of running test to make it more streamline and beautiful
        //TODO - Return issue with number of iterations

        static void Main(string[] args)
        {
            var testCases = new List<TestCase>();
            testCases.AddRange(new JsonVsJsonSimple().GetTestCases());
            testCases.AddRange(new JsonVsJsonSimpleList().GetTestCases());
            testCases.AddRange(new ToListCountVsCount().GetTestCases());
            var results = testCases.Select(PerformanceTester.Run);
            foreach (var result in results)
            {
                PrintTestCaseResult(result);
            }

         }

        private static void PrintTestCaseResult(TestCaseResult result)
        {
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(result.TestCaseName);
            Console.WriteLine($"Average test runtime {result.AverageRunTimePerIteration}ms");
            Console.WriteLine($"Total test runtime {result.TotalRunTime}ms");
            Console.WriteLine($"Number of time test was ran: {result.NumberOfIterationsOfTest}");
        }
    }
}
