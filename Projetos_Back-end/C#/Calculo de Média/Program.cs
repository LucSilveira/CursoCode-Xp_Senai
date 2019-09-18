using System;

namespace Calculo_de_Média
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de media");

            // Criando as variaveis que seram utilizadas
            int primeira_nota;
            int segunda_nota;
            int terceira_nota;

            // Lendo as notas do usuario
            Console.WriteLine("Informe sua primeira nota:");
            primeira_nota = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua segunda nota:");
            segunda_nota = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua terceira nota:");
            terceira_nota = int.Parse(Console.ReadLine());


            float media = (primeira_nota + segunda_nota + terceira_nota);

            float resultadoMedia = media / 3;

            Console.WriteLine($"A Média de suas notas são: {resultadoMedia}");

            if(resultadoMedia >= 5 ){
                Console.WriteLine("Sua situação é aprovado");
            }else{
                Console.WriteLine("Sua situação é reprovado");
            }


        }
    }
}
