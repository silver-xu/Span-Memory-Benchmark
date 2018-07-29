using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Threading.Tasks;

namespace SpanSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Benchmarks>();
        }
    }

    [CoreJob]
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class Benchmarks
    {
        [Benchmark]
        public void TestSpanSlice()
        {
            var chars = GetRandomString().AsSpan();

            int startIndex = new Random().Next(chars.Length - 1);
            for (int i = 0; i < 1000; i++)
            {
                var sliced = chars.Slice(startIndex);
            }
        }

        [Benchmark]
        public void TestSubString()
        {
            var str = GetRandomString();

            int startIndex = new Random().Next(str.Length - 1);
            for (int i = 0; i < 1000; i++)
            {
                var substring = str.Substring(startIndex);
            }
        }

        [Benchmark]
        public void TestMemorySlice()
        {
            var chars = GetRandomString().AsMemory();

            int startIndex = new Random().Next(chars.Length - 1);
            for (int i = 0; i < 1000; i++)
            {
                var sliced = chars.Slice(startIndex);
            }
        }

        private string GetRandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[256];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString;
        }
    }


}
