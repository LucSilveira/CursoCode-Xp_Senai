using System;

namespace Array_idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int maiores = 0;
            int menores = 0;
            int contador = 0;

            do{
                Console.WriteLine("Informe sua idade:");
                int[] idades = new int[10];
                idades[contador] = int.Parse(Console.ReadLine());

                if(idades[contador] >= 18){
                    maiores++;
                }else{
                    menores++;
                }
                contador++;
            }while(contador < 10);

            Console.WriteLine($"O numero de pessoas maiores de idade {maiores}");
            Console.WriteLine($"O numero de pessoas menores de idade {menores}");
        }
    }
}
