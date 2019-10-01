using System;
using System.Collections.Generic;
using P.O.O_sobre_heranca.Models;

namespace P.O.O_sobre_heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo herança");

            // public List<FuncionarioModel> ListaFuncionario = new List<FuncionarioModel>();
            FuncionarioModel funcionario = new FuncionarioModel();
            List<FuncionarioModel> listaFuncionarios = new List<FuncionarioModel>();


            int opcao;

            do{
                Console.WriteLine("Escolha uma opção de atividades do sistema:\n");
                System.Console.WriteLine("  opção (1)\t-\tCadastrar um Funcionario;");
                System.Console.WriteLine("  opção (2)\t-\tExectar Ações;");
                System.Console.WriteLine("  opção (0)\t-\tSair do sistema;");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    
                    case 1:
                        // Adicionando todos os funcionarios cadastrados a lista de funcionarios
                        FuncionarioModel funcionarioCadastrado = funcionario.CadastrarFuncionario();
                        listaFuncionarios.Add(funcionarioCadastrado);
                        

                        break;
                    
                    case 2:
                        int acao = 0;
                        do{
                            System.Console.WriteLine($"Selecione uma ação para {funcionario.Nome}");
                            System.Console.WriteLine("  Opção (1)\t-\tAndar");
                            System.Console.WriteLine("  Opção (2)\t-\tComer");
                            System.Console.WriteLine("  Opção (3)\t-\tTrabalhar");
                            System.Console.WriteLine("  Opção (0)\t-\tSair");
                            acao = int.Parse(Console.ReadLine());

                            switch(acao){

                                case 1:
                                    funcionario.Andar();
                                    break;
                                
                                case 2:
                                    funcionario.Comer();
                                    break;
                                
                                case 3:
                                    funcionario.Trabalhar();
                                    break;
                                
                                case 0:
                                    break;
                            }
                            
                        }while(acao != 0);
                        break;
                        

                    case 0:
                        break;
                }

            }while(opcao != 0);
        }
    }
}
