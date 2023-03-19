``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                    Method | NumElements |       Mean |     Error |   StdDev |     Median | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|-------------------------- |------------ |-----------:|----------:|---------:|-----------:|------:|--------:|-------:|----------:|------------:|
|               **NestedLoops** |          **10** |   **238.6 ns** |   **4.79 ns** |  **6.56 ns** |   **236.4 ns** |  **1.00** |    **0.00** | **0.0610** |      **96 B** |        **1.00** |
| InnerLoopDictionaryLookup |          10 |   305.7 ns |   7.44 ns | 20.75 ns |   295.3 ns |  1.32 |    0.11 | 0.2856 |     448 B |        4.67 |
|                           |             |            |           |          |            |       |         |        |           |             |
|               **NestedLoops** |          **20** | **1,121.1 ns** |  **13.39 ns** | **11.87 ns** | **1,122.9 ns** |  **1.00** |    **0.00** | **0.0858** |     **136 B** |        **1.00** |
| InnerLoopDictionaryLookup |          20 |   497.9 ns |   5.00 ns |  4.68 ns |   498.7 ns |  0.44 |    0.01 | 0.4635 |     728 B |        5.35 |
|                           |             |            |           |          |            |       |         |        |           |             |
|               **NestedLoops** |          **30** | **2,315.7 ns** |  **27.42 ns** | **25.64 ns** | **2,323.5 ns** |  **1.00** |    **0.00** | **0.1106** |     **176 B** |        **1.00** |
| InnerLoopDictionaryLookup |          30 |   721.7 ns |  10.97 ns |  9.72 ns |   725.3 ns |  0.31 |    0.01 | 0.6676 |    1048 B |        5.95 |
|                           |             |            |           |          |            |       |         |        |           |             |
|               **NestedLoops** |          **40** | **3,981.2 ns** |  **42.70 ns** | **39.94 ns** | **3,996.7 ns** |  **1.00** |    **0.00** | **0.1373** |     **216 B** |        **1.00** |
| InnerLoopDictionaryLookup |          40 |   929.8 ns |  10.51 ns |  9.84 ns |   931.0 ns |  0.23 |    0.00 | 0.8202 |    1288 B |        5.96 |
|                           |             |            |           |          |            |       |         |        |           |             |
|               **NestedLoops** |          **50** | **5,901.2 ns** | **106.59 ns** | **94.49 ns** | **5,900.9 ns** |  **1.00** |    **0.00** | **0.1602** |     **256 B** |        **1.00** |
| InnerLoopDictionaryLookup |          50 | 1,133.8 ns |  13.42 ns | 12.56 ns | 1,134.8 ns |  0.19 |    0.00 | 0.9995 |    1568 B |        6.12 |
