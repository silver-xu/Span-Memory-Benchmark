``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.165 (1803/April2018Update/Redstone4)
Intel Core i7-6650U CPU 2.20GHz (Max: 2.21GHz) (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.302
  [Host] : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  Core   : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT

Job=Core  Runtime=Core  

```
|          Method |      Mean |     Error |    StdDev | Rank |    Gen 0 | Allocated |
|---------------- |----------:|----------:|----------:|-----:|---------:|----------:|
|   TestSpanSlice |  9.735 us | 0.3273 us | 0.9652 us |    2 |   0.7782 |    1.6 KB |
|   TestSubString | 49.602 us | 1.9103 us | 5.5725 us |    3 | 135.7422 | 278.08 KB |
| TestMemorySlice |  9.114 us | 0.1819 us | 0.3326 us |    1 |   0.7782 |    1.6 KB |
