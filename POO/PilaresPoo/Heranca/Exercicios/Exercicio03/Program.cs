using Exercicio03;

Carro Monza = new Carro();
Veiculo carGeneric = new Veiculo();
Console.Clear();
Monza.marca = "Chevrolet";
Monza.modelo = "Quadrado";
Monza.ano = 1982;
Monza.QntdPortas = 4;
Monza.ExibirInfo();
Monza.Acelerar();
Monza.SomDoCarro();

Moto HarleyDavidson = new Moto();
Veiculo motoGeneric = new Veiculo();
Console.Clear();
HarleyDavidson.marca = "Harley Davidson";
HarleyDavidson.modelo = "Dyna Low Rider";
HarleyDavidson.ano = 2006;
HarleyDavidson.QntdCilindradas = 1500;
HarleyDavidson.ExibirInfo();
HarleyDavidson.Acelerar();
HarleyDavidson.SomDaMoto();
