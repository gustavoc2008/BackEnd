int frequencia;
int media;
int n1, n2, n3, n4;

Console.WriteLine("Digite qual a frequencia do aluno");
frequencia = int.Parse(Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine($"REPROVADO POR FREQUENCIA");
}

else
{
    Console.WriteLine($"Digite qual a media do aluno");
    media = int.Parse(Console.ReadLine());

    if (media >= 7)
    {
        Console.WriteLine($"PARABENS, VOCE FOI APROVADO");
    }

    else if (media >= 3 && media < 7)
    {
        Console.WriteLine($"VOCE AINDA TEM UMA CHANCE, ESTA EM RECUPERACAO");
    }

    else
    {
        Console.WriteLine($"VOCE ESTA REPROVADO POR NOTA");
    }
}

Console.Clear();