using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentidadeAcesso.Core
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public int MyProperty { get; set; }
        public string Password { get; set; }
    }
}
