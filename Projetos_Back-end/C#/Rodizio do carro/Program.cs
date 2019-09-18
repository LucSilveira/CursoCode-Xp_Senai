using System;

namespace Rodizio_do_carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rodizio da placa do carro");

            Console.WriteLine("Informe o numero final da sua placa");
            int placa = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o dia da semana");
            string dia = Console.ReadLine();

            if(placa <= 1){
                Console.WriteLine("Rodizio na Segunda-Feira");
            }else if(placa >= 1 && placa <= 3){
                Console.WriteLine("Rodizio na Terça-Feira");
            }else if(placa >= 4 && placa <= 5){
                Console.WriteLine("Rodizio na Quarta-Feira");
            }else if(placa >= 6 && placa <= 7){
                Console.WriteLine("Rodizio na Quinta-Feira");
            }else{
                Console.WriteLine("Rodizio na Sexta-Feira");
            }


            Console.WriteLine("Informe o ultimo sua placa");
            string placaFinal = Console.ReadLine();

            int characters = placaFinal.Length;
            string numeroFinalPlaca = placaFinal.Substring(characters - 1);

            Console.WriteLine($"teste {numeroFinalPlaca}");
        }
    }
}
