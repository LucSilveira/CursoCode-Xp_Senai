using System;

namespace Array_de_media
{
    class Program
    {
        static void Main(string[] args)
        {

            // int mediaNota = 7;
            int contadorAprovado = 0;
            int contadorReprovado = 0;
            // int contador = 0;

            // do{

            //     Console.WriteLine("Informe sua primeira nota");
            //     int nota1 = int.Parse(Console.ReadLine());

            //     Console.WriteLine("Informe sua segunda nota");
            //     int nota2 = int.Parse(Console.ReadLine());

            //     int mediaCalculo = (nota1 + nota2) / 2;
            //     double mediaFinal = mediaCalculo;
            //     double[] media = new double[10];
            //     media[contador++] = mediaFinal;
            //     Console.WriteLine(media[contador++]);

            //     // if(media[mediaCalculo] >= mediaNota){
            //     //     contadorAprovado++;
            //     //     Console.WriteLine("Passou aprovado");
            //     // }else{
            //     //     contadorReprovado++;
            //     //     Console.WriteLine("Passou reprovado");
            //     // }
            //     // contador++;

            // }while(contador < 10);
            // // Console.WriteLine(contadorAprovado);

            int[] nota1 = new int[2];
            int[] nota2 = new int[2];
            double[] media = new double[10];
            // double[] mediaClasse = new double[1];
            int contador = 0;
            do{
                System.Console.WriteLine($"{contador+1}º aluno");
                System.Console.WriteLine("Digite a primeira nota");
                nota1[contador] = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Digite a segunda nota");
                nota2[contador] = int.Parse(Console.ReadLine());
                media[contador] = (nota1[contador] + nota2[contador])/2;
                // mediaClasse[contador] = media[contador] / media[contador].Length;

                if(media[contador] >= 7){
                    contadorAprovado++;
                }else{
                    contadorReprovado++;
                }
            }while(contador < 2);

            int contador2 = 0;
            double mediaClasse = 10;
            while(contador2 < 2){
                mediaClasse += media[contador2];
                contador2++;
            }
        }
    }
}
