``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1586 (21H2)
Intel Core i5-4570 CPU 3.20GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|        Method |       Mean |   Error |  StdDev | Ratio | CacheMisses/Op | BranchMispredictions/Op | LLCMisses/Op | Allocated |
|-------------- |-----------:|--------:|--------:|------:|---------------:|------------------------:|-------------:|----------:|
|       ListSum |   710.1 μs | 2.55 μs | 2.26 μs |  1.00 |            116 |                     107 |          119 |      40 B |
| LinkedListSum | 1,088.2 μs | 4.30 μs | 4.02 μs |  1.53 |          2,812 |                     181 |        2,850 |      49 B |
