using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DbFirst;
using DbFirst.Helpers;
using DbFirst.Models;
using Newtonsoft.Json;

namespace DbFirst.Controllers
{
    public class ODLNsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: ODLNs
        public ActionResult Index()
        {
            return View(db.ODLNs.ToList());
        }
        public JsonResult GetProductos(int DocNum)
        {

            var oDLN = db.ODLNs.FirstOrDefault(p => p.DocNum == DocNum);
            List<Producto_Existencias> _ListaProductos = new List<Producto_Existencias>();
            Logic newlogic = new Logic();
            if (oDLN != null)
            {
                var ProductoPedido = db.DLN1.Where(p => p.DocEntry == oDLN.DocEntry);

                foreach (var item in ProductoPedido)
                {
                    Producto_Existencias prod = new Producto_Existencias();
                    prod.DocEntry = item.DocEntry;
                    prod.Dscription = item.Dscription;
                    prod.ItemCode = item.ItemCode;
                    prod.Price = item.Price;
                    prod.TaxCode = item.TaxCode;
                    prod.Quantity = item.Quantity;
                    var exist = newlogic.BuscarExistencias(item.ItemCode, item.WhsCode);
                    prod.Existencias = exist.OnHand;
                    if (prod.Existencias < prod.Quantity)
                    {
                        prod.Active = true;
                    }
                    else
                    {
                        prod.Active = false;

                    }
                    _ListaProductos.Add(prod);
                }
            }


            return Json(new
            {
                data = _ListaProductos
            }, JsonRequestBehavior.AllowGet);

        }

        // GET: ODLNs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ODLN oDLN = db.ODLNs.Find(id);
            if (oDLN == null)
            {
                return HttpNotFound();
            }
            return View(oDLN);
        }

        // GET: ODLNs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ODLNs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DocEntry,DocNum,DocType,CANCELED,Handwrtten,Printed,DocStatus,InvntSttus,Transfered,ObjType,DocDate,DocDueDate,CardCode,CardName,Address,NumAtCard,VatPercent,VatSum,VatSumFC,DiscPrcnt,DiscSum,DiscSumFC,DocCur,DocRate,DocTotal,DocTotalFC,PaidToDate,PaidFC,GrosProfit,GrosProfFC,Ref1,Ref2,Comments,JrnlMemo,TransId,ReceiptNum,GroupNum,DocTime,SlpCode,TrnspCode,PartSupply,Confirmed,GrossBase,ImportEnt,CreateTran,SummryType,UpdInvnt,UpdCardBal,Instance,Flags,InvntDirec,CntctCode,ShowSCN,FatherCard,SysRate,CurSource,VatSumSy,DiscSumSy,DocTotalSy,PaidSys,FatherType,GrosProfSy,UpdateDate,IsICT,CreateDate,Volume,VolUnit,Weight,WeightUnit,Series,TaxDate,Filler,DataSource,StampNum,isCrin,FinncPriod,UserSign,selfInv,VatPaid,VatPaidFC,VatPaidSys,UserSign2,WddStatus,draftKey,TotalExpns,TotalExpFC,TotalExpSC,DunnLevel,Address2,LogInstanc,Exported,StationID,Indicator,NetProc,AqcsTax,AqcsTaxFC,AqcsTaxSC,CashDiscPr,CashDiscnt,CashDiscFC,CashDiscSC,ShipToCode,LicTradNum,PaymentRef,WTSum,WTSumFC,WTSumSC,RoundDif,RoundDifFC,RoundDifSy,CheckDigit,Form1099,Box1099,submitted,PoPrss,Rounding,RevisionPo,Segment,ReqDate,CancelDate,PickStatus,Pick,BlockDunn,PeyMethod,PayBlock,PayBlckRef,MaxDscn,Reserve,Max1099,CntrlBnk,PickRmrk,ISRCodLine,ExpAppl,ExpApplFC,ExpApplSC,Project,DeferrTax,LetterNum,FromDate,ToDate,WTApplied,WTAppliedF,BoeReserev,AgentCode,WTAppliedS,EquVatSum,EquVatSumF,EquVatSumS,Installmnt,VATFirst,NnSbAmnt,NnSbAmntSC,NbSbAmntFC,ExepAmnt,ExepAmntSC,ExepAmntFC,VatDate,CorrExt,CorrInv,NCorrInv,CEECFlag,BaseAmnt,BaseAmntSC,BaseAmntFC,CtlAccount,BPLId,BPLName,VATRegNum,TxInvRptNo,TxInvRptDt,KVVATCode,WTDetails,SumAbsId,SumRptDate,PIndicator,ManualNum,UseShpdGd,BaseVtAt,BaseVtAtSC,BaseVtAtFC,NnSbVAt,NnSbVAtSC,NbSbVAtFC,ExptVAt,ExptVAtSC,ExptVAtFC,LYPmtAt,LYPmtAtSC,LYPmtAtFC,ExpAnSum,ExpAnSys,ExpAnFrgn,DocSubType,DpmStatus,DpmAmnt,DpmAmntSC,DpmAmntFC,DpmDrawn,DpmPrcnt,PaidSum,PaidSumFc,PaidSumSc,FolioPref,FolioNum,DpmAppl,DpmApplFc,DpmApplSc,LPgFolioN,Header,Footer,Posted,OwnerCode,BPChCode,BPChCntc,PayToCode,IsPaytoBnk,BnkCntry,BankCode,BnkAccount,BnkBranch,isIns,TrackNo,VersionNum,LangCode,BPNameOW,BillToOW,ShipToOW,RetInvoice,ClsDate,MInvNum,MInvDate,SeqCode,Serial,SeriesStr,SubStr,Model,TaxOnExp,TaxOnExpFc,TaxOnExpSc,TaxOnExAp,TaxOnExApF,TaxOnExApS,LastPmnTyp,LndCstNum,UseCorrVat,BlkCredMmo,OpenForLaC,Excised,ExcRefDate,ExcRmvTime,SrvGpPrcnt,DepositNum,CertNum,DutyStatus,AutoCrtFlw,FlwRefDate,FlwRefNum,VatJENum,DpmVat,DpmVatFc,DpmVatSc,DpmAppVat,DpmAppVatF,DpmAppVatS,InsurOp347,IgnRelDoc,BuildDesc,ResidenNum,Checker,Payee,CopyNumber,SSIExmpt,PQTGrpSer,PQTGrpNum,PQTGrpHW,ReopOriDoc,ReopManCls,DocManClsd,ClosingOpt,SpecDate,Ordered,NTSApprov,NTSWebSite,NTSeTaxNo,NTSApprNo,PayDuMonth,ExtraMonth,ExtraDays,CdcOffset,SignMsg,SignDigest,CertifNum,KeyVersion,EDocGenTyp,ESeries,EDocNum,EDocExpFrm,OnlineQuo,POSEqNum,POSManufSN,POSCashN,EDocStatus,EDocCntnt,EDocProces,EDocErrCod,EDocErrMsg,EDocCancel,EDocTest,EDocPrefix,CUP,CIG,DpmAsDscnt,Attachment,AtcEntry,SupplCode,GTSRlvnt,BaseDisc,BaseDiscSc,BaseDiscFc,BaseDiscPr,CreateTS,UpdateTS,SrvTaxRule,AnnInvDecR,Supplier,Releaser,Receiver,ToWhsCode,AssetDate,Requester,ReqName,Branch,Department,Email,Notify,ReqType,OriginType,IsReuseNum,IsReuseNFN,DocDlvry,PaidDpm,PaidDpmF,PaidDpmS,EnvTypeNFe,AgrNo,IsAlt,AltBaseTyp,AltBaseEnt,AuthCode,StDlvDate,StDlvTime,EndDlvDate,EndDlvTime,VclPlate,ElCoStatus,AtDocType,ElCoMsg,PrintSEPA,FreeChrg,FreeChrgFC,FreeChrgSC,NfeValue,FiscDocNum,RelatedTyp,RelatedEnt,CCDEntry,NfePrntFo,ZrdAbs,POSRcptNo,FoCTax,FoCTaxFC,FoCTaxSC,TpCusPres,ExcDocDate,FoCFrght,FoCFrghtFC,FoCFrghtSC,InterimTyp,PTICode,Letter,FolNumFrom,FolNumTo,FolSeries,SplitTax,SplitTaxFC,SplitTaxSC,ToBinCode,PriceMode,PoDropPrss,PermitNo,MYFtype,DocTaxID,DateReport,RepSection,ExclTaxRep,PosCashReg,DmpTransID,ECommerBP,EComerGSTN,Revision,RevRefNo,RevRefDate,RevCreRefN,RevCreRefD,TaxInvNo,FrmBpDate,GSTTranTyp,BaseType,BaseEntry,ComTrade,UseBilAddr,IssReason,ComTradeRt,SplitPmnt,SOIWizId,SelfPosted,EnBnkAcct,EncryptIV,DPPStatus,EWBGenType,SAPPassprt,CtActTax,CtActTaxFC,CtActTaxSC,EDocType,U_ORN_NCON,U_ORN_PRE,U_ORN_SERI,U_ORN_TRAN,U_ORN_FAFE,U_ORN_COMP,U_ORN_CISLR,U_ORN_COMPDATE,U_ORN_FISLR,U_ORN_COMPCONTDATE,U_ORN_FCISLR,U_ORN_RZ,U_ORN_SerialIF,U_ORN_CerISLR,U_ORN_Retiro,U_ORN_TDOC,U_ORN_NIMP,U_ORN_NumExp,U_ORN_FacImp,U_FecFacAfe,U_MontoFacAfe,U_NumControlFacAfe,U_ORN_UPDATE,U_ORN_ID,U_ORN_CODCAJA,U_ORN_CODDPTO")] ODLN oDLN)
        {
            if (ModelState.IsValid)
            {
                db.ODLNs.Add(oDLN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oDLN);
        }

        // GET: ODLNs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ODLN oDLN = db.ODLNs.Find(id);
            if (oDLN == null)
            {
                return HttpNotFound();
            }
            return View(oDLN);
        }

        // POST: ODLNs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DocEntry,DocNum,DocType,CANCELED,Handwrtten,Printed,DocStatus,InvntSttus,Transfered,ObjType,DocDate,DocDueDate,CardCode,CardName,Address,NumAtCard,VatPercent,VatSum,VatSumFC,DiscPrcnt,DiscSum,DiscSumFC,DocCur,DocRate,DocTotal,DocTotalFC,PaidToDate,PaidFC,GrosProfit,GrosProfFC,Ref1,Ref2,Comments,JrnlMemo,TransId,ReceiptNum,GroupNum,DocTime,SlpCode,TrnspCode,PartSupply,Confirmed,GrossBase,ImportEnt,CreateTran,SummryType,UpdInvnt,UpdCardBal,Instance,Flags,InvntDirec,CntctCode,ShowSCN,FatherCard,SysRate,CurSource,VatSumSy,DiscSumSy,DocTotalSy,PaidSys,FatherType,GrosProfSy,UpdateDate,IsICT,CreateDate,Volume,VolUnit,Weight,WeightUnit,Series,TaxDate,Filler,DataSource,StampNum,isCrin,FinncPriod,UserSign,selfInv,VatPaid,VatPaidFC,VatPaidSys,UserSign2,WddStatus,draftKey,TotalExpns,TotalExpFC,TotalExpSC,DunnLevel,Address2,LogInstanc,Exported,StationID,Indicator,NetProc,AqcsTax,AqcsTaxFC,AqcsTaxSC,CashDiscPr,CashDiscnt,CashDiscFC,CashDiscSC,ShipToCode,LicTradNum,PaymentRef,WTSum,WTSumFC,WTSumSC,RoundDif,RoundDifFC,RoundDifSy,CheckDigit,Form1099,Box1099,submitted,PoPrss,Rounding,RevisionPo,Segment,ReqDate,CancelDate,PickStatus,Pick,BlockDunn,PeyMethod,PayBlock,PayBlckRef,MaxDscn,Reserve,Max1099,CntrlBnk,PickRmrk,ISRCodLine,ExpAppl,ExpApplFC,ExpApplSC,Project,DeferrTax,LetterNum,FromDate,ToDate,WTApplied,WTAppliedF,BoeReserev,AgentCode,WTAppliedS,EquVatSum,EquVatSumF,EquVatSumS,Installmnt,VATFirst,NnSbAmnt,NnSbAmntSC,NbSbAmntFC,ExepAmnt,ExepAmntSC,ExepAmntFC,VatDate,CorrExt,CorrInv,NCorrInv,CEECFlag,BaseAmnt,BaseAmntSC,BaseAmntFC,CtlAccount,BPLId,BPLName,VATRegNum,TxInvRptNo,TxInvRptDt,KVVATCode,WTDetails,SumAbsId,SumRptDate,PIndicator,ManualNum,UseShpdGd,BaseVtAt,BaseVtAtSC,BaseVtAtFC,NnSbVAt,NnSbVAtSC,NbSbVAtFC,ExptVAt,ExptVAtSC,ExptVAtFC,LYPmtAt,LYPmtAtSC,LYPmtAtFC,ExpAnSum,ExpAnSys,ExpAnFrgn,DocSubType,DpmStatus,DpmAmnt,DpmAmntSC,DpmAmntFC,DpmDrawn,DpmPrcnt,PaidSum,PaidSumFc,PaidSumSc,FolioPref,FolioNum,DpmAppl,DpmApplFc,DpmApplSc,LPgFolioN,Header,Footer,Posted,OwnerCode,BPChCode,BPChCntc,PayToCode,IsPaytoBnk,BnkCntry,BankCode,BnkAccount,BnkBranch,isIns,TrackNo,VersionNum,LangCode,BPNameOW,BillToOW,ShipToOW,RetInvoice,ClsDate,MInvNum,MInvDate,SeqCode,Serial,SeriesStr,SubStr,Model,TaxOnExp,TaxOnExpFc,TaxOnExpSc,TaxOnExAp,TaxOnExApF,TaxOnExApS,LastPmnTyp,LndCstNum,UseCorrVat,BlkCredMmo,OpenForLaC,Excised,ExcRefDate,ExcRmvTime,SrvGpPrcnt,DepositNum,CertNum,DutyStatus,AutoCrtFlw,FlwRefDate,FlwRefNum,VatJENum,DpmVat,DpmVatFc,DpmVatSc,DpmAppVat,DpmAppVatF,DpmAppVatS,InsurOp347,IgnRelDoc,BuildDesc,ResidenNum,Checker,Payee,CopyNumber,SSIExmpt,PQTGrpSer,PQTGrpNum,PQTGrpHW,ReopOriDoc,ReopManCls,DocManClsd,ClosingOpt,SpecDate,Ordered,NTSApprov,NTSWebSite,NTSeTaxNo,NTSApprNo,PayDuMonth,ExtraMonth,ExtraDays,CdcOffset,SignMsg,SignDigest,CertifNum,KeyVersion,EDocGenTyp,ESeries,EDocNum,EDocExpFrm,OnlineQuo,POSEqNum,POSManufSN,POSCashN,EDocStatus,EDocCntnt,EDocProces,EDocErrCod,EDocErrMsg,EDocCancel,EDocTest,EDocPrefix,CUP,CIG,DpmAsDscnt,Attachment,AtcEntry,SupplCode,GTSRlvnt,BaseDisc,BaseDiscSc,BaseDiscFc,BaseDiscPr,CreateTS,UpdateTS,SrvTaxRule,AnnInvDecR,Supplier,Releaser,Receiver,ToWhsCode,AssetDate,Requester,ReqName,Branch,Department,Email,Notify,ReqType,OriginType,IsReuseNum,IsReuseNFN,DocDlvry,PaidDpm,PaidDpmF,PaidDpmS,EnvTypeNFe,AgrNo,IsAlt,AltBaseTyp,AltBaseEnt,AuthCode,StDlvDate,StDlvTime,EndDlvDate,EndDlvTime,VclPlate,ElCoStatus,AtDocType,ElCoMsg,PrintSEPA,FreeChrg,FreeChrgFC,FreeChrgSC,NfeValue,FiscDocNum,RelatedTyp,RelatedEnt,CCDEntry,NfePrntFo,ZrdAbs,POSRcptNo,FoCTax,FoCTaxFC,FoCTaxSC,TpCusPres,ExcDocDate,FoCFrght,FoCFrghtFC,FoCFrghtSC,InterimTyp,PTICode,Letter,FolNumFrom,FolNumTo,FolSeries,SplitTax,SplitTaxFC,SplitTaxSC,ToBinCode,PriceMode,PoDropPrss,PermitNo,MYFtype,DocTaxID,DateReport,RepSection,ExclTaxRep,PosCashReg,DmpTransID,ECommerBP,EComerGSTN,Revision,RevRefNo,RevRefDate,RevCreRefN,RevCreRefD,TaxInvNo,FrmBpDate,GSTTranTyp,BaseType,BaseEntry,ComTrade,UseBilAddr,IssReason,ComTradeRt,SplitPmnt,SOIWizId,SelfPosted,EnBnkAcct,EncryptIV,DPPStatus,EWBGenType,SAPPassprt,CtActTax,CtActTaxFC,CtActTaxSC,EDocType,U_ORN_NCON,U_ORN_PRE,U_ORN_SERI,U_ORN_TRAN,U_ORN_FAFE,U_ORN_COMP,U_ORN_CISLR,U_ORN_COMPDATE,U_ORN_FISLR,U_ORN_COMPCONTDATE,U_ORN_FCISLR,U_ORN_RZ,U_ORN_SerialIF,U_ORN_CerISLR,U_ORN_Retiro,U_ORN_TDOC,U_ORN_NIMP,U_ORN_NumExp,U_ORN_FacImp,U_FecFacAfe,U_MontoFacAfe,U_NumControlFacAfe,U_ORN_UPDATE,U_ORN_ID,U_ORN_CODCAJA,U_ORN_CODDPTO")] ODLN oDLN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oDLN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oDLN);
        }

        // GET: ODLNs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ODLN oDLN = db.ODLNs.Find(id);
            if (oDLN == null)
            {
                return HttpNotFound();
            }
            return View(oDLN);
        }

        // POST: ODLNs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ODLN oDLN = db.ODLNs.Find(id);
            db.ODLNs.Remove(oDLN);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
