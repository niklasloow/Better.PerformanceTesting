using System;
using System.Diagnostics;
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
            var result = MeasuringService.Measure(() => Thread.Sleep(1000));
            Assert.InRange(result.TotalMilliseconds, (delay - 10), (delay + 10));
        }

        //TODO - unit of measuring
    }

    public static class MeasuringService
    {
        public static TimeSpan Measure(Action action)
        {
            var stopwatch = Stopwatch.StartNew();
            action();
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}
