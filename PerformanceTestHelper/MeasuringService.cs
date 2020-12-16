using System;
using System.Diagnostics;

namespace PerformanceTestHelper.Tests
{
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