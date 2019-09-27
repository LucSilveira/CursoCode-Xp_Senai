using System;
using Criando_exemplo_de_POO.Models;

namespace Criando_exemplo_de_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoModel aluno1 = new AlunoModel();

            Console.Clear();

            System.Console.WriteLine("Insira o nome:");
            aluno1.Nome = Console.ReadLine();

            System.Console.WriteLine("Insira o nome do curso:");
            aluno1.Curso = Console.ReadLine();

            System.Console.WriteLine("Insira seu Rg:");
            aluno1.Rg = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe sua idade:");
            aluno1.Idade = int.Parse(Console.ReadLine());
        }
    }
}
