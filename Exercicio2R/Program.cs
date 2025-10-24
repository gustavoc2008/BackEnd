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
