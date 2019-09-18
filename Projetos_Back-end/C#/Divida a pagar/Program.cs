using System;

namespace Divida_a_pagar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o valor do seu salário:");
            float salario =  float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor total das suas dividas:");
            float dividas = float.Parse(Console.ReadLine());

            float restante = salario - dividas;
            Console.WriteLine($"O restante do seu salário é: {restante}");
        }
    }
}
