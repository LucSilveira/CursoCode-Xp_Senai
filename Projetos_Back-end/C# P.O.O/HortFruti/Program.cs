using System;
using HortFruti.Controllers;

namespace HortFruti
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosController produtosController = new ProdutosController();
            int opcao; 

            do{
                Console.WriteLine("\nBem Vindo ao nosso sitema de HortiFruti <3\n\n");
                Console.WriteLine("____________________________________________________");
                Console.WriteLine("Informe o que você desaja realizar no nosso sistema:");
                Console.WriteLine("\tOpção (1)\t-\tCadastrar algum produto");
                Console.WriteLine("\tOpção (2)\t-\tListar nossos prrodutos");
                Console.WriteLine("\tOpção (3)\t-\tSomar preços do produtos");
                Console.WriteLine("\tOpção (0)\t-\tSair do sistema\n");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){

                    case 1:
                        produtosController.CadastrarProduto();
                        break;

                    case 2:
                        produtosController.ListarProdutos();
                        break;

                    case 3:
                        double calculo = produtosController.CalcularLucro();
                        break;

                    case 0:
                        System.Console.WriteLine("Muito obrigado pelo acesso, volte sempre!");
                        break;

                    default:
                        System.Console.WriteLine("Perdão, ação não informada corretamente, verifique sua resposta!");
                        break;
                }

            }while(opcao != 0);
        }
    }
}
