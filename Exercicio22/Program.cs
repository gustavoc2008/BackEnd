Console.WriteLine("Numeros Impares de 1 a 50");

for (int i = 1; i < 50; i += 2)
{
    Console.WriteLine($"Numeros Impares {i}");
    Thread.Sleep(500);
}

Console.WriteLine();
Console.WriteLine("Numeros Pares de 0 a 50");
for (int i = 0; i <= 50; i += 2)
{
    Console.WriteLine($"Numeros Pares {i}");
    Thread.Sleep(500);
}