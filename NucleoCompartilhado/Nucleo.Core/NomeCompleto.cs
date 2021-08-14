using System;

namespace Nucleo.Core
{
    public class NomeCompleto
    {
        public NomeCompleto(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string EscreverNome()
        {
            return $"{Nome} {Sobrenome}";
        }
    }
}
