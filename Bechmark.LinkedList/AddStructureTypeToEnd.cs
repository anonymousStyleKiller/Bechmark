// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


// BenchmarkRunner.Run<AddStructureTypeToEnd>();

[MemoryDiagnoser]
public class AddStructureTypeToEnd
{
    [Params(1000, 10_000)] public int Size;
    
    [Benchmark(Baseline = true)]
    public void ListFill()
    {
        var list = new List<int>();
        for (var i = 0; i < Size; i++)
        {
            list.Add(i);
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