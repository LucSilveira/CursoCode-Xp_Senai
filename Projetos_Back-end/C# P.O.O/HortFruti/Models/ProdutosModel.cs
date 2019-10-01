using System;

namespace HortFruti.Models
{
    public class ProdutosModel
    {
        
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public double Preco { get; set; }

        public int QuantidadeEstoque { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}