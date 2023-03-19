``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
| Method             | NumElements | Mean            | Error         | StdDev        | Ratio    | RatioSD  | Gen0       | Allocated  | Alloc Ratio |
|--------------------|-------------|-----------------|---------------|---------------|----------|----------|------------|------------|-------------|
| **AppendToList**   | **10**      | **89.36 ns**    | **2.531 ns**  | **7.054 ns**  | **1.00** | **0.00** | **0.1376** | **216 B**  | **1.00**    |
| AppendToLinkedList | 10          | 165.48 ns       | 2.749 ns      | 4.360 ns      | 1.80     | 0.12     | 0.3314     | 520 B      | 2.41        |
|                    |             |                 |               |               |          |          |            |            |             |
| **AppendToList**   | **100**     | **367.07 ns**   | **4.607 ns**  | **4.309 ns**  | **1.00** | **0.00** | **0.7548** | **1184 B** | **1.00**    |
| AppendToLinkedList | 100         | 1,529.49 ns     | 14.391 ns     | 12.017 ns     | 4.16     | 0.06     | 3.0861     | 4840 B     | 4.09        |
|                    |             |                 |               |               |          |          |            |            |             |
| **AppendToList**   | **1000**    | **2,681.71 ns** | **23.489 ns** | **21.971 ns** | **1.00** | **0.00** | **5.3596** | **8424 B** | **1.00**    |
| AppendToLinkedList | 1000        | 17,170.82 ns    | 121.698 ns    | 107.882 ns    | 6.40     | 0.06     | 30.6091    | 48040 B    | 5.70        |
