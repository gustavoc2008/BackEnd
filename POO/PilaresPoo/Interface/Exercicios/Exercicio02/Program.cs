using Exercicio02;

List<IImprimivel> Documentos = new List<IImprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"===== MENU =====");
    Console.Write(@$"
1) Cadastrar Fatura
2) Cadastrar Relatorio
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatorios
6) Listar Contratos
0) Sair
Escolha uma opcao
");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"===== Cadastrar Fatura =====");
            Console.WriteLine($"");
            CadastrarFaturas();
            break;

        case 2:
            Console.WriteLine($"===== Cadastrar Relatorios =====");
            Console.WriteLine($"");
            CadastrarRelatorios();
            break;

        case 3:
            Console.WriteLine($"===== Cadastrar Contratos =====");
            Console.WriteLine($"");
            CadastrarContratos();
            break;

        case 4:
            Console.WriteLine($"===== Listar Faturas =====");
            Console.WriteLine($"");
            ListarFaturas();
            break;

        case 5:
            Console.WriteLine($"===== Listar Relatorios =====");
            Console.WriteLine($"");
            ListarRelatorios();
            break;

        case 6:
            Console.WriteLine($"===== Listar Contratos =====");
            Console.WriteLine($"");
            ListarContratos();
            break;

        case 0:
            Console.WriteLine($"Saindo...");
            Thread.Sleep(3000);
            break;

        default:
            Console.WriteLine($"Opcao Invalida");
            break;
    }

    Console.WriteLine($"Pressione <ENTER> para continuar");
    Console.ReadLine();

} while (opcao != 0);

void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do Devedor");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da Empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Digite o Valor da Fatura");
    float valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Dias de Atraso da Fatura");
    int qtdAtraso = int.Parse(Console.ReadLine());

    Fatura fat = new Fatura(dev, empresa, valor, qtdAtraso);
    Documentos.Add(fat);
    Console.WriteLine($"Fatura Cadastrada com Sucesso!");
}

void CadastrarRelatorios()
{
    Console.WriteLine($"Digite o nome do Autor");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite o Titulo do Relatorio");
    string titulo = Console.ReadLine();

    Console.WriteLine($"Digite O que esta a ser Analisado?");
    string analise = Console.ReadLine();

    Console.WriteLine($"Digite O que foi Feito?");
    string feito = Console.ReadLine();

    Console.WriteLine($"Digite a Conclusao");
    string conclusao = Console.ReadLine();
    
    Relatorio rel = new Relatorio(nome, titulo, analise, feito, conclusao);
    Documentos.Add(rel);
    Console.WriteLine("Relatorio Cadastrado com Sucesso!");
}

void CadastrarContratos()
{
    Console.WriteLine("Digite o nome do Cliente");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite o documento do Cliente");
    float doc = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite a descrição do contrato");
    string descricao = Console.ReadLine();

    Console.WriteLine($"Digite a obrigação do Contrato");
    string obrigacao = Console.ReadLine();

    Console.WriteLine($"Digite a penalidade do Contrato");
    string penalidade = Console.ReadLine();

    Contrato cont = new Contrato(nome, doc, descricao, obrigacao, penalidade);
    Documentos.Add(cont);
    Console.WriteLine("Contrato Cadastrado com Sucesso!");
}   

void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in Documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }

}

void ListarRelatorios()
{
    Console.WriteLine($"Listando Relatorios:");
    foreach(var item in Documentos)
    {
        if(item is Relatorio)
        {
            item.Imprimir();
        }
    }
    
}

void ListarContratos()
{
    Console.WriteLine("Listando Contratos:");
    foreach(var item in Documentos)
    {
        if(item is Contrato)
        {
            item.Imprimir();
        }
    }
}


