using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;

// BenchmarkRunner.Run<EnumerateBenchmark>(DefaultConfig.Instance
//                                             .AddHardwareCounters(HardwareCounter.CacheMisses, HardwareCounter.BranchMispredictions, HardwareCounter.LlcMisses));


[MemoryDiagnoser]
public class EnumerateBenchmark
{
    private readonly List<long> _list;
    private readonly LinkedList<long> _linkedList;

    public EnumerateBenchmark()
    {
        _list = new List<long>(Enumerable.Range(0, 100_000).Select(x=>(long)x));
        _linkedList = new LinkedList<long>(_list);
    }

    [Benchmark(Baseline = true)]
    public long ListSum() => _list.Sum();

    [Benchmark]
    public long LinkedListSum() => _linkedList.Sum();

}