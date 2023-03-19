using BenchmarkDotNet.Attributes;

namespace Benchmarks.Collections.Lists
{
    [MemoryDiagnoser]
    public class ListAppendBenchmarks
    {
        [Params(10, 100, 1000)]
        public int NumElements { get; set; }

        [Benchmark(Baseline = true)]
        public void AppendToList()
        {
            var list = new List<int>();
            for (var i = 0; i < NumElements; i++)
            {
                list.Add(i);
            }
        }

        [Benchmark]
        public void AppendToLinkedList()
        {
            var linkedList = new LinkedList<int>();
            for (var i = 0; i < NumElements; i++)
            {
                linkedList.AddLast(i);
            }
        }
    }
}