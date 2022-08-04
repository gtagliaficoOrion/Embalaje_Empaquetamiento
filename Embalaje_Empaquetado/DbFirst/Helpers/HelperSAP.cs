using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace DbFirst.Helpers
{
    class HelperSAP
    {
        #region *** Datos ***

        SAPbobsCOM.Company oCompany = null;

        #endregion

        #region *** Propiedades ***

        #endregion

        #region *** Metodos Publicos ***

        #endregion

        #region *** Metodos Privados ***

        private string crearNotaDeEntrega(string[] Header, string[] Lineas, out string ErrorMensaje)
        {
            SAPbobsCOM.Documents oDeliveryNotes;
            SAPbobsCOM.Document_Lines oDeliveryNotes_Lines;

            SAPbobsCOM.DocumentPackages oPackages;
            SAPbobsCOM.DocumentPackageItems oPackagesItems;

            ErrorMensaje = string.Empty;
            try
            {
                if (Header.Length == 0)
                {
                    ErrorMensaje = "No existen datos del encabezado para procesar";
                    return string.Empty;
                }
                if (Lineas.Length == 0)
                {
                    ErrorMensaje = "No existen productos para procesar";
                    return string.Empty;
                }
                oDeliveryNotes = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oDeliveryNotes);
                oDeliveryNotes.CardCode = Header[0];
                oDeliveryNotes.DocDate = DateTime.Parse(Header[1]);
                oDeliveryNotes.DocDueDate = DateTime.Parse(Header[2]);
                oDeliveryNotes.TaxDate = DateTime.Parse(Header[3]);
                oDeliveryNotes.NumAtCard = Header[4];
                oDeliveryNotes.DocCurrency = Header[5];
                oDeliveryNotes.FolioPrefixString = Header[6];
                oDeliveryNotes.FolioNumber = int.Parse(Header[7]);
                oDeliveryNotes.SalesPersonCode = int.Parse(Header[8]);
                oDeliveryNotes.DocumentsOwner = int.Parse(Header[9]);
                oDeliveryNotes.Comments = Header[10];
                oDeliveryNotes_Lines = oDeliveryNotes.Lines;

                for (int i = 0; i < Lineas.Length; i++)
                {
                    oDeliveryNotes_Lines.ItemCode = Lineas[0];
                    oDeliveryNotes_Lines.Quantity = double.Parse(Lineas[1]);
                    oDeliveryNotes_Lines.DiscountPercent = double.Parse(Lineas[2]);
                    oDeliveryNotes_Lines.Add();
                    //oDeliveryNotes_Lines.TaxCode = Lineas[3];
                    //oDeliveryNotes_Lines.WarehouseCode = Lineas[4];
                }

                oDeliveryNotes.Add();
                return oCompany.GetNewObjectKey();

                //oPackages = oDeliveryNotes.Packages;
            }
            catch (Exception er)
            {
                ErrorMensaje = "Error: " + er.Message + " Stack " + er.StackTrace;
                return string.Empty;
            }
        }

        private bool crearContenedor(int intDocNum, string[] Header, string[] Lineas, out string ErrorMensaje)
        {

            SAPbobsCOM.Documents oDeliveryNotes;

            SAPbobsCOM.DocumentPackages oPackages;
            SAPbobsCOM.DocumentPackageItems oPackagesItems;


            int errCode = 0;
            ErrorMensaje = string.Empty;
            try
            {
                if (Header.Length == 0)
                {
                    ErrorMensaje = "No existen datos del encabezado para procesar";
                    return false;
                }
                if (Lineas.Length == 0)
                {
                    ErrorMensaje = "No existen productos para procesar";
                    return false;
                }

                if (!oCompany.InTransaction)
                {
                    oCompany.StartTransaction();
                }
                oDeliveryNotes = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oDeliveryNotes);
                oDeliveryNotes.GetByKey(intDocNum);
                oPackages = oDeliveryNotes.Packages;

                // Paquete existente
                oPackages.Number = int.Parse(Header[0]);
                oPackages.Type = Header[1];

                // Contenido del  paquete
                oPackagesItems = oPackages.Items;
                for (int i = 0; i < Lineas.Length; i++)
                {
                    oPackagesItems.ItemCode = Lineas[0];
                    oPackagesItems.Quantity = double.Parse(Lineas[1]);
                    oPackagesItems.Add();
                }

                oDeliveryNotes.Update();

                if (errCode == 0)
                {
                    return true;
                }
                else
                {
                    ErrorMensaje = "validación SBO jornal Entry " + oCompany.GetLastErrorDescription();
                    return false;
                }

            }
            catch (Exception er)
            {
                ErrorMensaje = "Error: " + er.Message + " Stack " + er.StackTrace;
                return false;
            }
        }

        #endregion


    }
}