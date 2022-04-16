``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1586 (21H2)
Intel Core i5-4570 CPU 3.20GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|         Method |  Size |        Mean |     Error |    StdDev | Ratio |   Gen 0 |   Gen 1 | Allocated |
|--------------- |------ |------------:|----------:|----------:|------:|--------:|--------:|----------:|
|       **ListFill** |  **1000** |    **62.42 μs** |  **0.344 μs** |  **0.322 μs** |  **1.00** |  **2.5635** |       **-** |      **8 KB** |
| LinkedListFill |  1000 |    12.99 μs |  0.105 μs |  0.082 μs |  0.21 | 15.3046 |       - |     47 KB |
|                |       |             |           |           |       |         |         |           |
|       **ListFill** | **10000** | **4,990.87 μs** | **31.236 μs** | **27.690 μs** |  **1.00** | **39.0625** |       **-** |    **128 KB** |
| LinkedListFill | 10000 |   182.35 μs |  1.715 μs |  1.604 μs |  0.04 | 89.1113 | 40.5273 |    469 KB |
