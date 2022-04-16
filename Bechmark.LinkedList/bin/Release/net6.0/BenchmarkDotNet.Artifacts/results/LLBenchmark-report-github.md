``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1586 (21H2)
Intel Core i5-4570 CPU 3.20GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|         Method |  Size |       Mean |     Error |    StdDev | Ratio | RatioSD |   Gen 0 |   Gen 1 | Allocated |
|--------------- |------ |-----------:|----------:|----------:|------:|--------:|--------:|--------:|----------:|
|       **ListFill** |  **1000** |   **2.603 μs** | **0.0400 μs** | **0.0374 μs** |  **1.00** |    **0.00** |  **2.6817** |       **-** |      **8 KB** |
| LinkedListFill |  1000 |  13.088 μs | 0.0952 μs | 0.0795 μs |  5.04 |    0.08 | 15.3046 |       - |     47 KB |
|                |       |            |           |           |       |         |         |         |           |
|       **ListFill** | **10000** |  **28.583 μs** | **0.1802 μs** | **0.1685 μs** |  **1.00** |    **0.00** | **41.6565** |       **-** |    **128 KB** |
| LinkedListFill | 10000 | 172.004 μs | 2.0103 μs | 1.8805 μs |  6.02 |    0.06 | 91.3086 | 41.5039 |    469 KB |
