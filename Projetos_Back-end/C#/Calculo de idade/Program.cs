using System;

namespace Calculo_de_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de idade");
            

            Console.WriteLine("Informe sua idade:");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade * 12;
            int dias = idade * 365;
            int horas = dias * 24;
            int minutos = horas * 60;

            Console.WriteLine($@"Seu resultado em meses é {meses},
 em dias {dias}, em horas {horas}, em minutos {minutos}");
        }
    }
}
