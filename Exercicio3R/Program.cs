int triangulo1;
int triangulo2;
int triangulo3;
int contador = 1;
int resposta;

Console.WriteLine("Quantos lados tem o seu triangulo?");
resposta = int.Parse(Console.ReadLine());

while (contador <= resposta)
{
    Console.WriteLine("Informe o comprimento do primeiro lado");
    triangulo1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o comprimento do segundo lado");
    triangulo2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o comprimento do terceiro lado");
    triangulo3 = int.Parse(Console.ReadLine());

    if (triangulo1 == triangulo2 && triangulo2 == triangulo3)
    {
        Console.WriteLine($"O Triangulo eh Equilatero");
    }

    else if (triangulo1 == triangulo2 || triangulo1 == triangulo3 || triangulo2 == triangulo3)
    {
        Console.WriteLine($"O Triangulo eh Isosceles");
    }

    else
    {
        Console.WriteLine($"O Triangulo eh Escaleno");
    }
}
