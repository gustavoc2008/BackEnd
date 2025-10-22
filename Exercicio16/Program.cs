double salario, salarioNovo;
string cargo;

Console.WriteLine("Ola, seja bem vindo(a) ao site da DevConnect, qual seria o seu cargo dentro da empresa?");
cargo = Console.ReadLine();

Console.WriteLine("E qual seria o seu salario?");
salario = double.Parse(Console.ReadLine());

if (cargo == "Producao")
{
    salarioNovo = salario + (salario * 0.065);
    Console.WriteLine($"O seu novo salario é R${salarioNovo}");
    Console.Clear();
}

else if (cargo == "Administracao")
{
    salarioNovo = salario + (salario * 0.075);
    Console.WriteLine($"O seu novo salario é R${salarioNovo}");
    Console.Clear();
}

else if (cargo == "Diretoria")
{
    salarioNovo = salario + (salario * 0.12);
    Console.WriteLine($"O seu novo salario é R${salarioNovo}");
    Console.Clear();
}

else
{
    Console.WriteLine("Desculpe esse cargo não existe em nossa empresa, volte e coloque um cargo existente");
    Console.Clear();
}