

Console.WriteLine("Subindo:");
for (int t = 0; t < 5; t++)
{
    Console.WriteLine($"Valor do t: {t}");
    Thread.Sleep(1000);
}

Console.WriteLine("Descendo:");
for (int t = 5; t >= 0; t--)
{
    Console.WriteLine($"Valor do t: {t}");
    Thread.Sleep(1000);
}

//==================================================

Console.WriteLine();
Console.WriteLine($"For com variaveis de inicio e fim");

int inicio = 0, fim = 6;
for (int i = inicio; i == fim; i++)
{
    Console.WriteLine($"Valor do i: {i}");
}

