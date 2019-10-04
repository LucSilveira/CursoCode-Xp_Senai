using System;
using Vingadores.Models;

namespace Vingadores.Controllers
{
    public class CapitaoAmericaController
    {
        CapitaoAmerica capitao = new CapitaoAmerica();

        public void CaptainAmerica(){

            Console.ForegroundColor = ConsoleColor.Blue;

            System.Console.WriteLine("\n\n\t\t\tInformações sobre o Capitão America");

            capitao.Vida = 100;
            System.Console.WriteLine($"\n\t\t* A quantidade de vida do Capitão América é de: {capitao.Vida} Xp *");

            capitao.Cor = "Azul";
            System.Console.WriteLine($"\n\t\t* A cor do Capitão América é: {capitao.Cor} *");

            capitao.Equipe = "#TeamCap";
            System.Console.WriteLine($"\n\t\t* A equipe na qual o Capitão América pertence é: {capitao.Equipe} *");

            System.Console.WriteLine("\n\t\t* Informe o equipamento no qual o capitão ira utilizar: *");
            capitao.Equipamento = Console.ReadLine();

            System.Console.WriteLine("_____________________________________________________________________________");
        }

        public void LancarEscudo(){

            System.Console.WriteLine($"\nThanos com muita irá vem atrás do Capitão América!!");
            System.Console.WriteLine("Ambos lutam com muita precisão e os dois saem machucados");
            System.Console.WriteLine($"Mas com o ato de muita bravura Capitão pega seu {capitao.Equipamento}");
            System.Console.WriteLine("E da um golper de incrível precisão no Thanos que o mesmo dismaia");

        }

        public void DefenderEscudo(){

            // System.Console.WriteLine($"Capitão utilizou o {capitao.Equipamento} para se defender do ataque do Thanos!!!");
            System.Console.WriteLine("Thanos vem com sua manopla pra cima do Capitão América, e o mesmo");
            System.Console.WriteLine("percebe que o inimigo está prestes a utilizar o poder das joias");
            System.Console.WriteLine($"quando o heroi pega seu {capitao.Equipamento} e bloquei o ataque do vilão");

        }
    }
}