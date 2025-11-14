using ExerciciosPolimorfismo;


PagamentoPix comprarPix = new PagamentoPix();
comprarPix.valorCompra = 1500;

float valorPagar = comprarPix.calcularTotal();
Console.WriteLine($"Produto: Smartphone");
Console.WriteLine($"Preco: {comprarPix.valorCompra}");
Console.WriteLine($"Forma de Pagamento: Pix");
Console.WriteLine($"Pagamento com Desconto: {valorPagar}");

Console.WriteLine();

PagamentoCartao comprarCartao = new PagamentoCartao();
comprarCartao.valorCompra = 50;

Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preco: {comprarCartao.valorCompra}");
Console.WriteLine($"Forma de Pagamento: Cartao");
Console.WriteLine($"Pagamento com Acrescimo: {comprarCartao.calcularTotal()}");
