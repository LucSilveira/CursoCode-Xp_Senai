using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Informenos a área que vc atua");
            Console.WriteLine(" -----------------------------");
            Console.WriteLine(" ( 1 ) --- Web Designer");
            Console.WriteLine(" ( 2 ) --- Desenvolvedor Front-end");
            Console.WriteLine(" ( 3 ) --- Programador Java");
            Console.WriteLine(" ( 4 ) --- Programador C#");
            Console.WriteLine(" ( 5 ) --- Programador Python");
            Console.WriteLine(" ( 6 ) --- Programador Php");
            Console.WriteLine(" ( 7 ) --- Programador Delphi");
            Console.WriteLine(" -----------------------------");

            
            string resposta = Console.ReadLine();

            Console.WriteLine("Infome a sua area");

            switch (resposta)
            {
                
                case "1":
                Console.WriteLine("Web Designer"); 
                break;

                case "2":
                Console.WriteLine("Desenvolvedor Front-end");
                break;

                case "3":
                Console.WriteLine("Programador C#");
                break;

                case "4":
                Console.WriteLine("Programador Python");
                break;

                case "5":
                Console.WriteLine("Programador Php");
                break;

                case "6":
                Console.WriteLine("Programador Delphi");
                break;
            }
        }
    }
}
