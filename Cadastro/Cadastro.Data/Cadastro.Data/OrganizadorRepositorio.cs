using Cadastro.Core.Domain.Model.Organizadores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.Data
{
    public class OrganizadorRepositorio : IOrganizadorRepositorio
    {
        public void Adicionar(Organizador organizador)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Organizador> OrganizadoresAtivos()
        {
            var q = new List<Organizador>().AsQueryable();

           return q.Where(OrganizadorScope.TodosAtivos);

        }
    }
}
