using System;

namespace Salario_vendedor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salário!");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de produtos vendidos!");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o preço do produto");
            float preco = float.Parse(Console.ReadLine());

            float comissao = (preco * 5) / 100;
            float taxaComissao = comissao * quantidade;
            salario = salario + taxaComissao;

            Console.WriteLine($"O seu salario final é: {salario}");
        }
    }
}
