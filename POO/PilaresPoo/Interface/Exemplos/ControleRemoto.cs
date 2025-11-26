using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int nivelVolume = 0;
        public int volumeMaximo = 100;

        public string Marca;
        public ControleRemoto(string m)
        {
            Marca = m;
        }


        public void AumentarVolume()
        {
            if (nivelVolume < volumeMaximo)
            {
                Console.WriteLine("Aumentando volume...");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine($"Aumentando volume...");
                Thread.Sleep(3000);
                Console.WriteLine($"Volume ajustado para o maximo");
            }

            Console.WriteLine($"Volume atual: {nivelVolume}");
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando Aparelho...");
            Thread.Sleep(5000);
            Console.WriteLine($"Aparelho Desligado");
        }

        public void DiminuirVolume()
        {
            if (nivelVolume > 0)
            {
                Console.WriteLine("Diminuindo volume...");
                Thread.Sleep(3000);
            }
            else if (nivelVolume == 0)
            {
                Console.WriteLine($"Volume ja esta no minimo");
            }
    
            Console.WriteLine($"Volume atual: {nivelVolume}");
        }

        public void Ligar() 
        {
            Console.WriteLine($"Ligando Aparelho...");
            Thread.Sleep(5000); 
            Console.WriteLine($"Aparelho Ligado");  
        }   
    
        public void NivelVolume()
        {
            Console.WriteLine($"Digite o nivel do volume");
            int novoNivel = int.Parse(Console.ReadLine());
            
            if (novoNivel > volumeMaximo)
            {
                nivelVolume = volumeMaximo;
                Console.WriteLine($"Volume ajustado para o maximo permitido");
            }
            else if (novoNivel < 0)
            {
                nivelVolume = 0;
            }
            else
            {
                nivelVolume = novoNivel;
            }
        }

        public void VolumeMaximo()
        {
            if ( volumeMaximo < nivelVolume)
            {
                nivelVolume = volumeMaximo;
            }
        }
    }
}