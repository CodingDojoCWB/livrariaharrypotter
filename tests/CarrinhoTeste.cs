using NUnit.Framework;
using app;
using System.Collections.Generic;

namespace tests
{
    public class CarrinhoTest
    {
        
        private Carrinho carrinho;
        [SetUp]
        public void Setup()
        {
            carrinho =  new Carrinho();
            var livros = new Dictionary<string, decimal>();

            carrinho.Add("Livro 1", 42.00m);
        }

        [Test]
        public void getQuantidade()
        {
            Assert.AreEqual(1 ,carrinho.totalLivros());
        }

        [Test]
        public void validarDescontoCintoPorcento()
        {
            carrinho.Add("Livro 2", 42);
            Assert.AreEqual(79.8m, carrinho.FinalizarVenda());
        }

         [Test]
        public void validarDescontoDezPorcento()
        {
            carrinho.Add("Livro 2", 42);
            carrinho.Add("Livro 3", 42);
            Assert.AreEqual(113.4m, carrinho.FinalizarVenda());
        }

         [Test]
        public void validarDescontoQuinzePorcento()
        {
            carrinho.Add("Livro 2", 42);
            carrinho.Add("Livro 3", 42);
            carrinho.Add("Livro 4", 42);
            Assert.AreEqual(142.8m, carrinho.FinalizarVenda());
        }

    }
}