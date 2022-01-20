using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MAccount")]
    public partial class Maccount
    {
        [Key]
        [StringLength(20)]
        public string AccountCode { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
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
        [StringLength(20)]
        public string AccountSubGroupCode { get; set; }
        [StringLength(255)]
        public string AccountName { get; set; }
        [StringLength(50)]
        public string AccountName2 { get; set; }
        [StringLength(255)]
        public string AccountDescription { get; set; }
        [StringLength(20)]
        public string ParentAccountCode { get; set; }
        public int? AccountLevel { get; set; }
        public byte? IsHeader { get; set; }
        [Column("AccountCashFlowTypeID")]
        public byte? AccountCashFlowTypeId { get; set; }
        public byte? IsSystem { get; set; }
        public byte? Inactive { get; set; }
        [StringLength(50)]
        public string BudgeteCause { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Budget1 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Budget2 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Budget3 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Budget4 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Budget5 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Budget6 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Budget7 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Budget8 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Budget9 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Budget10 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Budget11 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Budget12 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Balance1 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Balance2 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Balance3 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Balance4 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Balance5 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Balance6 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Balance7 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Balance8 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Balance9 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Balance10 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Balance11 { get; set; }
        [Column(TypeName = "numeric(18, 5)")]
        public decimal? Balance12 { get; set; }
        [StringLength(255)]
        public string LastBudgetCause { get; set; }
        public double? LastBudget1 { get; set; }
        public double? LastBudget2 { get; set; }
        public double? LastBudget3 { get; set; }
        public double? LastBudget4 { get; set; }
        public double? LastBudget5 { get; set; }
        public double? LastBudget6 { get; set; }
        public double? LastBudget7 { get; set; }
        public double? LastBudget8 { get; set; }
        public double? LastBudget9 { get; set; }
        public double? LastBudget10 { get; set; }
        public double? LastBudget11 { get; set; }
        public double? LastBudget12 { get; set; }
        public double? LastBalance1 { get; set; }
        public double? LastBalance2 { get; set; }
        public double? LastBalance3 { get; set; }
        public double? LastBalance4 { get; set; }
        public double? LastBalance5 { get; set; }
        public double? LastBalance6 { get; set; }
        public double? LastBalance7 { get; set; }
        public double? LastBalance8 { get; set; }
        public double? LastBalance9 { get; set; }
        public double? LastBalance10 { get; set; }
        public double? LastBalance11 { get; set; }
        public double? LastBalance12 { get; set; }
        public double? DebitAmount { get; set; }
        public double? CreditAmount { get; set; }
        public double? LastBudget13 { get; set; }
        public double? LastBudget14 { get; set; }
        public double? LastBudget15 { get; set; }
        public double? LastBudget16 { get; set; }
        public double? LastBudget17 { get; set; }
        public double? LastBudget18 { get; set; }
        public double? LastBudget19 { get; set; }
        public double? LastBudget20 { get; set; }
        public double? LastBudget21 { get; set; }
        public double? LastBudget22 { get; set; }
        public double? LastBudget23 { get; set; }
        public double? LastBudget24 { get; set; }
        public double? LastBalance13 { get; set; }
        public double? LastBalance14 { get; set; }
        public double? LastBalance15 { get; set; }
        public double? LastBalance16 { get; set; }
        public double? LastBalance17 { get; set; }
        public double? LastBalance18 { get; set; }
        public double? LastBalance19 { get; set; }
        public double? LastBalance20 { get; set; }
        public double? LastBalance21 { get; set; }
        public double? LastBalance22 { get; set; }
        public double? LastBalance23 { get; set; }
        public double? LastBalance24 { get; set; }
        public double? Balance13 { get; set; }
        public double? Balance14 { get; set; }
        public double? Balance15 { get; set; }
        public double? Balance16 { get; set; }
        public double? Balance17 { get; set; }
        public double? Balance18 { get; set; }
        public double? Balance19 { get; set; }
        public double? Balance20 { get; set; }
        public double? Balance21 { get; set; }
        public double? Balance22 { get; set; }
        public double? Balance23 { get; set; }
        public double? Balance24 { get; set; }
        [StringLength(20)]
        public string AccountGroupCode { get; set; }
        public double? Budget13 { get; set; }
        public double? Budget14 { get; set; }
        public double? Budget15 { get; set; }
        public double? Budget16 { get; set; }
        public double? Budget17 { get; set; }
        public double? Budget18 { get; set; }
        public double? Budget19 { get; set; }
        public double? Budget20 { get; set; }
        public double? Budget21 { get; set; }
        public double? Budget22 { get; set; }
        public double? Budget23 { get; set; }
        public double? Budget24 { get; set; }
        [Column("AccountTypeID")]
        public short? AccountTypeId { get; set; }
        public double? CreditAmount1 { get; set; }
        public double? DebitAmount1 { get; set; }
        public double? CreditAmount2 { get; set; }
        public double? DebitAmount2 { get; set; }
        public double? CreditAmount3 { get; set; }
        public double? DebitAmount3 { get; set; }
        public double? CreditAmount4 { get; set; }
        public double? DebitAmount4 { get; set; }
        public double? CreditAmount5 { get; set; }
        public double? DebitAmount5 { get; set; }
        public double? CreditAmount6 { get; set; }
        public double? DebitAmount6 { get; set; }
        public double? CreditAmount7 { get; set; }
        public double? DebitAmount7 { get; set; }
        public double? CreditAmount8 { get; set; }
        public double? DebitAmount8 { get; set; }
        public double? CreditAmount9 { get; set; }
        public double? DebitAmount9 { get; set; }
        public double? CreditAmount10 { get; set; }
        public double? DebitAmount10 { get; set; }
        public double? CreditAmount11 { get; set; }
        public double? DebitAmount11 { get; set; }
        public double? CreditAmount12 { get; set; }
        public double? DebitAmount12 { get; set; }
        public double? CreditAmount13 { get; set; }
        public double? DebitAmount13 { get; set; }
        public double? CreditAmount14 { get; set; }
        public double? DebitAmount14 { get; set; }
        public double? CreditAmount15 { get; set; }
        public double? DebitAmount15 { get; set; }
        public double? CreditAmount16 { get; set; }
        public double? DebitAmount16 { get; set; }
        public double? CreditAmount17 { get; set; }
        public double? DebitAmount17 { get; set; }
        public double? CreditAmount18 { get; set; }
        public double? DebitAmount18 { get; set; }
        public double? CreditAmount19 { get; set; }
        public double? DebitAmount19 { get; set; }
        public double? CreditAmount20 { get; set; }
        public double? DebitAmount20 { get; set; }
        public double? CreditAmount21 { get; set; }
        public double? DebitAmount21 { get; set; }
        public double? CreditAmount22 { get; set; }
        public double? DebitAmount22 { get; set; }
        public double? CreditAmount23 { get; set; }
        public double? DebitAmount23 { get; set; }
        public double? CreditAmount24 { get; set; }
        public double? DebitAmount24 { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
