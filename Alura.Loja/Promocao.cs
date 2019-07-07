using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Loja
{
    public class Promocao
    {
        public Promocao()
        {
        }
        public int Id { get; set; }
        public string Descricao { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataFim { get; internal set; }
        public IList<PromocaoProduto> Produtos { get; internal set; }
    }
}
