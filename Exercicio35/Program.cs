int qntdVezes = 0;
int contador = 1;
int n1, n2;

Console.WriteLine("Digite quantas vezes voce deseja repetir");
qntdVezes = int.Parse(Console.ReadLine());

while (contador <= qntdVezes)
{
    Console.WriteLine("Digite um numero");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite segundo numero");
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"O maior numero eh: {n1}");
    }

    else if (n1 < n2)
    {
        Console.WriteLine($"O maior numero eh: {n2}");    }

    else
    {
        Console.WriteLine("Os numeros sao iguais");
    }
    contador++;
}