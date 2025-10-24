int senha;
int senhaCorreta = 1234;

Console.WriteLine("Digite a senha:");
senha = int.Parse(Console.ReadLine());

Console.Clear();

if (senha == senhaCorreta)
{
    Console.WriteLine("ACESSO PERMITIDO");
    Console.WriteLine();
    Console.WriteLine("Pasta Familia");
    Console.WriteLine("Pasta Foto com Anoes");
}

else
{
    Console.WriteLine("ACESSO NEGADO");
    return;
}