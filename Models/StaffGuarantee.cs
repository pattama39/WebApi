using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("StaffGuarantee")]
    public partial class StaffGuarantee
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [StringLength(20)]
        public string GuaranteeNo { get; set; }
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
        [Column("GuaranteeTypeID")]
        public int? GuaranteeTypeId { get; set; }
        [StringLength(20)]
        public string StaffCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }
        [StringLength(50)]
        public string GuaranteeName { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? GuaranteeYearlyIncome { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? GuaranteeLimit { get; set; }
        [StringLength(50)]
        public string GuaranteeRelation { get; set; }
        [StringLength(50)]
        public string GuaranteeOccupation { get; set; }
        [StringLength(50)]
        public string GuaranteePosition { get; set; }
        [StringLength(50)]
        public string GuaranteeCurrentAddress1 { get; set; }
        [StringLength(50)]
        public string GuaranteeCurrentAddress2 { get; set; }
        [StringLength(50)]
        public string GuaranteeCurrentTelephone { get; set; }
        [StringLength(50)]
        public string GuaranteeWorkAddress1 { get; set; }
        [StringLength(50)]
        public string GuaranteeWorkAddress2 { get; set; }
        [StringLength(10)]
        public string GuaranteeWorkTelephone { get; set; }
        [StringLength(50)]
        public string SpouseGuaranteeName { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? SpouseGuaranteeYearlyIncome { get; set; }
        [StringLength(50)]
        public string SpouseGuaranteeWorkAddress1 { get; set; }
        [StringLength(50)]
        public string SpouseGuaranteeWorkAddress2 { get; set; }
        [StringLength(50)]
        public string SpouseGuaranteeTelephone { get; set; }
        [StringLength(50)]
        public string OtherGuarantee { get; set; }
        [StringLength(50)]
        public string GuaranteeDetail { get; set; }
        [StringLength(50)]
        public string SpouseGuaranteeOccupation { get; set; }
        [StringLength(50)]
        public string SpouseGuaranteePosition { get; set; }
        public double? GuaranteeCashAmount { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
