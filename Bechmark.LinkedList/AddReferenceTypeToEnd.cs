using Bechmark.LinkedList;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Wintellect.PowerCollections;

BenchmarkRunner.Run<AddReferenceTypeToEnd>();

namespace Bechmark.LinkedList
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    [MemoryDiagnoser]
    public class AddReferenceTypeToEnd
    {
        [Params(1000, 10_000)] public int Size;
    
        [Benchmark(Baseline = true)]
        public void ListFill()
        {
            var list = new List<Person>();
            for (var i = 0; i < Size; i++)
            {
                list.Add(new Person
                {
                    Name = new string('p', 100),
                    Surname = new string('s', 200),
                });
            }
        }
    
        [Benchmark]
        public void LinkedListFill()
        {
            var list = new LinkedList<Person>();
            for (var i = 0; i < Size; i++)
            {
                list.AddLast(new Person
                {
                    Name = new string('p', 100),
                    Surname = new string('s', 200),
                });
            }
        }
        
        [Benchmark]
        public void BigListFill()
        {
            var list = new BigList<Person>();
            for (var i = 0; i < Size; i++)
            {
                list.Add(new Person
                {
                    Name = new string('p', 100),
                    Surname = new string('s', 200),
                });
            }
        }
    }
}