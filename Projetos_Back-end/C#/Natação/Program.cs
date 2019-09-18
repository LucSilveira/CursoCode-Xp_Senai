using System;

namespace Natação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Idade do nadador");
            int idade = int.Parse(Console.ReadLine());

            // if(idade <= 7){
            //     Console.WriteLine("Categoria infantil A");
            // }else if(idade >= 8 && idade <= 10){
            //     Console.WriteLine("Categoria infantil B");
            // }else if(idade >= 11 && idade <= 13){
            //     Console.WriteLine("Categoria Juvenil A");
            // }else if(idade >= 14 && idade <= 17){
            //     Console.WriteLine("Categoria Juvenil B");
            // }else{
            //     Console.WriteLine("Categoria Adulto");
            // }

            if(idade <= 7){
                Console.WriteLine("Categoria infantil A");
            }else if(idade <= 10){
                Console.WriteLine("Categoria infantil B");
            }else if(idade <= 13){
                Console.WriteLine("Categoria juvenil A");
            }else if(idade <= 17){
                Console.WriteLine("Categoria juvenil B");
            }else{
                Console.WriteLine("Categoria adulto");
            }
        }
    }
}
