``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                    Method | NumElements |        Mean |     Error |    StdDev |      Median | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|-------------------------- |------------ |------------:|----------:|----------:|------------:|------:|--------:|-------:|----------:|------------:|
|               **NestedLoops** |          **25** |  **1,449.7 ns** |  **14.62 ns** |  **11.42 ns** |  **1,447.6 ns** |  **1.00** |    **0.00** | **0.1621** |     **256 B** |        **1.00** |
| InnerLoopDictionaryLookup |          25 |    912.3 ns |  14.05 ns |  11.73 ns |    910.5 ns |  0.63 |    0.01 | 0.7648 |    1200 B |        4.69 |
|                           |             |             |           |           |             |       |         |        |           |             |
|               **NestedLoops** |          **50** |  **6,339.7 ns** |  **56.81 ns** |  **44.35 ns** |  **6,327.4 ns** |  **1.00** |    **0.00** | **0.2899** |     **456 B** |        **1.00** |
| InnerLoopDictionaryLookup |          50 |  1,747.5 ns |  34.87 ns |  92.47 ns |  1,699.4 ns |  0.28 |    0.02 | 1.4267 |    2240 B |        4.91 |
|                           |             |             |           |           |             |       |         |        |           |             |
|               **NestedLoops** |          **75** | **12,977.9 ns** | **103.19 ns** |  **96.52 ns** | **12,993.0 ns** |  **1.00** |    **0.00** | **0.4120** |     **656 B** |        **1.00** |
| InnerLoopDictionaryLookup |          75 |  2,463.4 ns |  20.85 ns |  17.41 ns |  2,464.3 ns |  0.19 |    0.00 | 2.0866 |    3280 B |        5.00 |
|                           |             |             |           |           |             |       |         |        |           |             |
|               **NestedLoops** |         **100** | **22,036.7 ns** | **228.31 ns** | **213.56 ns** | **21,997.6 ns** |  **1.00** |    **0.00** | **0.5188** |     **856 B** |        **1.00** |
| InnerLoopDictionaryLookup |         100 |  3,232.0 ns |  32.14 ns |  28.49 ns |  3,237.6 ns |  0.15 |    0.00 | 2.5368 |    3984 B |        4.65 |
