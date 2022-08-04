namespace DbFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OITW")]
    public partial class OITW
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ItemCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string WhsCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OnHand { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IsCommited { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OnOrder { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Consig { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Counted { get; set; }

        [StringLength(1)]
        public string WasCounted { get; set; }
       
        public short? UserSign { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MinStock { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaxStock { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MinOrder { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvgPrice { get; set; }

        [StringLength(1)]
        public string Locked { get; set; }

        [StringLength(15)]
        public string BalInvntAc { get; set; }

        [StringLength(15)]
        public string SaleCostAc { get; set; }

        [StringLength(15)]
        public string TransferAc { get; set; }

        [StringLength(15)]
        public string RevenuesAc { get; set; }

        [StringLength(15)]
        public string VarianceAc { get; set; }

        [StringLength(15)]
        public string DecreasAc { get; set; }

        [StringLength(15)]
        public string IncreasAc { get; set; }

        [StringLength(15)]
        public string ReturnAc { get; set; }

        [StringLength(15)]
        public string ExpensesAc { get; set; }

        [StringLength(15)]
        public string EURevenuAc { get; set; }

        [StringLength(15)]
        public string EUExpensAc { get; set; }

        [StringLength(15)]
        public string FrRevenuAc { get; set; }

        [StringLength(15)]
        public string FrExpensAc { get; set; }

        [StringLength(15)]
        public string ExmptIncom { get; set; }

        [StringLength(15)]
        public string PriceDifAc { get; set; }

        [StringLength(15)]
        public string ExchangeAc { get; set; }

        [StringLength(15)]
        public string BalanceAcc { get; set; }

        [StringLength(15)]
        public string PurchaseAc { get; set; }

        [StringLength(15)]
        public string PAReturnAc { get; set; }

        [StringLength(15)]
        public string PurchOfsAc { get; set; }

        [StringLength(15)]
        public string ShpdGdsAct { get; set; }

        [StringLength(15)]
        public string VatRevAct { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StockValue { get; set; }

        [StringLength(15)]
        public string DecresGlAc { get; set; }

        [StringLength(15)]
        public string IncresGlAc { get; set; }

        [StringLength(15)]
        public string StokRvlAct { get; set; }

        [StringLength(15)]
        public string StkOffsAct { get; set; }

        [StringLength(15)]
        public string WipAcct { get; set; }

        [StringLength(15)]
        public string WipVarAcct { get; set; }

        [StringLength(15)]
        public string CostRvlAct { get; set; }

        [StringLength(15)]
        public string CstOffsAct { get; set; }

        [StringLength(15)]
        public string ExpClrAct { get; set; }

        [StringLength(15)]
        public string ExpOfstAct { get; set; }

        [StringLength(20)]
        public string Object { get; set; }

        public int? logInstanc { get; set; }

        public DateTime? createDate { get; set; }

        public short? userSign2 { get; set; }

        public DateTime? updateDate { get; set; }

        [StringLength(15)]
        public string ARCMAct { get; set; }

        [StringLength(15)]
        public string ARCMFrnAct { get; set; }

        [StringLength(15)]
        public string ARCMEUAct { get; set; }

        [StringLength(15)]
        public string ARCMExpAct { get; set; }

        [StringLength(15)]
        public string APCMAct { get; set; }

        [StringLength(15)]
        public string APCMFrnAct { get; set; }

        [StringLength(15)]
        public string APCMEUAct { get; set; }

        [StringLength(15)]
        public string RevRetAct { get; set; }

        [StringLength(15)]
        public string NegStckAct { get; set; }

        [StringLength(15)]
        public string StkInTnAct { get; set; }

        [StringLength(15)]
        public string PurBalAct { get; set; }

        [StringLength(15)]
        public string WhICenAct { get; set; }

        [StringLength(15)]
        public string WhOCenAct { get; set; }

        [StringLength(15)]
        public string WipOffset { get; set; }

        [StringLength(15)]
        public string StockOffst { get; set; }

        public int? DftBinAbs { get; set; }

        [StringLength(1)]
        public string DftBinEnfd { get; set; }

        [StringLength(1)]
        public string Freezed { get; set; }

        public int? FreezeDoc { get; set; }

        [StringLength(15)]
        public string FreeChrgSA { get; set; }

        [StringLength(15)]
        public string FreeChrgPU { get; set; }

        [StringLength(2)]
        public string U_ORN_UPDATE { get; set; }
    }
}
