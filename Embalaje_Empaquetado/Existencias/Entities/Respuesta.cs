using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Existencias.Entities
{
    public class Respuesta
    {
        public string ItemCode { get; set; }
        public string WhsCode { get; set; }
        public decimal Quantity { get; set; }

    }
}
