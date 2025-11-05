using Calculadora;

Calculator calc = new Calculator();

double n1 = 0;
double n2 = 0;
int escolha = -1;

do
{
    Console.Clear();
    Console.WriteLine($"==================================");
    Console.WriteLine($"     BOAS VINDAS A CALCULADORA    ");
    Console.WriteLine($"==================================");
    Console.WriteLine($"");

    Console.WriteLine($"        ESCOLHA A OPERACAO        ");
    Console.WriteLine($"1 - Somar");
    Console.WriteLine($"2 - Subtrair");
    Console.WriteLine($"3 - Multiplicar");
    Console.WriteLine($"4 - Dividir");
    Console.WriteLine($"5 - Sair");
    Console.Write($"Escolha: ");
    escolha = int.Parse(Console.ReadLine());

    if (escolha == 5)
    {
        Console.WriteLine("Saindo...");
        break;
    }

    Console.WriteLine($"Digite o primeiro numero");
    calc.n1 = double.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o segundo numero");
    calc.n2 = double.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            Console.WriteLine($"Resultado: {calc.Somar()}");
            break;

        case 2:
            Console.WriteLine($"Resultado: {calc.Subtrair()}");
            break;

        case 3:
            Console.WriteLine($"Resultado: {calc.Multiplicar()}");
            break;

        case 4:
            Console.WriteLine($"Resultado: {calc.Dividir()}");
            break;

        default:
            Console.WriteLine($"Opcao Invalida");
            break;
    }

    Console.WriteLine($"Aperte <ENTER> para continuar...");
    Console.ReadLine();

} while (escolha != 0);

//=================================================================

// Console.WriteLine($"=== RESULTADOS COMPLETOS ===");
// Console.WriteLine($"");

// Console.WriteLine($"Somar: {calc.Somar()}");
// Console.WriteLine($"");

// Console.WriteLine($"Subtrair: {calc.Subtrair()}");
// Console.WriteLine($"");

// Console.WriteLine($"Multiplicar: {calc.Multiplicar()}");
// Console.WriteLine($"");

// Console.WriteLine($"Dividir: {calc.Dividir()}");
// Console.WriteLine($"");

//=================================================================





