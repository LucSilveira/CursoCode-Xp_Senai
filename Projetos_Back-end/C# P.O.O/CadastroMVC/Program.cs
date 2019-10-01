using System;
using CadastroMVC.Controllers;

namespace CadastroMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioController usuarioController = new UsuarioController();
            int opcao = 0;

            do{
                System.Console.WriteLine("Escolha uma opção do nosso menu");
                System.Console.WriteLine(" Opção (1)\t-\tCadastrar Usuários");
                System.Console.WriteLine(" Opção (2)\t-\tListar Usuários");
                System.Console.WriteLine(" Opção (3)\t-\tAutenticar no sistema");
                System.Console.WriteLine(" Opção (0)\t-\tSair do sistema");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){

                    case 1:
                        usuarioController.CadastrarUsuario();
                        break;

                    case 2:
                        usuarioController.ListarUsuarios();
                        break;

                    case 3:
                        bool logar = usuarioController.Autenticando();
                        break;

                    case 0:
                        break;

                    default:
                        System.Console.WriteLine("Opção não informada");
                        break;
                }
            }while(opcao != 0);
        }
    }
}
