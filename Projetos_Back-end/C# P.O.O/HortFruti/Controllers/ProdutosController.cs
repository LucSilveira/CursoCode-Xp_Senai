using System;
using HortFruti.Models;
using System.Collections.Generic;

namespace HortFruti.Controllers
{
    public class ProdutosController
    {

        // Criando lista para armazenar os produtos
        List<ProdutosModel> listProdutos = new List<ProdutosModel>();

        public void CadastrarProduto(){

            Console.WriteLine("Informe o nome do produto:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a categoria do produto:");
            string categoria = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade no estoque:");
            int estoque = int.Parse(Console.ReadLine());

            ProdutosModel produtos = new ProdutosModel();

            produtos.Id += 1;
            produtos.Nome = nome;
            produtos.Categoria = categoria;
            produtos.Preco = preco;
            produtos.QuantidadeEstoque = estoque;
            produtos.DataCadastro = DateTime.Now;

            listProdutos.Add(produtos);
        }

        public void ListarProdutos(){

            foreach(var item in listProdutos){

                System.Console.WriteLine("___________________________\n");
                System.Console.WriteLine($"Identificação: {item.Id}");
                System.Console.WriteLine($"Nome produto: {item.Nome}");
                System.Console.WriteLine($"Categoria produto: {item.Categoria}");
                System.Console.WriteLine($"Preço do produto: {item.Preco}");
                System.Console.WriteLine($"Quantidade no estoque: {item.QuantidadeEstoque}");
                System.Console.WriteLine($"Data do cadastro: {item.DataCadastro}");

            }

        }


        public double CalcularLucro(){

            double lucro = 0;
            foreach(var item in listProdutos){

                lucro += item.Preco * item.QuantidadeEstoque;
            }

            Console.WriteLine($"O seu lucro calculado: {lucro}");
            return lucro;

        }
        
    }
}