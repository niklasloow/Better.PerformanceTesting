using System.Threading;
using Xunit;

namespace PerformanceTestHelper.Tests
{
    public class PerformanceTesterShould
    {
        [Fact]
        public void TakeATestCaseAsInput()
        {
            var testCase = new TestCase(() => TestMethod());
            PerformanceTester.Run(testCase);
        }

        [Fact]
        public void ReturnAResult()
        {
            var testCase = new TestCase(() => TestMethod());
            var result = PerformanceTester.Run(testCase);
            
        }

        [Fact]
        public void ReturnCorrectResult()
        {
            var testCase = new TestCase(() => TestMethod());
            var result = PerformanceTester.Run(testCase);
        }


        public void TestMethod()
        {
            Thread.Sleep(1000);
        }
    }
}
