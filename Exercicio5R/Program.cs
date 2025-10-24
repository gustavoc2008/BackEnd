float valorTotal;
float preco;

Console.WriteLine("Quantas macas voce comprou?");
int qntdMacas = int.Parse(Console.ReadLine());

if (qntdMacas < 12)
{
    preco = 0.30f;
}

else
{
    preco = 0.25f;
}

valorTotal = qntdMacas * preco;

Console.Clear();
Console.WriteLine("VALOR A PAGAR");
Console.WriteLine();
Console.WriteLine($"R${valorTotal}");

