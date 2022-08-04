using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DbFirst.Models
{
    public class Contenedor
    {
        public List<RDR1> Productos { get; set; } 
        public Tipo_Embalaje _Embalaje { get; set; }
    }
}