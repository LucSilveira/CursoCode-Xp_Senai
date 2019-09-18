using System;

namespace Conversor_dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe quanto em reais você possui?");
            float reais = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da cotação do Dolar");
            float dolar = float.Parse(Console.ReadLine());

            reais = reais / dolar;

            Console.WriteLine($"O valor da conversão: {reais}");
            
        }
    }
}
