int salario;
int gasto;

Console.WriteLine("Informe seu salario");
salario = int.Parse(Console.ReadLine());

Console.WriteLine("Informe seu gasto total");
gasto = int.Parse(Console.ReadLine());

if (gasto <= salario)
{
    Console.WriteLine("Gastos dentro do orcamento:");
    Console.WriteLine();
    Console.WriteLine($"O seu salario eh R${salario} e o seu gasto eh R${gasto}, entao esta dentro do seu orcamento");
}
else
{
    Console.WriteLine("Orcamento Estourado:");
    Console.WriteLine();
    Console.WriteLine($"O seu salario eh R${salario} e o seu gasto eh R${gasto}, entao o seu orcamento esta estourado");
}



