using ClasseEObjetos;

//GARRAFA

// Garrafa stanley = new Garrafa();
// stanley.Cor = "Roxo";
// stanley.Tamanho = 22;
// stanley.Capacidade = 1000;
// stanley.Formato = "cilindrico";
// stanley.Marca = "Stanley";

// Console.Write($"Abrindo a garrafa");
// stanley.Abrir();

// Console.Write($"Bebendo agua");
// stanley.Beber();

// ===============================================================

//AGENCIA BANCARIA

// ContaBancaria conta = new ContaBancaria();
// conta.Titular = "Gustavo";
// conta.Saldo = 0;

// Console.WriteLine($"{conta.Titular} sua conta tem {conta.Saldo}");

// conta.Depositar(500);
// Console.WriteLine($"{conta.Titular} voce fez um deposito de {conta.Saldo}");
// Console.Write($"Seu saldo agora eh: {conta.Saldo}");
// Console.WriteLine($"");

// conta.Sacar(250);
// Console.WriteLine($"{conta.Titular} voce fez um saque de {conta.Saldo}");
// Console.Write($"Seu saldo agora eh: {conta.Saldo}");

// ==========================================================================

// PRODUTO COM DESCONTO

Produto panela = new Produto();
panela.nome = "Panela de Pressao Tramontina";
panela.preco = 200;

Console.WriteLine($"{panela.nome} custa {panela.preco}");

panela.AplicarDesconto(20);