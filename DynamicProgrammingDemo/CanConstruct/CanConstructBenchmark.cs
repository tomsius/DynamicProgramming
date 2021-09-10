using BenchmarkDotNet.Attributes;

namespace CanConstruct
{
    [MemoryDiagnoser]
    public class CanConstructBenchmark
    {
        [Benchmark(Baseline = true)]
        public void LazyRec()
        {
            CanConstructLazy.CanConstruct(new string('e', 24) + "f", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" });
        }

        [Benchmark]
        public void LazyRecStringBuilder()
        {
            CanConstructLazy.CanConstructStringBuilder(new string('e', 24) + "f", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" });
        }

        [Benchmark]
        public void MemoRecDictionary()
        {
            CanConstructMemoization.CanConstruct(new string('e', 24) + "f", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" });
        }

        [Benchmark]
        public void Tabulation()
        {
            CanConstructTabulation.CanConstruct(new string('e', 24) + "f", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" });
        }
    }
}