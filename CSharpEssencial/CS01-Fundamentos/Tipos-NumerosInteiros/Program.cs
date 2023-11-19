// TIPOS DE DADOS: INTEIROS

// declarando uma variável do tipo inteiro
byte idade = 18;
Console.WriteLine("Idade: " + idade);

// declarando variáveis na mesma linha
int a = 9, b = 2; // exemplo 1
Console.WriteLine($"{a} + {b} = {a + b}");

int x, y; // exemplo 2
x = 9; y = 2;
Console.WriteLine($"{x} + {y} = {x + y}");

Console.WriteLine("\nLimite dos números inteiros:");
Console.WriteLine($"sbyte: {sbyte.MinValue} à {sbyte.MaxValue}");
Console.WriteLine($"byte: {byte.MinValue} à {byte.MaxValue}");
Console.WriteLine($"ushort: {ushort.MinValue} à {ushort.MaxValue}");
Console.WriteLine($"short: {short.MinValue} à {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} à {int.MaxValue}");
Console.WriteLine($"uint: {uint.MinValue} à {uint.MaxValue}");
Console.WriteLine($"long: {long.MinValue} à {long.MaxValue}");
Console.WriteLine($"ulong: {ulong.MinValue} à {ulong.MaxValue}");
Console.WriteLine($"nint: {nint.MinValue} à {nint.MaxValue}");
Console.WriteLine($"nuint: {nuint.MinValue} à {nuint.MaxValue}");

Console.ReadKey();
