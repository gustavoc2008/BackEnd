float n1, n2, n3, n4;
float media;

Console.WriteLine("Digite a primeira nota do aluno");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota do aluno");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota do aluno");
n3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota do aluno");
n4 = float.Parse(Console.ReadLine());

media = (n1 + n2 + n3 + n4) / 4;

Console.Clear();

if (media >= 7)
    Console.WriteLine("PARABENS voce foi aprovado: " + media);
else if (media >= 5)
{
    Console.WriteLine("Voce esta em recuperacao: " + media);
}
else
{
    Console.WriteLine("Que pena voce esta reprovado: " + media);
}
