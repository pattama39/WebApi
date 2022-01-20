using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Reserve")]
    [Index(nameof(Vn), Name = "IX_Reserve")]
    [Index(nameof(AnimalGid), Name = "IX_Reserve_1")]
    public partial class Reserve
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(50)]
        public string ReserveNo { get; set; }
        [Column("CustomerGID")]
        [StringLength(36)]
        public string CustomerGid { get; set; }
        [StringLength(20)]
        public string CustomerCode { get; set; }
        [StringLength(20)]
        public string DocNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReserveDate { get; set; }
        [StringLength(20)]
        public string TransportByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TransportDate { get; set; }
        public double? TotalAmount { get; set; }
        [StringLength(50)]
        public string DiscountText { get; set; }
        public double? DiscountAmount { get; set; }
        [Column("VatTypeID")]
        public byte? VatTypeId { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        [StringLength(20)]
        public string SaleCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string PaymentMethod { get; set; }
        public int? PaymentTerm { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string AreaCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Column("CustomerPONo")]
        [StringLength(50)]
        public string CustomerPono { get; set; }
        public double? NetAmount { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        public byte? IsCome { get; set; }
        public byte? IsCancel { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        [StringLength(50)]
        public string CustomerTel { get; set; }
        [StringLength(20)]
        public string QueGroupCode { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("AnimalGID")]
        [StringLength(36)]
        public string AnimalGid { get; set; }
        [Column("VN")]
        public int? Vn { get; set; }
        [StringLength(50)]
        public string ReserveRefNo { get; set; }
        public double? Price { get; set; }
        public double? ReserveAmount { get; set; }
        public double? DownReceiveAmount { get; set; }
        [StringLength(50)]
        public string ItemCode { get; set; }
        public int? ExpireDateReserve { get; set; }
        public double? AddReserveAmount { get; set; }
        public byte? IsFinish { get; set; }
        public byte? IsExpire { get; set; }
        [Column("ReserveTypeID")]
        public byte? ReserveTypeId { get; set; }
    }
}
