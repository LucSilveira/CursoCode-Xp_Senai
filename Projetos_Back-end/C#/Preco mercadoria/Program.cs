using System;

namespace Preco_mercadoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o preco do produto!");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual de acrescimo");
            float percentual = float.Parse(Console.ReadLine());

            float taxa = (preco * percentual) / 100;
            preco = preco + taxa;

            Console.WriteLine($"O resultado do produto é: {preco}"); 
        }
    }
}
