using BenchmarkDotNet.Attributes;

namespace CountConstruct
{
    [MemoryDiagnoser]
    public  class CountConstructBenchmark
    {
        [Benchmark(Baseline = true)]
        public void LazyRec()
        {
            CountConstructLazy.CountConstruct(new string('e', 24) + "f", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" });
        }

        [Benchmark]
        public void LazyRecStringBuilder()
        {
            CountConstructLazy.CountConstructStringBuilder(new string('e', 24) + "f", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" });
        }

        [Benchmark]
        public void MemoRecDictionary()
        {
            CountConstructMemoization.CountConstruct(new string('e', 24) + "f", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" });
        }
    }
}