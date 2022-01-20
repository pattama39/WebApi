using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MPOSOptions")]
    public partial class Mposoption
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string OrganizationCode { get; set; }
        [StringLength(36)]
        public string DefaultCustomerCodeWhenSalesCash { get; set; }
        [StringLength(20)]
        public string DefaultReceiptHeaderCode { get; set; }
        [StringLength(20)]
        public string DefaultPriceLevelCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column("ProgramTypeID")]
        public int? ProgramTypeId { get; set; }
        public byte? IsAutoRunInvoiceNoWhenSales { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TouchScreenItemWidth { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TouchScreenItemHeight { get; set; }
        public byte? IsMustEnterQueCode { get; set; }
        public byte? IsAskToCloseAccount { get; set; }
        public byte? IsSaveElectronicJournal { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TouchScreenItemGroupWidth { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? TouchScreenItemGroupHeight { get; set; }
        [Column("AutoPurchaseQuantityTypeID")]
        public int? AutoPurchaseQuantityTypeId { get; set; }
        public byte? IsShowCurrentQuantityItemCount { get; set; }
        public byte? IsSingleCustomerPerQue { get; set; }
        [Column("CostTypeID")]
        public byte? CostTypeId { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("BackupTypeID")]
        public byte? BackupTypeId { get; set; }
        [StringLength(255)]
        public string BackupPath { get; set; }
        public byte? IsShowMoneyWhenReceive { get; set; }
        [StringLength(255)]
        public string PrinterForLabel { get; set; }
        public byte? IsOpenCashDrawerWhenReceiveMoney { get; set; }
        public byte? IsShowCostWhenSales { get; set; }
        public byte? IsShowOutstandingWhenSales { get; set; }
        public byte? IsShowPrintReceipt { get; set; }
        public byte? IsAutoPrintLabel { get; set; }
        public byte? IsAutoPrintReceipt { get; set; }
        public byte? IsAutoOrderByBarcode { get; set; }
        [StringLength(50)]
        public string CurrentBuild { get; set; }
        public byte? IsOrderWithLotNo { get; set; }
        public int? ThemeColor { get; set; }
        public int? FontColor { get; set; }
    }
}
