namespace P.O.O_sobre_heranca.Models
{
    public class PessoaModel
    {
        public string Nome {get; set;}

        public int Idade {get; set;}

        public void Comer(){
            System.Console.WriteLine("Partiu B.P");
        }

        public void Andar(){
            System.Console.WriteLine("Vamos caminhar");
        }

        public void Dormir(){
            System.Console.WriteLine("Vamo nana");
        }
    }
}