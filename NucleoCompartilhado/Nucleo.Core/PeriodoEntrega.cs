using System;

namespace Nucleo.Core
{
    public class PeriodoEntrega
    {
        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }
 
        public PeriodoEntrega(DateTime dataInicial, int dataFinal)
        {
            DataInicial = dataInicial;
            DataFinal = DataFinal.AddDays(dataFinal);
        }
    }
}