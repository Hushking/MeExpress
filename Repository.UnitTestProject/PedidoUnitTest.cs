using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeExpress.Domain;
using MeExpress.Repository;

namespace Repository.UnitTestProject
{ 
    [TestClass]
    public class PedidoUnitTest
    {
        //[TestMethod]
        //public void PedidoTest()
        //{
        //    ProdutoRepository produtoRep = new ProdutoRepository();
        //    PedidoProdutoItemRepository pedidoProdutoItemRep = new PedidoProdutoItemRepository();

        //    var produtoList = produtoRep.ObterProdutoList();
        //    var itemList = new List<PedidoProdutoItem>();

        //    foreach(var p in produtoList)
        //    {
        //        itemList.Add(new PedidoProdutoItem()
        //        {
        //            Quantidade = 0,
        //            Produto = new Produto() { 
        //                Id = p.Id,
        //                Nome = p.Nome,
        //                Preco = p.Preco
        //            }
        //        });
                 
        //    }
        //    foreach(var item in itemList)
        //    {
        //        Console.WriteLine(item.Quantidade + " " + item.Produto.Nome + " " + item.Produto.Preco.ToString("C") + " " + item.Produto.Id);
        //    }

        //    Assert.AreEqual(produtoList.Count, itemList.Count, "As listas deveriam ter o mesmo tamanho");
        //}
    }
}
