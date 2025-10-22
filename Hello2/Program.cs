string nome;
string sobrenome;
int idade;
float saldoBancario;
float investimentos;

Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome");
sobrenome = Console.ReadLine();

Console.WriteLine("Digite sua idade");
idade = int.Parse( Console.ReadLine() );

Console.WriteLine("Digite seu saldo bancario");
saldoBancario = float.Parse( Console.ReadLine() );

Console.WriteLine("Digite seu investimento do mes");
investimentos = float.Parse( Console.ReadLine() );

Console.Clear();
Console.WriteLine($"Nome: {nome} {sobrenome}");
Console.WriteLine($"Idade do {nome} é {idade}");
Console.WriteLine($"Saldo: R$ {saldoBancario}");
Console.WriteLine($"Investimento: R$ {investimentos}");

