int escolha;

do
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine($"==================================================");
    Console.WriteLine($"                   Bem Vindo(a)                   ");
    Console.WriteLine($"                        Ao                        ");
    Console.WriteLine($"             Nos Nao Somos Cavalo Food            ");
    Console.WriteLine($"==================================================");
    Console.WriteLine();

    Console.WriteLine("Qual opcao voce deseja escolher no nosso menu?");
    Console.WriteLine("1 - Cavalo Assado •••••••••••••••• R$30,90");
    Console.WriteLine("2 - Cavalo Frito •••••••••••••••• R$25,00");
    Console.WriteLine("3 - Cavalo a Parmegiana •••••••••••••••• R$35,79");
    Console.WriteLine("4 - Sair");
    escolha = int.Parse(Console.ReadLine()); 

    switch (escolha)
    {
        case 1:
            cavaloAssado();
            break;

        case 2:
            cavaloFrito();
            break;

        case 3:
            cavaloAParmegiana();
            break;

        case 4:
            sair();
            break;

        default:
            Console.WriteLine("Escolha invalida, escolha uma das opcoes anteriores");
            break;
    }


    if (escolha != 4)
    {
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey(); // Espera o usuário apertar uma tecla antes de voltar ao menu
    }

} while (escolha != 4);

void cavaloAssado()
{
    Console.WriteLine("Voce escolheu Cavalo Assado. Otima Escolha");
}

void cavaloFrito()
{
    Console.WriteLine("Voce escolheu Cavalo Frito. Otima Escolha");
}

void cavaloAParmegiana()
{
    Console.WriteLine("Voce escolheu Cavalo a Parmegiana. Escolha Perfeita");
}

void sair()
{
    Console.WriteLine("Saindo...");
}