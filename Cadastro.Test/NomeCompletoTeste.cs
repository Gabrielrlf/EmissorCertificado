using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cadastro.Core.Domain.Model.Organizadores;

namespace Cadastro.Testes
{
    [TestClass]
    public class NomeCompletoTeste
    {
        [TestMethod]
        public void TesteNomeCompleto()
        {
            NomeCompleto nome = new NomeCompleto("Gabriel", "Fonseca");
            Assert.AreEqual("Gabriel Fonseca", nome.EscreverNome());
        }
    }
}
