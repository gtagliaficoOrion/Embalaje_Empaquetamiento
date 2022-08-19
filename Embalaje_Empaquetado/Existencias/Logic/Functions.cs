using Existencias.Context;
using Existencias.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Existencias.Logic
{
    public class Functions
    {
        private readonly AppDbContext context;
        public Functions(AppDbContext context)
        {
            this.context = context;
        }
        public Respuesta BuscarExistencias(string CodProd, string whsCode, string type)
        {
            Respuesta res = new Respuesta();
            OITW r = new OITW();
            var oOITW = context.OITW.Where(p => p.ItemCode == CodProd && whsCode == p.WhsCode);
            foreach (var item in oOITW)
            {
                r.ItemCode = item.ItemCode;
                r.OnHand = item.OnHand;
                r.WhsCode = item.WhsCode;
                r.IsCommited = item.IsCommited;
                r.OnOrder = item.OnOrder;

            }
            switch (type)
            {
                case "c":
                    res.ItemCode = r.ItemCode;
                    res.WhsCode = r.WhsCode;
                    res.Quantity = r.IsCommited;
                    break;

                case "d":
                    res.ItemCode = r.ItemCode;
                    res.WhsCode = r.WhsCode;
                    res.Quantity = r.OnHand;
                    break;

                case "o":
                    res.ItemCode = r.ItemCode;
                    res.WhsCode = r.WhsCode;
                    res.Quantity = r.OnOrder;
                    break;

                case "u":
                    res.ItemCode = r.ItemCode;
                    res.WhsCode = r.WhsCode;
                    res.Quantity = r.Counted;
     
                    break;

                default:                    
                    break;
            }
            return res;
        }

    }

}
