using BenchmarkDotNet.Attributes;

namespace Sort.Benchmarks
{
    [MemoryDiagnoser]
    public class SortBenchmarks
    {

        private static int[] GetUnsorted(int lenght)
        {
            var array = new int[lenght];
            var random = new System.Random(lenght);
            var num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                num = random.Next(1, lenght);
                array[i] = num;
            }
            return array;
        }

        [Benchmark]
        public int[] InsertionSort() => new InsertionSort().Sort(GetUnsorted(1000));

        [Benchmark]
        public int[] BubbleSort() => new BubbleSort().Sort(GetUnsorted(1000));

        [Benchmark]
        public int[] MergeSort() => new BottomUpMergeSort().Sort(GetUnsorted(1000));
    }
}
