using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Loja
{
   public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoUnitario { get; internal set; }
        public string Unidade { get; internal set; }
        public IList<PromocaoProduto> Promocoes { get; set; }

        public Produto() { }

        public Produto(string nome, string categoria, double preco)
        {
            Nome = nome;
            Categoria = categoria;
            PrecoUnitario = preco;
        }

        public Produto(string nome, string categoria, double preco, string unidade)
            : this(nome, categoria, preco)
        {
            Unidade = unidade;
        }

        public override string ToString()
        {
            return "Produto: " + Nome + "ID: " + Id;
        }
    }
}
