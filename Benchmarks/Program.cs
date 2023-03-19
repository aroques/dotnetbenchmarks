using BenchmarkDotNet.Running;
using Benchmarks.Collections.Dictionaries;

namespace Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<NestedLoopsBenchmarks>();
        }
    }
}