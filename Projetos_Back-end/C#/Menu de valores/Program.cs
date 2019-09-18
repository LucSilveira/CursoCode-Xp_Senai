using System;

namespace Menu_de_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("_________________________________________________");
            Console.WriteLine("         Selecione uma opção de operação         ");
            Console.WriteLine("           ---------------------------           ");
            Console.WriteLine(" (1) - Somando os 2 números");
            Console.WriteLine(" (2) - Subtraindo o primeiro número com o segundo");
            Console.WriteLine(" (3) - Subtraindo o segundo número com o primeiro");
            Console.WriteLine(" (4) - Multiplicando os 2 números");
            Console.WriteLine(" (5) - Dividindo o primeiro número com o segundo");
            Console.WriteLine(" (6) - Dividindo o segundo número com o primeiro");
            Console.WriteLine("_________________________________________________");
            string resposta = Console.ReadLine();


            float calc = 0;
            float res = calc;
            switch (resposta){

                case "1":
                calc = numero1 + numero2;
                res = calc;
                Console.WriteLine($"O resultado é: {res}");
                break;

                case "2":
                calc = numero1 - numero2;
                res = calc;
                Console.WriteLine($"O resultado é: {res}");
                break;

                case "3":
                calc = numero2 - numero1;
                res = calc;
                Console.WriteLine($"O resultado é: {res}");
                break;

                case "4":
                calc = numero1 * numero2;
                res = calc;
                Console.WriteLine($"O resultado é: {res}");
                break;

                case "5":
                calc = numero1 / numero2;
                res = calc;
                Console.WriteLine($"O resultado é: {res}");
                break;

                case "6":
                calc = numero2 / numero1;
                res = calc;
                Console.WriteLine($"O resultado é: {res}");
                break;
            }
        }
    }
}
