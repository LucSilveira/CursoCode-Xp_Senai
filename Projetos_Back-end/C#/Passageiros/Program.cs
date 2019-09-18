using System;

namespace Passageiros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da passagem:");
            float valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de passageiros");
            int passageiros = int.Parse(Console.ReadLine());

            float saldo = valor * passageiros;
            Console.WriteLine($"O resultado é: {saldo}");
        }
    }
}
