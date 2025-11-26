namespace PrimeiraClasse
{
    public class Carro
    {
        //atributos
        public string modelo;

        public string marca;

        public string cor;

        public int potencia;
        //metodos
        public void Ligar()
        {
            Console.WriteLine($"zizizi... vrummmmmmmmm!!!");
        }

        public void Acelerar()
        {
            Console.WriteLine($"Vrum, Vrum...");
        }

        public void Derrapando()
        {
            Console.WriteLine($"SRRRRRRRRRRR");
        }
        public void Batendo()
        {
            Console.WriteLine($"Boooommmmmmm!!!");
        }
    }
}
