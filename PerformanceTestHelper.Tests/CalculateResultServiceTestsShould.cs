using System.ComponentModel.DataAnnotations;
using Better.RandomDataGenerator;
using PerformanceTestHelper.Tests.Builders;
using Xunit;

namespace PerformanceTestHelper.Tests
{
    public class CalculateResultServiceTestsShould
    {
        [Fact]
        public void CalculateAverageRunTime()
        {
            var testCase = new TestCaseBuilder()
                .Typical()
                .Build();

            var timeSpan = RandomDataGenerator.TimeSpanGenerator.GetRandomTimeSpan();

            var avgRunTime = timeSpan.TotalMilliseconds / testCase.NumberOfIterationsOfTest;

            var sut = CalculateResultService.Calculate(timeSpan, testCase);

            Assert.Equal(avgRunTime, sut.AverageRunTimePerIteration);


        }

        [Fact]
        public void SetCorrectTotalTime()
        {
            var testCase = new TestCaseBuilder()
                .Typical()
                .Build();

            var timeSpan = RandomDataGenerator.TimeSpanGenerator.GetRandomTimeSpan();

            var sut = CalculateResultService.Calculate(timeSpan, testCase);

            Assert.Equal(timeSpan.TotalMilliseconds, sut.TotalRunTime);


        }
    }
}
