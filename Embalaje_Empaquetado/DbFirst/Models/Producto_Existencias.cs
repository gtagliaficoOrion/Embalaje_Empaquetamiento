using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DbFirst.Models
{
    public class Producto_Existencias
    {
        public Boolean Active { get; set; }
        public int DocEntry { get; set; }
        public string Dscription { get; set; }
        public string ItemCode { get; set; }
        public decimal? Price { get; set; }
        public string TaxCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Existencias { get; set; }

    }
}