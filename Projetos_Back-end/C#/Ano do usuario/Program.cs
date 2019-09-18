using System;

namespace Ano_do_usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ano de nascimento");

            Console.WriteLine("Informe o ano do seu nascimento");
            int anoNascimento = int.Parse(Console.ReadLine());

            int hoje = DateTime.Now.Year;

            int idade =  hoje - anoNascimento;

            Console.WriteLine($"Sua idade é: {idade}");

            int semanas = idade * 52;

            Console.WriteLine($"Sua idade em semanas é {semanas}");
        }
    }
}
