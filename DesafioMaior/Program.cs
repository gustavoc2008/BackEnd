﻿int n1, n2;

Console.WriteLine("Digite o primeiro numero");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
    Console.WriteLine($"O maior numero e {n1}");
else if (n2 > n1)
{
    Console.WriteLine($"O maior numero e {n2}");
}
else
{
    Console.WriteLine("Os numeros sao iguais");
}