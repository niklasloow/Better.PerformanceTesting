using System;
using System.Threading;
using Better.RandomDataGenerator;

namespace PerformanceTestHelper.Tests.Builders
{
    class TestCaseBuilder : IBuilder<TestCase>
    {
        private int _numberOfIteration;
        private string _name;
        private Action _action;

        public IBuilder<TestCase> WithNumberOfIterations(int numberOfIteration)
        {
            _numberOfIteration = numberOfIteration;
            return this;
        }
        public IBuilder<TestCase> WithName(string name)
        {
            _name = name;
            return this;
        }
        public IBuilder<TestCase> WithAction(Action action)
        {
            _action = action;
            return this;
        }

        public IBuilder<TestCase> Simple()
        {
            _name = RandomDataGenerator.StringGenerator.GetRandomTinyString();
            _numberOfIteration = RandomDataGenerator.IntGenerator.GetRandomNumberInRange(1, 10);
            _action = () => Thread.Sleep(1000);
            return this;
        }

        public IBuilder<TestCase> Typical()
        {
            Simple();
            return this;
        }

        public TestCase Build()
        {
            return new TestCase(_action, _name, _numberOfIteration);
        }
    }
}
