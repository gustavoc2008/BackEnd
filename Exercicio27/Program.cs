int qntdVezes = 0;
int contador = 1;
int numeroEscolhido;

Console.WriteLine("Qual a quantidade de numeros que voce deseja digitar?");
qntdVezes = int.Parse(Console.ReadLine());

while (contador <= qntdVezes)
{
    Console.WriteLine($"Digite o {contador}ª numero");
    numeroEscolhido = int.Parse(Console.ReadLine());

    if (numeroEscolhido % 2 == 0)
    {
        Console.WriteLine($"Numero Par: {numeroEscolhido}");
    }
    contador++;
}