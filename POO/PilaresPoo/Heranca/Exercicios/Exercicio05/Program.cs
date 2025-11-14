using Exercicio05;

Console.Clear();
ContaPoupanca conta = new ContaPoupanca();
Conta contaGeneric = new Conta();
conta.numero = 11915021323f;
conta.saldoaBase = 0;
conta.ExibirInfo();
conta.Exibir();
conta.QntdDeposito = 100;
conta.Depositar();
conta.ExibirInfo2();
conta.Exibir2();
conta.QntdSacar = 50;
conta.Sacar();
conta.ExibirInfo2();
