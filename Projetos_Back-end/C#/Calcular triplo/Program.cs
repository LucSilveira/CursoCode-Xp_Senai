using System;

namespace Calcular_triplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe-nos um numero a sua escolha");
            int numero = int.Parse(Console.ReadLine());

            double triplo = Math.Pow(numero, 3);
            Console.WriteLine($"O resultado do triplo do numero é: {triplo}");
        }
    }
}
