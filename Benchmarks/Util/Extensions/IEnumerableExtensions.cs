namespace Benchmarks.Util.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            Random random = new();
            return source.OrderBy(x => random.Next());
        }
    }
}