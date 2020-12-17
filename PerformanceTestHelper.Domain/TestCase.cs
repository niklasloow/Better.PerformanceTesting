using System;

namespace PerformanceTestHelper.Tests
{
    public class TestCase
    {
        public TestCase(Action action, string name = default, int numberOfIterationsOfTest = 1)
        {
            Action = action;
            NumberOfIterationsOfTest = numberOfIterationsOfTest;
            Name = name;
        }

        public TestCase()
        {
            
        }

        public string Name { get; set; }

        public int NumberOfIterationsOfTest { get; set; }

        public Action Action { get; set; }
    }
}