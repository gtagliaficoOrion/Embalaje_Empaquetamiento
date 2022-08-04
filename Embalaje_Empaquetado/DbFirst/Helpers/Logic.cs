using DbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DbFirst.Helpers
{
    public class Logic
    {
        private readonly AppDbContext context;
        List<RDR1> _ListaProductos = new List<RDR1>();
        public Logic()
        {
            context = new AppDbContext();
        }
        public List<RDR1> Buscar_lista_productos(int CodigoCabezera)
        {
            var oRDR = context.ORDRs.FirstOrDefault(p => p.DocNum == CodigoCabezera);
            var ProductoPedido = context.RDR1.Where(p => p.DocEntry == oRDR.DocEntry);

            foreach (var item in ProductoPedido)
            {
                RDR1 prod = new RDR1();
                prod.DocEntry = item.DocEntry;
                prod.Dscription = item.Dscription;
                prod.ItemCode = item.ItemCode;
                prod.Price = item.Price;
                prod.TaxCode = item.TaxCode;
                prod.Quantity = item.Quantity;

                _ListaProductos.Add(prod);
            }

            return _ListaProductos;
        }
        public OITW BuscarExistencias(string CodProd, string whsCode)
        {
            OITW r = new OITW();
            var oOITW = context.OITWs.Where(p => p.ItemCode == CodProd && whsCode == p.WhsCode);
            foreach (var item in oOITW)
            {
                r.ItemCode = item.ItemCode;
                r.OnHand = item.OnHand;
                r.WhsCode = item.WhsCode;
            }
            return r;
        }
        public List<RDR1> QuitarExistencia(string CodProducto, decimal CantQuitar)
        {
            foreach (var item in _ListaProductos)
            {
                if (item.ItemCode == CodProducto)
                {
                    item.Quantity = item.Quantity - CantQuitar;
                }
            }
            return _ListaProductos;
        }
        public List<RDR1> RevertirCantidad(string CodProducto, decimal CantidadAgg)
        {
            foreach (var item in _ListaProductos)
            {
                if (item.ItemCode == CodProducto)
                {
                    item.Quantity = item.Quantity + CantidadAgg;
                }
            }
            return _ListaProductos;
        }
        public Contenedor CrearContenedor(Tipo_Embalaje tipEmb)
        {
            var ListaProd = new List<RDR1>();
            Contenedor newCont = new Contenedor();
            newCont.Productos = ListaProd;
            newCont._Embalaje = tipEmb;
            return newCont;
        }
    }
}
