using ClassesEstaticas;

Console.WriteLine($"Numero de PI: {CalculosMatematicos.PI}");

// Console.WriteLine($"Soma de 5 + 10 eh: {CalculosMatematicos.Somar(5, 10)}");
// Console.WriteLine($"Subtracao de 10 - 5 eh: {CalculosMatematicos.Subtrair(10, 5)}");
// Console.WriteLine($"Multiplicacao de 10 x 2 eh: {CalculosMatematicos.Multiplicar(10, 2)}");
// Console.WriteLine($"Divisao de 10 : 2 eh: {CalculosMatematicos.Dividir(10, 2)}");

// Console.Clear();
// Console.WriteLine($"Digite o primeiro numero");
// int n1 = int.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o segundo numero");
// int n2 = int.Parse(Console.ReadLine());

// Console.WriteLine($"===== RESULTADOS =====");
// Console.WriteLine($"Soma: {CalculosMatematicos.Somar(n1, n2)}");
// Console.WriteLine($"Subtracao: {CalculosMatematicos.Subtrair(n1, n2)}");
// Console.WriteLine($"Multiplicacao: {CalculosMatematicos.Multiplicar(n1, n2)}");
// Console.WriteLine($"Divisao: {CalculosMatematicos.Dividir(n1, n2)}");

Console.Clear();
Console.WriteLine($"Digite o primeiro numero");
float n1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero");
float n2 = int.Parse(Console.ReadLine());

Console.WriteLine($"===== RESULTADO =====");
Console.WriteLine($"O numero maior eh: {Math.Max(n1, n2)}");
Console.WriteLine($"O numero menor eh: {Math.Min(n1, n2)}");