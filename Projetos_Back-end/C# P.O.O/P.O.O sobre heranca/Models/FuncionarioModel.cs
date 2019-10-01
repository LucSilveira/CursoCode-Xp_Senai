using System;

namespace P.O.O_sobre_heranca.Models
{
    public class FuncionarioModel : PessoaModel
    {
        private string Cargo {get; set;}

        public void Trabalhar(){
            System.Console.WriteLine("Agora vamos codar");
        }

        public FuncionarioModel CadastrarFuncionario(){

            FuncionarioModel funcionario = new FuncionarioModel();

            System.Console.WriteLine("Informe o nome do funcinario");
            funcionario.Nome = Console.ReadLine();

            System.Console.WriteLine("Informe a idade do funcionario");
            funcionario.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o cargo do funcionario");
            funcionario.Cargo = Console.ReadLine();

            return funcionario;

        }
    }
}