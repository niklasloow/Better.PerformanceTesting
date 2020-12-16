using Better.RandomDataGenerator;
using Xunit;

namespace PerformanceTestHelper.Tests
{
    public class TestCaseResultTestsShould
    {
        [Fact]
        public void Have_AverageRunTimePerIteration_Property()
        {
            var testCaseResult = new TestCaseResult()
            {
                AverageRunTimePerIteration = RandomDataGenerator.IntGenerator.GetRandomNumberInRange(1, 2000)
            };
        }

        [Fact]
        public void Have_NumberOfIterations_Property()
        {
            var testCaseResult = new TestCaseResult()
            {
                NumberOfIterationsOfTest = RandomDataGenerator.IntGenerator.GetRandomNumberInRange(1, 2000)
            };
        }

        [Fact]
        public void Have_TestCaseName_Property()
        {
            var testCaseResult = new TestCaseResult()
            {
                TestCaseName = RandomDataGenerator.StringGenerator.GetRandomString(),
            };
        }

        
    }
}
