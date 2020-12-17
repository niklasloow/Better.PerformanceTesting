using Better.RandomDataGenerator;

namespace PerformanceTest.JsonVsJson
{
    public class SimpleClass
    {
        public string Property1 => RandomDataGenerator.StringGenerator.GetRandomShortString();
        public string Property2 => RandomDataGenerator.StringGenerator.GetRandomLargeString();
        public int Property3 => RandomDataGenerator.IntGenerator.GetRandomNumberInRange(1, 20000);
    }
}