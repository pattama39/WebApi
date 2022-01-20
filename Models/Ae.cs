﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("AE")]
    public partial class Ae
    {
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        [StringLength(20)]
        public string ModByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [Key]
        [Column("AENo")]
        [StringLength(50)]
        public string Aeno { get; set; }
        [Column("AEDate", TypeName = "smalldatetime")]
        public DateTime? Aedate { get; set; }
        [StringLength(20)]
        public string VendorCode { get; set; }
        [StringLength(20)]
        public string DepartmentCode { get; set; }
        [StringLength(50)]
        public string FactionCode { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [Column(TypeName = "text")]
        public string Remark { get; set; }
        public double? BeginAmount { get; set; }
        public double? UseAmount { get; set; }
        public double? RemainAmount { get; set; }
        public double? VatAmount { get; set; }
        [Column("DocStatusID")]
        public byte? DocStatusId { get; set; }
        public byte? IsSyncToServer { get; set; }
        [Column("RefTypeID")]
        public short? RefTypeId { get; set; }
        [StringLength(50)]
        public string RefNo { get; set; }
        public int? ReferenceIndex { get; set; }
        public double? CashAmount { get; set; }
        public double? ChequeAmount { get; set; }
        public double? CreditAmount { get; set; }
        public double? BankAmount { get; set; }
        public byte? IsReimburse { get; set; }
    }
}
