using PrimeiraClasse;

Console.Clear();
Console.WriteLine($"=================================");
Console.WriteLine($"     PROGRAMA PRIMERIA CLASSE    ");
Console.WriteLine($"=================================");

// Carro McLaren = new Carro();
// McLaren.marca = "McLaren";
// McLaren.cor = "Azul Goiaba";
// McLaren.modelo = "750s";
// McLaren.potencia = 750;

// Console.WriteLine($"Ligando a {McLaren.marca} {McLaren.cor}");
// McLaren.Ligar();

// Thread.Sleep(1000);

// Console.WriteLine($"Acelerando a {McLaren.marca} de {McLaren.potencia} cv");
// McLaren.Acelerar();

// Thread.Sleep(2000);

// Console.WriteLine($"Ayrton Senna derrapando...");
// McLaren.Derrapando();

// Thread.Sleep(500);

// Console.WriteLine($"Ayrton Senna batendo no muro");
// McLaren.Batendo();

// ---------------------------------------------------

// Pessoa p1 = new Pessoa();
// p1.nome = "Davy Jones";
// p1.idade = 37;
// p1.jogosZerados = "Resident Evil";
// p1.Falar();

// ---------------------------------------------------

// Garrafa g1 = new Garrafa();
// g1.Cor = "Azul Goiaba";
// g1.Tamanho = 27;
// g1.Capacidade = 700;
// g1.Formato = "Cilindrico";
// g1.Marca = "Stanley";
// g1.Abrir();
// g1.Beber();

Console.Clear();
Pessoa gu = new Pessoa();
gu.nome = "Gustavo";
// gu.idade = 17;
gu.jogosZerados = "The Last Of Us";
gu.Envelhecer();

Console.WriteLine($"{gu.nome} tem {gu.idade}");
gu.Envelhecer(10);
Console.WriteLine($"{gu.nome} tem {gu.idade}");







