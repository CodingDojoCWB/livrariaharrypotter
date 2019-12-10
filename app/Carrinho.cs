namespace aap
{
    public class Carrinho
    {
        private string _livro;
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
            
        }

        public Carrinho(string livro, decimal preco)
        {
            Livro = livro;
            Preco = preco; 
        }

        public void Add(string livro, decimal preco)
        {

        }
    }
}