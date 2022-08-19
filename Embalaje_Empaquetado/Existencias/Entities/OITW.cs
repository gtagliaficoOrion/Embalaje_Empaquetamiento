using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Existencias.Entities
{
    public class OITW
    {
        [Key]
        public string ItemCode { get; set; }
        public string WhsCode { get; set; }
        public decimal OnHand { get; set; }
        public decimal IsCommited { get; set; }
        public decimal OnOrder { get; set; }
        public decimal Counted { get; set; }
    }
}
