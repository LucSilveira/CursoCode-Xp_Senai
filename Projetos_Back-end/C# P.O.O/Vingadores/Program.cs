using System;
using Vingadores.Controllers;
using Vingadores.Models;

namespace Vingadores {
    class Program {
        static void Main (string[] args) {
            int opcao = 0;

            CapitaoAmericaController capitao = new CapitaoAmericaController ();
            IronManController iron = new IronManController ();


            CapitaoAmerica cap = new CapitaoAmerica();
            HomemFerro ironman = new HomemFerro();

            Console.WriteLine ("Bem vindo ao joguinho dos vingadores: \n");
            System.Console.WriteLine ("Insert coin for start");
            Console.ReadLine ();


            do {
                System.Console.WriteLine ("\nEscolha um persosnagem para enfrentar o Thanos\n");
                System.Console.WriteLine ("\tOpção (1)\t-\tCapitão América");
                System.Console.WriteLine ("\tOpção (2)\t-\tHomem de Ferro");
                System.Console.WriteLine ("\tOpção (0)\t-\tSair do jogo\n");
                opcao = int.Parse (Console.ReadLine ());

                int opcaoPersonagem;

                switch (opcao) {

                    case 1:
                        capitao.CaptainAmerica ();

                        do {
                            System.Console.WriteLine ("\nThanos está vindo na sua direção");
                            System.Console.WriteLine ("Que ação você irá tornar?\n");
                            System.Console.WriteLine ($"\tOpção (1)\t-\tLançar o {cap.Equipamento}");
                            System.Console.WriteLine ($"\tOpção (2)\t-\tDefender com o {cap.Equipamento}");
                            System.Console.WriteLine ("\tOpção (0)\t-\tMudar de personagem");

                            opcaoPersonagem = int.Parse (Console.ReadLine ());
                            switch (opcaoPersonagem) {

                                case 1:
                                    capitao.LancarEscudo ();
                                    break;

                                case 2:
                                    capitao.DefenderEscudo ();
                                    break;

                                case 0:
                                    System.Console.WriteLine ("Mudando de personagem");
                                    Console.ResetColor();

                                    break;

                                default:
                                    break;
                            }
                        } while (opcaoPersonagem != 0);

                        break;

                    case 2:
                        iron.IronMan ();

                        do {
                            System.Console.WriteLine ("\nThanos está vindo na sua direção");
                            System.Console.WriteLine ("Que ação você irá tornar?\n");
                            System.Console.WriteLine ($"\tOpção (1)\t-\tAtirar com a {ironman.Armadura}");
                            System.Console.WriteLine ($"\tOpção (2)\t-\tVoar com a {ironman.Armadura}");
                            System.Console.WriteLine ("\tOpção (0)\t-\tMudar de personagem");
                            opcaoPersonagem = int.Parse (Console.ReadLine ());

                            switch (opcaoPersonagem) {

                                case 1:
                                    iron.Atirar();
                                    break;

                                case 2:
                                    iron.Voar();
                                    break;

                                case 0:
                                    System.Console.WriteLine ("Mudando de personagem");
                                    Console.ResetColor();
                                    break;

                                default:
                                    break;
                            }
                        } while (opcaoPersonagem != 0);

                        break;

                    case 0:
                        System.Console.WriteLine ("Game Over!!");
                        break;

                    default:
                        System.Console.WriteLine ("Ação não informada");
                        break;
                }

            } while (opcao != 0);
        }
    }
}