using System;

namespace app
{
    public class Program
    {
        private static string _texto;

        public static string Texto
        {
            get { return _texto; }
            set { _texto = value; }
        }

        static void Main(string[] args)
        {
            Texto = "Hello World!";
            Console.WriteLine(Texto);
        }

        public string RetornoTexto()
        {
            Texto = "Hello World!";
            return Texto;
        }
    }
}
