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

            aluno1.cadastrarAluno();
            aluno1.listarAlunos();
            aluno1.indoNoBanheiro();
        }
    }
}
