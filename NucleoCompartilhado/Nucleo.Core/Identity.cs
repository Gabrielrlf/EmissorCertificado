using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Core
{
    public class Identity
    {
        public Guid Id { get; set; }

        public Identity()
        {
            this.Id = Guid.NewGuid();
        }
        public Identity(Guid id)
        {
            this.Id = id;
        }
    }
}
