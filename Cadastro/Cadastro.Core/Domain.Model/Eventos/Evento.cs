using Cadastro.Core.Domain.Model.Organizadores;
using Nucleo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Domain.Model.Eventos
{
   public class Evento
    {
        public EventoId EventoId { get; private set; }
        public OrganizadorId OrganizadorId { get; private set; }
        public string Nome { get; set; }
        public ICollection<Participante> Participantes { get; private set; }
        public PeriodoEntrega Periodo { get; private set; }
        public Evento(EventoId evento, OrganizadorId organizadorId)
        {
            this.EventoId = EventoId;
            OrganizadorId = organizadorId;

            Participantes = new List<Participante>();
        }
        public void AddParticipantes(Participante participante)
        {
            Participantes.Add(participante);
        }
        public void AtualizarListaDeParticipantes(ICollection<Participante> participantes)
        {
            Participantes.Clear();
            Participantes = participantes;
        }
    }
}
