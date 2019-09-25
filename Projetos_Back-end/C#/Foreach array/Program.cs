using System;

namespace Foreach_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando array");
            string[] nomes = new string[10];

            foreach(var items in nomes){
                if(!string.IsNullOrEmpty(item)){
                    System.Console.WriteLine(items);
                }
            }

            int[] numeros = new int[10];
            foreach(var itens in numeros){
                if(itens == null){
                    System.Console.WriteLine(itens);
                }
            }
        }
    }
}
