using System;

namespace Foreach_de_usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foreach de usuario");
            System.Console.WriteLine("");

            // int i = 0;

            // for(int i = 0; i < 2; i++){

                

                // i++;
            // }

            int opcaoMenu;
            string resposta = "";
            
            System.Console.WriteLine("          Confira as opções do nosso menu         \n");
            System.Console.WriteLine("Por favor, informe");
            System.Console.WriteLine("o que gostaria de fazer: \n");
            System.Console.WriteLine(" Opção (1)\t-\tInserir uma pessoa no sistema;");
            System.Console.WriteLine(" Opção (2)\t-\tListar as pessoas no sistema;");
            System.Console.WriteLine(" Opção (0)\t-\tSair do sistema;");
            opcaoMenu = int.Parse(Console.ReadLine());

            int i = 0;

            int contadorM = 0;
            int contadorF = 0;

            double idadeMasc = 0;
            double mediaM = 0;
            
            double idadeFem = 0;
            double mediaF = 0;

            string[] nome = new string[10];
            int[] idade = new int[10];
            double[] peso = new double[10];
            double[] altura = new double[10];
            string[] sexo = new string[10];
            double[] imc = new double[10];

            switch(opcaoMenu){

                case 1:

                    do{

                        System.Console.WriteLine("Informe seu nome");
                        nome[i] = Console.ReadLine();
                        
                        System.Console.WriteLine("Informe sua idade");
                        idade[i] = int.Parse(Console.ReadLine());

                        System.Console.WriteLine("Informe o seu peso");
                        peso[i] = double.Parse(Console.ReadLine());

                        System.Console.WriteLine("Informe sua altura");
                        altura[i] = double.Parse(Console.ReadLine());

                        System.Console.WriteLine("Informe seu sexo");
                        sexo[i] = Console.ReadLine();

                        if(sexo[i] == "m" || sexo[i] == "M"){
                            idadeMasc += idade[i];
                            contadorM++;
                        }else{
                            idadeFem += idade[i];
                            contadorF++;
                        }

                        imc[i] = peso[i] / (altura[i] * altura[i]);

                        i++;

                        System.Console.WriteLine("Desejaria cadastrar outra pessoa");
                        resposta = Console.ReadLine();
                    }while(resposta != "sim");

                    mediaM = idadeMasc / contadorM;
                    mediaF = idadeFem / contadorF;

                    break;

                case 2:

                    int iB = 0;
                    while(iB < 2){
                        System.Console.WriteLine($@"O nome é {nome[iB]}, seu peso é {peso[iB]},
sua altura {altura[iB]}, seu sexo {sexo[iB]}, seu imc é {imc[iB]}");
                        iB++;
                    }

                    System.Console.WriteLine($"Media das idades masculinas {mediaM}");
                    System.Console.WriteLine($"Media das idades femininas {mediaF}");


                    break;

                case 0:
                    System.Console.WriteLine("Saindo do sistem...");
                    break;

                default:
                    System.Console.WriteLine("Opção não definida no menu, confira sua resposta!");
                    break;            

            }
        }
    }
}
