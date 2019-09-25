using System;

namespace Codin_Dojo_mercado
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criando variavel de nomes de produtos para salvar os nomes
            string[] nomeProdutos = new string[10];

            // Criando uma variavel que ira armazenar os precos dos produtos
            double[] precosProdutos = new double[10];

            // Criando um contador para ele repetir o laco de cadastro
            int contador = 0;

            // Criando uma variavel para o usuario ter acesso ao menu
            int opcaoSelecionada = 0;

            // __________________________________________________________________________________
            // Criando laco para repetir todo o sistema
            do{
                // Exibindo o menu para saber o que o usuario vai fazer
                Console.WriteLine("Bem Vindo ao nosso sistema de mercado!");
                Console.WriteLine("");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("Opção (1)    -   Cadastrar novos produtos");
                Console.WriteLine("Opção (2)    -   Listar os produtos");
                Console.WriteLine("Opção (3)    -   Calcular o preço dos produtos");
                Console.WriteLine("Opção (0)    -   Sair do nosso sistema");

                // Salvando a tomada de decisao do usuario de acordo com o menu
                opcaoSelecionada = int.Parse(Console.ReadLine());

                Console.WriteLine("_______________________________________________");

                // Realizando tarefas de acordo com a decisao do usuario
                switch(opcaoSelecionada){

                    // Caso a opcao seja igual a 1 (cadastrar)
                    case 1:
                        Console.WriteLine("Cadastrando novos produtos");
                        Console.WriteLine("");

                        // Salva a respost se ele quer repetir um cadastro
                        string resposta = "";

                        // Laco para realizar o cadastro
                        do{

                            // Laco para realizar o cadastro de 10 produtos
                            // Caso seja maior que 10, ele para
                            if(contador < 10){

                                // Guardando o nome do produto
                                Console.WriteLine("Qual o nome do produto a ser cadastrado");
                                nomeProdutos[contador] = Console.ReadLine();

                                // Guardando o preco do produto
                                Console.WriteLine("Qual o preco do produto cadastrado");
                                precosProdutos[contador] = double.Parse(Console.ReadLine());
                                
                                Console.WriteLine("");

                                // Para que o contador cresca cada vez que o laco for efetuado
                                contador++;

                            // Caso a quantidade de produtos seja maior que 10
                            }else{

                                Console.WriteLine("Você atingiu o máximo de produtos cadastrados");
                                break;

                            }

                            // Verificando se o usuario quer efetuar mais cadastros
                            Console.WriteLine("Você gostaria de cadastrar outro produto?");
                            resposta = Console.ReadLine();
                            Console.WriteLine("");

                        // Verifica se o usuario confirma se sim ou nao
                        }while(resposta == "sim");
                        break;

                    // Caso a opcao seja igual a 2 (listar)
                    case 2:

                        Console.WriteLine("Listando os nossos produtos");
                        Console.WriteLine("");

                        // Contador para efetuar o laco
                        int contadorB = 0;

                        // Realizando o laco de lista
                        do{
                            
                            // Informar o nome e o preco dos produtos
                            Console.WriteLine($"O nome do produto {nomeProdutos[contadorB]}, e o preço do produto {precosProdutos[contadorB]}");

                            // Para que o contador cresca cada vez que o laco for efetuado
                            contadorB++;

                        // Verifica se o contador atingiu a quantidade de produtos cadastrados
                        }while(contadorB < 2);

                        break;

                    // Verifica se a opcao é igual a 3 (somar)
                    case 3:
                        Console.WriteLine("Calculando o preço do produto");
                        Console.WriteLine("");

                        // variavel que vai receber a soma de todos os produtos
                        double precoTotal = 0;

                        // Contador para realizar o laco
                        int contadorC = 0;
                        
                        // Verifica se se o contador atingiu a quantidade de produtos cadastrados
                        while(contadorC < 2){

                            // Somando os precos dos produtos cadastrados
                            precoTotal += precosProdutos[contadorC];

                            // Para que o contador cresca cada vez que o laco for efetuado
                            contadorC++;
                        }

                        // Exibindo a soma dos precos dos produtos
                        Console.WriteLine($"O preço total dos Produtos é {precoTotal}");

                        break;
                        

                    case 0:
                        break;
                }

            }while(opcaoSelecionada != 0);
            
        }
    }
}
