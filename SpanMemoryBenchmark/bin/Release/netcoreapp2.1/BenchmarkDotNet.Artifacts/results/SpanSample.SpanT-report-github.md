``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.165 (1803/April2018Update/Redstone4)
Intel Core i7-6650U CPU 2.20GHz (Max: 2.21GHz) (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.302
  [Host] : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  Core   : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT

Job=Core  Runtime=Core  

```
|        Method |     Mean |     Error |    StdDev | Rank |
|-------------- |---------:|----------:|----------:|-----:|
|     TestSlice | 1.945 us | 0.0248 us | 0.0232 us |    1 |
| TestSubString | 2.020 us | 0.0403 us | 0.0673 us |    2 |
