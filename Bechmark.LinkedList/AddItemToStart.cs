using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;

// BenchmarkRunner.Run<AddItemToStart>();
    
[MemoryDiagnoser]
public class AddItemToStart
{
    [Params(1000, 10_000)] public int Size;

    [Benchmark(Baseline = true)]
    public void ListFill()
    {
        var list = new List<int>();
        for (var i = 0; i < Size; i++)
        {
            list.Insert(0, i);
        }
    }

    [Benchmark]
    public void LinkedListFill()
    {
        var list = new LinkedList<int>();
        for (var i = 0; i < Size; i++)
        {
            list.AddLast(i);
        }
    }
}