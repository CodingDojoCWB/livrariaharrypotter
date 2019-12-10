using NUnit.Framework;
using app;

namespace tests
{
    public class TestAddReference
    {
        private Program program;
        [SetUp]
        public void Setup()
        {
            program = new Program();
        }

        [Test]
        public void Retorno_Hello_World()
        {
            string retorno = program.RetornoTexto();

            Assert.AreEqual("Hello World!", retorno);
        }
    }
}