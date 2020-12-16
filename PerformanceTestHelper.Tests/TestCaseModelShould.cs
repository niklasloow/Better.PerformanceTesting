using System.Threading;
using Better.RandomDataGenerator;
using Xunit;

namespace PerformanceTestHelper.Tests
{
    public class TestCaseModelShould
    {

        [Fact]
        public void HaveTestCaseProperty()
        {
            var testCase = new TestCase(() => Thread.Sleep(1000));
        }

        [Fact]
        public void HaveTimesOfExecutionProperty()
        {
            var testCase = new TestCase(() => Thread.Sleep(1000), numberOfIterationsOfTest: RandomDataGenerator.IntGenerator.GetRandomNumberInRange(1, 20));
        }

        [Fact]
        public void HaveCaseNameProperty()
        {
            var testCase = new TestCase(() => Thread.Sleep(1000), name: RandomDataGenerator.StringGenerator.GetRandomShortString());
        }
        
    }
}
