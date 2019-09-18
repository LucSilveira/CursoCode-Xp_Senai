using System;

namespace Vendedor_comissao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome para identificação:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o seu salário mensal:");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preco total de produtos vendidos no mês");
            float valor = float.Parse(Console.ReadLine());
            
            float comissao = (valor * 10) / 100;
            float salario_final = salario + comissao;
            Console.WriteLine($"Nome do funcionário: {nome}, o seu salário: {salario}, o salario com comissão: {salario_final}");
            
        }
    }
}
