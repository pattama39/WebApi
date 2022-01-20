using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("ItemFX")]
    public partial class ItemFx
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column("ItemFXID")]
        public int ItemFxid { get; set; }
        [StringLength(50)]
        public string ItemGroupCode1 { get; set; }
        [StringLength(50)]
        public string ItemGroupCode2 { get; set; }
        [StringLength(20)]
        public string GenericCode1 { get; set; }
        [StringLength(20)]
        public string GenericCode2 { get; set; }
        [Column("Item1TypeID")]
        public int? Item1TypeId { get; set; }
        [Column("Item2TypeID")]
        public int? Item2TypeId { get; set; }
        [Column("FXLevelID")]
        public byte? FxlevelId { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(20)]
        public string CreateByCode { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModDate { get; set; }
        [StringLength(20)]
        public string ModbyCode { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        [StringLength(10)]
        public string ModByOrgCode { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
