using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<EnumerateBenchmark>();

[MemoryDiagnoser]
public class EnumerateBenchmark
{
    [Params(1000, 10_000)] public int Size;

    private readonly List<int> _list;
    private readonly LinkedList<int> _linkedList;

    public EnumerateBenchmark()
    {
        _list = new List<int>(Enumerable.Range(0, 100_000));
        _linkedList = new LinkedList<int>(_list);
    }

    [Benchmark(Baseline = true)]
    public long ListSum() => _list.Sum();
    
    [Benchmark]
    public long LinkedListSum() => _linkedList.Sum();

}