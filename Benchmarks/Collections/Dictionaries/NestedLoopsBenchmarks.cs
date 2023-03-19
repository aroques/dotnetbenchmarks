using BenchmarkDotNet.Attributes;
using Benchmarks.Util.Extensions;
using Benchmarks.Util.Factories;
using Benchmarks.Util.Models;

namespace Benchmarks.Collections.Dictionaries
{
    [MemoryDiagnoser]
    public class NestedLoopsBenchmarks
    {
        [Params(25, 50, 75, 100)]
        public int NumElements { get; set; }

        private List<DataModel> _outerList = new();
        private List<DataModel> _innerList = new();

        [GlobalSetup]
        public void GlobalSetup()
        {
            var dataModels = DataModelFactory.GetDataModels(NumElements);
            _outerList = dataModels.Randomize().ToList();
            _innerList = dataModels.Randomize().ToList();
        }

        /// <summary>
        /// Algorithmic complexity is O(n^2): 
        /// Looping through an n sized inner loop n times.
        /// </summary>
        [Benchmark(Baseline = true)]
        public void NestedLoops()
        {
            var matches = new List<DataModel>(_innerList.Count);
            foreach (var outer in _outerList)
            {
                foreach (var inner in _innerList)
                {
                    if (outer.Id != inner.Id)
                    {
                        continue;
                    }
                    matches.Add(inner);
                }
            }
        }

        /// <summary>
        /// Algorithmic complexity is roughly O(2n):
        /// n to build the dictionary, plus n to loop through the outer loop.
        /// </summary>
        [Benchmark]
        public void InnerLoopDictionaryLookup()
        {
            var matches = new List<DataModel>(_innerList.Count);
            var innerDictionary = _innerList.ToDictionary(i => i.Id, i => i);    
            foreach (var outer in _outerList)
            {
                if (!innerDictionary.TryGetValue(outer.Id, out var match))
                {
                    continue;
                }
                matches.Add(match);
            }
        }
    }
}