using System;

namespace Percentual_de_aumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("informe seu salário:");
            float salarioOfic = float.Parse(Console.ReadLine());

            Console.WriteLine("informe seu código:");
            int codigo = int.Parse(Console.ReadLine());

            // Console.WriteLine("informe seu Percentual:");
            // int Percentual = Console.ReadLine();

            float percentual = 0;
            float salario = 0;

            switch (codigo){

            case 1:
                percentual = (salarioOfic * 50) / 100;
                salario = salarioOfic + percentual;
                Console.WriteLine($@"O seu nome: {nome}, seu salário {salarioOfic}, seu código {codigo},
seu cargo Escrituario, seu porcentual 50%, e seu salario com aumento {salario}");
                Console.WriteLine("");
                break;
            

            case 2:
                percentual = (salarioOfic * 35) / 100;
                salario = salarioOfic + percentual;
                Console.WriteLine($@"O seu nome: {nome}, seu salário {salarioOfic}, seu código {codigo},
seu cargo Secretário, seu porcentual 35%, e seu salario com aumento {salario}");
                Console.WriteLine("");
                break;

            case 3:
                percentual = (salarioOfic * 20) / 100;
                salario = salarioOfic + percentual;
                Console.WriteLine($@"O seu nome: {nome}, seu salário {salarioOfic}, seu código {codigo},
seu cargo Caixa, seu porcentual 20%, e seu salario com aumento {salario}");
                Console.WriteLine("");
                break;

            case 4:
                percentual = (salarioOfic * 10) / 100;
                salario = salarioOfic + percentual;
                Console.WriteLine($@"O seu nome: {nome}, seu salário {salarioOfic}, seu código {codigo},
seu cargo Gerente, seu porcentual 10%, e seu salario com aumento {salario}");
                Console.WriteLine("");
                break;

            case 5:
                Console.WriteLine($@"O seu nome: {nome}, seu salário {salarioOfic}, seu código {codigo},
seu cargo Caixa, você não possui percentual, e seu salario com aumento {salarioOfic}");
                Console.WriteLine("");
                break;
            }
        }
    }
}
