using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alura.Loja
{
    class ProdutoEntityDAO : IProdutoDAO, IDisposable
    {
        private LojaContext context;

        public ProdutoEntityDAO()
        {
            context = new LojaContext();
        }

        public void Adicionar(Produto p)
        {
            context.Produtos.Add(p);
            context.SaveChanges();
        }

        public void Atualizar(Produto p)
        {
            context.Produtos.Update(p);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void Excluir(Produto p)
        {
            context.Produtos.Remove(p);
            context.SaveChanges();
        }

        public IList<Produto> Produtos()
        {
            return context.Produtos.ToList();
        }


    }
}
