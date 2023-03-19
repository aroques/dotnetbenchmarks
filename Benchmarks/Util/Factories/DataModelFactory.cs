using Benchmarks.Util.Models;

namespace Benchmarks.Util.Factories
{
    public static class DataModelFactory
    {
        public static IEnumerable<DataModel> GetDataModels(int num)
        {
            foreach (var id in Enumerable.Range(1, num))
            {
                yield return new DataModel
                {
                    Id = id
                };
            }
        }
    }
}
