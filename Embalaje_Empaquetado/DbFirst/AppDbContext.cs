using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DbFirst
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<OITW> OITWs { get; set; }
        public virtual DbSet<ORDR> ORDRs { get; set; }
        public virtual DbSet<RDR1> RDR1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OITW>()
                .Property(e => e.OnHand)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OITW>()
                .Property(e => e.IsCommited)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OITW>()
                .Property(e => e.OnOrder)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OITW>()
                .Property(e => e.Consig)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OITW>()
                .Property(e => e.Counted)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OITW>()
                .Property(e => e.WasCounted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OITW>()
                .Property(e => e.MinStock)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OITW>()
                .Property(e => e.MaxStock)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OITW>()
                .Property(e => e.MinOrder)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OITW>()
                .Property(e => e.AvgPrice)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OITW>()
                .Property(e => e.Locked)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OITW>()
                .Property(e => e.StockValue)
                .HasPrecision(19, 6);

            modelBuilder.Entity<OITW>()
                .Property(e => e.DftBinEnfd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OITW>()
                .Property(e => e.Freezed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DocType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.CANCELED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Handwrtten)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Printed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DocStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.InvntSttus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.VatPercent)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.VatSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.VatSumFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DiscPrcnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DiscSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DiscSumFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DocRate)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DocTotal)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DocTotalFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PaidToDate)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PaidFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.GrosProfit)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.GrosProfFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PartSupply)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Confirmed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.CreateTran)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.SummryType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.UpdInvnt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.UpdCardBal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.InvntDirec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ShowSCN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.SysRate)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.CurSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.VatSumSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DiscSumSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DocTotalSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PaidSys)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.FatherType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.GrosProfSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.IsICT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Volume)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Weight)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.isCrin)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.selfInv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.VatPaid)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.VatPaidFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.VatPaidSys)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.WddStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.TotalExpns)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.TotalExpFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.TotalExpSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Exported)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.NetProc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.AqcsTax)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.AqcsTaxFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.AqcsTaxSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.CashDiscPr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.CashDiscnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.CashDiscFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.CashDiscSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.WTSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.WTSumFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.WTSumSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.RoundDif)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.RoundDifFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.RoundDifSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.CheckDigit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.submitted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PoPrss)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Rounding)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.RevisionPo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PickStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Pick)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BlockDunn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PayBlock)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.MaxDscn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Reserve)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Max1099)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ExpAppl)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ExpApplFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ExpApplSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DeferrTax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.WTApplied)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.WTAppliedF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BoeReserev)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.WTAppliedS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.EquVatSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.EquVatSumF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.EquVatSumS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.VATFirst)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.NnSbAmnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.NnSbAmntSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.NbSbAmntFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ExepAmnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ExepAmntSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ExepAmntFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.CEECFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BaseAmnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BaseAmntSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BaseAmntFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.UseShpdGd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BaseVtAt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BaseVtAtSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BaseVtAtFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.NnSbVAt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.NnSbVAtSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.NbSbVAtFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ExptVAt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ExptVAtSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ExptVAtFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.LYPmtAt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.LYPmtAtSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.LYPmtAtFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ExpAnSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ExpAnSys)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ExpAnFrgn)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmAmnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmAmntSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmAmntFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmDrawn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmPrcnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PaidSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PaidSumFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PaidSumSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmAppl)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmApplFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmApplSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Posted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.IsPaytoBnk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.isIns)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BPNameOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BillToOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ShipToOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.RetInvoice)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.TaxOnExp)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.TaxOnExpFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.TaxOnExpSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.TaxOnExAp)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.TaxOnExApF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.TaxOnExApS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.LastPmnTyp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.UseCorrVat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BlkCredMmo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.OpenForLaC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Excised)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.SrvGpPrcnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DutyStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.AutoCrtFlw)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmVat)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmVatFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmVatSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmAppVat)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmAppVatF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmAppVatS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.InsurOp347)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.IgnRelDoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ResidenNum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.SSIExmpt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PQTGrpHW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ReopOriDoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ReopManCls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DocManClsd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Ordered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.NTSApprov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PayDuMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.EDocGenTyp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.OnlineQuo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.EDocStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.EDocProces)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.EDocCancel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.EDocTest)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DpmAsDscnt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.GTSRlvnt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BaseDisc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BaseDiscSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BaseDiscFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.BaseDiscPr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.SrvTaxRule)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Notify)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.OriginType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.IsReuseNum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.IsReuseNFN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DocDlvry)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PaidDpm)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PaidDpmF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PaidDpmS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.IsAlt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PrintSEPA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.FreeChrg)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.FreeChrgFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.FreeChrgSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.NfeValue)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.FoCTax)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.FoCTaxFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.FoCTaxSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.FoCFrght)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.FoCFrghtFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.FoCFrghtSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Letter)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.SplitTax)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.SplitTaxFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.SplitTaxSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PriceMode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.PoDropPrss)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ExclTaxRep)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.Revision)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ComTrade)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.UseBilAddr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.ComTradeRt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.SplitPmnt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.SelfPosted)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.DPPStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.EWBGenType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.CtActTax)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.CtActTaxFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.CtActTaxSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.EDocType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.U_ORN_Retiro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDR>()
                .Property(e => e.U_MontoFacAfe)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.LineStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.OpenQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Price)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Rate)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DiscPrcnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.LineTotal)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.TotalFrgn)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.OpenSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.OpenSumFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Commission)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.TreeType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.TaxStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.GrossBuyPr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.PriceBefDi)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.OpenCreQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.UseBaseUn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.TotalSumSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.OpenSumSys)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.InvntSttus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.VatPrcnt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.PriceAfVAT)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Height1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Height2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Width1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Width2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Length1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.length2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Volume)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Weight1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Weight2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Factor1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Factor2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Factor3)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Factor4)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.PackQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.UpdInvntry)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.VatSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.VatSumFrgn)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.VatSumSy)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DedVatSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DedVatSumF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DedVatSumS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.IsAqcuistn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DistribSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DstrbSumFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DstrbSumSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.GrssProfit)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.GrssProfSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.GrssProfFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.INMPrice)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DropShip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.TaxType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.BackOrdr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.PickStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.PickOty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.VatAppld)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.VatAppldFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.VatAppldSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.BaseQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.BaseOpnQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.VatDscntPr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.WtLiable)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DeferrTax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.EquVatPer)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.EquVatSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.EquVatSumF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.EquVatSumS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.LineVat)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.LineVatlF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.LineVatS)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.NumPerMsr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.CEECFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.ToStock)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.ToDiff)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.ExciseAmt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.TaxPerUnit)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.TotInclTax)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StckDstSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.ReleasQtty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.LineType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.TranType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StockPrice)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.ConsumeFCT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.LstByDsSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StckINMPr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.LstBINMPr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StckDstFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StckDstSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.LstByDsFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.LstByDsSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StockSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StockSumFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StockSumSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StckSumApp)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StckAppFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StckAppSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StckAppD)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StckAppDFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StckAppDSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.BasePrice)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.GTotal)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.GTotalFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.GTotalSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DistribExp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DescOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DetailsOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.VatWoDpm)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.VatWoDpmFc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.VatWoDpmSc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.TaxOnly)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.WtCalced)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.QtyToShip)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DelivrdQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.OrderedQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.ChgAsmBoMW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.TaxDistSum)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.TaxDistSFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.TaxDistSSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.PostTax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Excisable)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.AssblValue)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.LnExcised)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.StockValue)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.GPTtlBasPr)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.NumPerMsr2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.SpecPrice)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.isSrvCall)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.PQTReqQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.PcQuantity)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.LinManClsd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.VatGrpSrc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.NoInvtryMv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.OpenRtnQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.CredOrigin)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Surpluses)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DefBreak)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.Shortages)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.NeedQty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.PartRetire)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.RetireQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.RetireAPC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.RetirAPCFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.RetirAPCSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.InvQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.OpenInvQty)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.EnSetCost)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.RetCost)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.DistribIS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.ISDistrb)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.ISDistrbFC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.ISDistrbSC)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.IsByPrdct)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.PriceEdit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.LinePoPrss)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.FreeChrgBP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.TaxRelev)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.ThirdParty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.InvQtyOnly)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.ExpOpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.GPBefDisc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.IsPrscGood)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.IsCstmAct)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RDR1>()
                .Property(e => e.U_ORN_TASA)
                .HasPrecision(19, 6);
        }
    }
}
