using System.Threading;
using Better.RandomDataGenerator;
using Xunit;

namespace PerformanceTestHelper.Tests
{
    public class MeasuringServiceTestsShould
    {
        [Fact]
        public void TakeAnActionAsInput()
        {
            MeasuringService.Measure(() => Thread.Sleep(RandomDataGenerator.IntGenerator.GetRandomNumberInRange(1, 2000)));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(100)]
        [InlineData(2000)]
        [InlineData(10000)]
        public void ReturnAValidMeasurement(int delay)
        {
            var result = MeasuringService.Measure(() => Thread.Sleep(delay));
            Assert.InRange(result.TotalMilliseconds, (delay - 20), (delay + 20));
        }

        //TODO - unit of measuring
    }
}
