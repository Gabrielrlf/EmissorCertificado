using Cadastro.Core.Domain.Model.Organizadores;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nucleo.Core;

namespace Cadastro.Testes
{
    [TestClass]
    public class TesteNomes
    {
        [TestMethod]
        public void TesteNomeCompleto()
        {
            NomeCompleto nome = new NomeCompleto("Gabriel", "Fonseca");
            Assert.AreEqual("Gabriel Fonseca", nome.EscreverNome());
        }
    }
}
