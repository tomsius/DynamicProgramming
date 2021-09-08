using BenchmarkDotNet.Attributes;

namespace AllConstruct
{
    [MemoryDiagnoser]
    public class AllConstructBenchmark
    {
        [Benchmark(Baseline = true)]
        public void LazyRec()
        {
            AllConstructLazy.AllConstruct(new string('a', 24) + "z", new string[] { "a", "aa", "aaa", "aaaa", "aaaaa" });
        }

        [Benchmark]
        public void LazyRecStringBuilder()
        {
            AllConstructLazy.AllConstructStringBuilder(new string('a', 24) + "z", new string[] { "a", "aa", "aaa", "aaaa", "aaaaa" });
        }

        [Benchmark]
        public void MemoRecDictionary()
        {
            AllConstructMemoization.AllConstruct(new string('a', 24) + "z", new string[] { "a", "aa", "aaa", "aaaa", "aaaaa" });
        }
    }
}