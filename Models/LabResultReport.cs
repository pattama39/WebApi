using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("LabResultReport")]
    public partial class LabResultReport
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("LabReportID")]
        public int LabReportId { get; set; }
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
        [StringLength(50)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [StringLength(20)]
        public string CustomerCode { get; set; }
        [StringLength(150)]
        public string CustomerName { get; set; }
        [Column("LabTypeID")]
        public int? LabTypeId { get; set; }
        public double? LabMin { get; set; }
        public double? LabMax { get; set; }
        [StringLength(20)]
        public string LabGroupCode { get; set; }
        [StringLength(50)]
        public string LabGroupName { get; set; }
        [StringLength(50)]
        public string RequestHeader { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        [Column(TypeName = "text")]
        public string Result1 { get; set; }
        [Column(TypeName = "text")]
        public string Result2 { get; set; }
        [Column(TypeName = "text")]
        public string Result3 { get; set; }
        [Column(TypeName = "text")]
        public string Result4 { get; set; }
        [Column(TypeName = "text")]
        public string Result5 { get; set; }
        [Column(TypeName = "text")]
        public string Reference { get; set; }
        [Column(TypeName = "text")]
        public string RefNote { get; set; }
    }
}
