using System;
using System.Linq;

namespace Alura.Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            var pao = new Produto("Pão", "Alimento", 5.69, "Kilo");

            var compra = new Compra(pao, 10);

            var promocaoPascoa = new Promocao();

            //promocaoPascoa.Descricao = "Semana de Pascoa";
            //promocaoPascoa.DataInicio = DateTime.Now;
            //promocaoPascoa.DataFim = DateTime.Now.AddDays(14);
            //promocaoPascoa.Produtos.Add(new Produto());
            //promocaoPascoa.Produtos.Add(new Produto());


            using (var context = new LojaContext())
            {
                //context.Produtos.Add(pao);
                //context.Compras.Add(compra);
                //context.SaveChanges();
                var compras = context.Compras.ToList();
                foreach (var item in compras)
                {
                
                    Console.WriteLine(item);
                    //Console.WriteLine(compra);
                    //context.Compras.Remove(item);
                    //context.Produtos.Remove(item);

                }
                //context.SaveChanges();
            }
        }
    }
}
