using System;

namespace Divisao_por_modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro numero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            if(numero1 % 2 == 0){
                Console.WriteLine($"O número {numero1}, é um número par");
            }else{
                Console.WriteLine($"O número {numero1}, não é um número par");
            }

            if(numero2 % 2 == 0){
                Console.WriteLine($"O número {numero2}, é um número par");
            }else{
                Console.WriteLine($"O número {numero2}, não é um número par");
            }

            if(numero1 > numero2){
                Console.WriteLine($"O número {numero1}, é maior que {numero2}");
            }else{
                Console.WriteLine($"O número {numero2}, é maior que {numero1}");
            }
        }
    }
}
