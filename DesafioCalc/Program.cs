int numeroEscolhido1;
int numeroEscolhido2;
int total;

Console.WriteLine("Digite o primeiro numero");
numeroEscolhido1 = int.Parse (Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
numeroEscolhido2 = int.Parse(Console.ReadLine());

Console.Clear();

total = numeroEscolhido1 + numeroEscolhido2;

Console.WriteLine($"Resultado de {numeroEscolhido1} + {numeroEscolhido2} e {total}");
