using System;

namespace Aumento_salário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salário");
            double salario_func = float.Parse(Console.ReadLine());

            double aumento_salario = 0.3;

            if(salario_func <= 990){
                double salario_aumento = salario_func * aumento_salario;
                // Console.WriteLine($"{salario_aumento}");
                double salario = salario_func + salario_aumento;
                Console.WriteLine($"Seu salário reajustado é: {salario}");
            }else{
                Console.WriteLine($"Seu salário não foi reajustado, sendo ele {salario_func}");
            }
        }
    }
}
