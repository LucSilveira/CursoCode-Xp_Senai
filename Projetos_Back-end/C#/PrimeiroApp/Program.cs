using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Paulo Ricardôôôô");

            Console.WriteLine("Calculadora do lucão");

            int numero1;

            int numero2;

            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo numero");
            numero2 = int.Parse(Console.ReadLine());

            int res = numero1 + numero2;

            // o @, escreve o write line do jeito que está, respeitando a quebra de linha
            Console.WriteLine($@"O resultado
             é {res}");
        }
    }
}
