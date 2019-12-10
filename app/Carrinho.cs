using System;
using System.Collections.Generic;
using System.Linq;

namespace app
{
    public class Carrinho
    {
        private string _livro;
        public Dictionary<string, decimal> itens;
        public string Livro
        {
            get { return _livro; }
            set { _livro = value; }
        }

        private decimal _preco;
        public decimal Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
        
                
        public Carrinho()
        {
            itens = new Dictionary<string, decimal>();
        }

        public Carrinho(string livro, decimal preco)
        {
            Livro = livro;
            Preco = preco; 
            
        }

        public void Add(string livro, decimal preco)
        {
            itens.Add(livro, preco);
        }

        public int totalLivros()
        {
            return itens.Count;
        }

        public decimal FinalizarVenda()
        {
            decimal subTotal = itens.Count * 42.00m;
            switch (itens.Count) {
                case 1:
                    return subTotal;
                case 2:
                     return aplicarDesconto(5, subTotal);
                case 3:
                     return aplicarDesconto(10, subTotal);   
                case 4:
                     return aplicarDesconto(15, subTotal);   
            }
            return itens.Count * 42.00m;
        }

        public Decimal aplicarDesconto(int taxaDesconto, decimal valor){
            return valor - (valor * taxaDesconto / 100);
        }
    }
}