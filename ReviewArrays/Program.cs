
string[] nomes = new string[4]; //vai de 0 a 3 - o 0 conta

nomes[0] = "Paulo";
nomes[1] = "Rawany";
nomes[2] = "Julio";

Console.WriteLine($"Tamnho do Array: {nomes.Length}");

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"{i + 1}ª Nome: {nomes[i]}");
}

