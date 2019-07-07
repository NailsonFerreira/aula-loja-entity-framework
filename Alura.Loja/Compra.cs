using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Loja
{
    public class Compra
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; internal set; }
        public int Quantidade { get; internal set; }
        public double Preco { get; internal set; }

        public Compra(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = quantidade * produto.PrecoUnitario;
        }

        public Compra()
        {
        }
        public override string ToString()
        {
            return "Compra : " + Produto.Nome + " Produto ID: " + ProdutoId + " Compra ID: " + Id;
        }
    }
}
