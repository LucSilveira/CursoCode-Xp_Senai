using System;

namespace Criando_exemplo_de_POO.Models
{
    public class AlunoModel
    {
        //Criando um sumário para a documentação

        /// <summary>
        /// Nome do Aluno
        /// </summary>
        /// <value>String</value>
     
        
        string Nome {get; set; }

        public string Curso { get; set; }

        public int Rg { get; set; }

        public int Idade { get; set; }


         public void cadastrarAluno(){
            Console.WriteLine("Infome seu nome");
            Nome = Console.ReadLine();

            Console.WriteLine("Insira o curso");
            Curso = Console.ReadLine();

            Console.WriteLine("Insira seu Rg");
            Rg = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade");
            Idade = int.Parse(Console.ReadLine());
        }


        public void listarAlunos(){
            Console.WriteLine($@"Nome: {Nome},
            Curso: {Curso},
            Rg: {Rg},
            Idade: {Idade}");
        }

        public void indoNoBanheiro(){
            Console.WriteLine(@"
            _____________________________________
                    Quero ir ao banheiro!!
            ______________________________________");
        }
    }
}