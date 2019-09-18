using System;

namespace Menu_de_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");f
            String[] nomes = new String[6];
            for(int i = 0; i < 6; i++){

                Console.WriteLine("Informe o nome de funcionarios");

                nomes[i] = Console.ReadLine();

            }
            Console.WriteLine("___________________________________");
            for(int i = 0; i < 6; i++){

                Console.WriteLine(nomes[i]);
            }
        }
    }
}
