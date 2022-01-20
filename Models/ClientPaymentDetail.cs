using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ClientPaymentDetail")]
    public partial class ClientPaymentDetail
    {
        [Key]
        public int Id { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(50)]
        public string ModByCode { get; set; }
        [StringLength(50)]
        public string ModByOrgCode { get; set; }
        [StringLength(50)]
        public string ParentOrgCode { get; set; }
        [StringLength(50)]
        public string TitleName { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(50)]
        public string AmphurName { get; set; }
        [StringLength(50)]
        public string TumbonName { get; set; }
        [StringLength(50)]
        public string ProvinceName { get; set; }
        [StringLength(5)]
        public string PostCode { get; set; }
        [StringLength(50)]
        public string Telephone { get; set; }
        [Column("TaxID")]
        [StringLength(50)]
        public string TaxId { get; set; }
    }
}
