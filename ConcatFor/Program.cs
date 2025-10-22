int qntdLetras;
string nome = "";

Console.WriteLine("Quantas letras tem o seu nome?");
qntdLetras = int.Parse(Console.ReadLine());

for (int i = 1; i <= qntdLetras; i++)
{
    Console.WriteLine($"Qual e a {i}ª letra?");
    nome = nome + Console.ReadLine();
}

Console.WriteLine($"Seu nome e: {nome}");


