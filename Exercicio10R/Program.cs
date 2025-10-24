int escolha;

do
{
    Console.Clear();
    Console.WriteLine("=====================================");
    Console.WriteLine("         MENU DE EXERCÍCIOS          ");
    Console.WriteLine("=====================================");
    Console.WriteLine("1. Executar Exercício 1");
    Console.WriteLine("2. Executar Exercício 2");
    Console.WriteLine("3. Executar Exercício 3");
    Console.WriteLine("4. Executar Exercício 4");
    Console.WriteLine("5. Executar Exercício 5");
    Console.WriteLine("6. Executar Exercício 6");
    Console.WriteLine("7. Sair");
    Console.WriteLine("=====================================");
    Console.Write("Digite sua opção: ");
    escolha = int.Parse(Console.ReadLine());
    
    switch(escolha)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                case 6:
                    Exercicio6();
                    break;
                case 7:
                    Console.WriteLine("Saindo do programa. Até mais!");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, digite um número de 1 a 7.");
                    break;
            }

    if (escolha != 7)
    {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

    
    void Exercicio1()
    {
        Console.Clear();
        Console.WriteLine("--- Executando Exercício 1 ---");
        Console.WriteLine("Esta é a função do Exercício 1.");
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
    }

    void Exercicio2()
    {
        Console.Clear();
        Console.WriteLine("--- Executando Exercício 2 ---");
        Console.WriteLine("Esta é a função do Exercício 2.");
    int time1;
    int time2;
    string placar;

    Console.WriteLine("Qual foi o placar do jogo");
    placar = Console.ReadLine();

    Console.WriteLine("Quantos gols o Time da Casa fez?");
    time1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Quantos gols o Time Visitante fez?");
    time2 = int.Parse(Console.ReadLine());

    if (time1 > time2)
        {
            Console.WriteLine("VITORIA DO TIME DA CASA");
            Console.WriteLine();
            Console.WriteLine($"O Time da Casa fez {time1} e o Time Visitante fez {time2}");
        }

    else if (time1 < time2)
        {
            Console.WriteLine("VITORIA DO TIME VISITANTE");
            Console.WriteLine();
            Console.WriteLine($"O Time da Casa fez {time1} e o Time Visitante fez {time2}");
        }

    else
        {
            Console.WriteLine("EMPATE");
            Console.WriteLine();
            Console.WriteLine($"O Time da Casa fez {time1} e o Time Visitante fez {time2}");
        }
    }

    void Exercicio3()
    {
        Console.Clear();
        Console.WriteLine("--- Executando Exercício 3 ---");
        Console.WriteLine("Esta é a função do Exercício 3.");
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
    }

    void Exercicio4()
    {
        Console.Clear();
        Console.WriteLine("--- Executando Exercício 4 ---");
        Console.WriteLine("Esta é a função do Exercício 4.");
    int senha;
    int senhaCorreta = 1234;

    Console.WriteLine("Digite a senha:");
    senha = int.Parse(Console.ReadLine());

    Console.Clear();

    if (senha == senhaCorreta)
        {
            Console.WriteLine("ACESSO PERMITIDO");
            Console.WriteLine();
            Console.WriteLine("Pasta Familia");
            Console.WriteLine("Pasta Foto com Anoes");
        }

    else
        {
            Console.WriteLine("ACESSO NEGADO");
            return;
        }
    }

    void Exercicio5()
    {
        Console.Clear();
        Console.WriteLine("--- Executando Exercício 5 ---");
        Console.WriteLine("Esta é a função do Exercício 5.");
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
    }

    void Exercicio6()
    {
        Console.Clear();
        Console.WriteLine("--- Executando Exercício 6 ---");
        Console.WriteLine("Esta é a função do Exercício 6.");
    int frequencia;
    int media;
    int n1, n2, n3, n4;

    Console.WriteLine("Digite qual a frequencia do aluno");
    frequencia = int.Parse(Console.ReadLine());

    if (frequencia < 75)
        {
            Console.WriteLine($"REPROVADO");
        }

    else
        {
            Console.WriteLine($"Digite qual a media do aluno");
            media = int.Parse(Console.ReadLine());

    if (media >= 7)
        {
            Console.WriteLine($"PARABENS, VOCE FOI APROVADO");
        }

    else if (media >= 3 && media < 7)
        {
            Console.WriteLine($"VOCE AINDA TEM UMA CHANCE, ESTA EM RECUPERACAO");
        }

    else
        {
            Console.WriteLine($"VOCE ESTA REPROVADO");
        }
}

            Console.Clear();
    }
} while (escolha != 7);
