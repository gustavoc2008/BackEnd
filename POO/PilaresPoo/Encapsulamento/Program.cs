using Encapsulamento;

// Console.Clear();
// ContaBancaria contaGu = new ContaBancaria();
// ContaBancaria contaRaw = new ContaBancaria(1000);

// contaGu.Depositar(-100);
// contaGu.Depositar(20);
// contaGu.Sacar(-10);
// contaRaw.Sacar(700);

// Console.WriteLine($"");

// Console.WriteLine($"Saldo Atual: R${contaGu.GetSaldo()}");
// Console.WriteLine($"Saldo Atual: R${contaRaw.GetSaldo()}");



//==================================================================================================

Console.Clear();
Carro carroGu = new Carro();
carroGu.DefinirMarca("Mazda");
carroGu.ObterMarca();
carroGu.DefinirModelo("RX7");
carroGu.ObterModelo();
carroGu.ObterVelocidade();
carroGu.Acelerar(250);
carroGu.Frear(40);

Console.WriteLine($"");

Console.WriteLine($"Marca do Carro: {carroGu.ObterMarca()}");
Console.WriteLine($"Modelo do Carro: {carroGu.ObterModelo()}");
Console.WriteLine($"Velocidade Atual: {carroGu.ObterVelocidade()}");



