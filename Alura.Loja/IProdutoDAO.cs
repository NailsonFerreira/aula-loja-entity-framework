using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Loja
{
    interface IProdutoDAO
    {
        void Adicionar(Produto p);
        void Excluir(Produto p);
        void Atualizar(Produto p);
        IList<Produto> Produtos();
    }
}
