using System;
using Vingadores.Models;

namespace Vingadores.Controllers
{
    public class IronManController
    {
        
        HomemFerro tonyEsterco = new HomemFerro();

        public void IronMan(){

            Console.ForegroundColor = ConsoleColor.Red;

            tonyEsterco.Vida = 100;
            System.Console.WriteLine($"A quantidade de vida do Homem de Ferro é: {tonyEsterco.Vida} Xp");

            tonyEsterco.Cor = "Vermelha";
            System.Console.WriteLine($"A cor do Homem de Ferro é: {tonyEsterco.Cor}");

            tonyEsterco.Equipe = "#TeamIron";
            System.Console.WriteLine($"A equipe na qual o Homem de Ferro participa é: {tonyEsterco.Equipe}");

            System.Console.WriteLine("Informe a armadura na qual o homem de ferro ira usar: ");
            tonyEsterco.Armadura = Console.ReadLine();

            System.Console.WriteLine("______________________________________________________________________________________");

        }

        public void Atirar(){

            System.Console.WriteLine($"Tony atirou no Thanos com a ajuda da {tonyEsterco.Armadura}!!!");

        }

        public void Voar(){

            System.Console.WriteLine($"Tony voo com a ajuda da {tonyEsterco.Armadura} do ataque do Thanos!!!");

        }

    }
}