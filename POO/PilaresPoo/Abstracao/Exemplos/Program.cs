using Exemplos;

// Gato Birobinha = new Gato();

// Cachorro Thor = new Cachorro();

//========================================================

// Console.Clear();
// Pessoa MichaelJackson = new Pessoa();
// MichaelJackson.nome = "Michael Jackson";
// MichaelJackson.idade = 50;
// MichaelJackson.Exibir();
// MichaelJackson.Dormir();
// MichaelJackson.FazerSom();
// MichaelJackson.Mover();

//========================================================

Console.Clear();
ContaPoupanca conta = new ContaPoupanca();
ContaCorrente conta1 = new ContaCorrente();
conta.saldo = 0;
conta.ExibirInfo();
Console.WriteLine($"Efetuando o Deposito...");
Thread.Sleep(4000);
Console.WriteLine($"Deposito Realizado com Sucesso!!!");
conta.Depositar(100);
conta.ExibirInfo();
Console.WriteLine($"Efetuando o Saque...");
Thread.Sleep(4000);
Console.WriteLine($"Saque Realizado com Sucesso!!!");
conta.Sacar(50);
conta.ExibirInfo();

// conta1.saldo = 0;
// conta1.ExibirInfo();
// Console.WriteLine($"Efetuando o Deposito...");
// Thread.Sleep(4000);
// Console.WriteLine($"Deposito Realizado com Sucesso!!!");
// conta1.Depositar(100);
// conta1.ExibirInfo();
// Console.WriteLine($"Efetuando o Saque...");
// Thread.Sleep(4000);
// Console.WriteLine($"Saque Realizado com Sucesso!!!");
// conta1.Sacar(50);
// conta1.ExibirInfo();