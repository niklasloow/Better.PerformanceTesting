namespace PerformanceTestHelper.Tests.Builders
{
    internal interface IBuilder<T>
    {
        IBuilder<T> Simple();
        IBuilder<T> Typical();
        T Build();
    }
}