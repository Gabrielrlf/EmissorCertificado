using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentidadeAcesso.Core
{
    public class Locatario
    {
        public Locatario(LocatarioId tenantId)
        {
            TenantId = tenantId;
        }
        public LocatarioId TenantId{ get; private set; }
        public string Nome { get; set; }
    }
}
