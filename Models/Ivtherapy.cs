using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("IVTherapy")]
    public partial class Ivtherapy
    {
        [Key]
        [Column("VN")]
        public int Vn { get; set; }
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Column("PBefore")]
        public double? Pbefore { get; set; }
        [Column("PAfter")]
        public double? Pafter { get; set; }
        [Column("BPressureHighBefore")]
        public double? BpressureHighBefore { get; set; }
        [Column("BPressureLowBefore")]
        public double? BpressureLowBefore { get; set; }
        [Column("BPressureHighAfter")]
        public double? BpressureHighAfter { get; set; }
        [Column("BPressureLowAfter")]
        public double? BpressureLowAfter { get; set; }
        [Column(TypeName = "text")]
        public string InjectionPosition { get; set; }
        [Column(TypeName = "text")]
        public string AngiocatheterSize { get; set; }
        [Column(TypeName = "text")]
        public string NumberOfInjections { get; set; }
        [Column(TypeName = "text")]
        public string InjectionlNote { get; set; }
        [Column(TypeName = "text")]
        public string FulidNote { get; set; }
        [Column(TypeName = "text")]
        public string DivestOfNeedleNote { get; set; }
        [StringLength(20)]
        public string MixerCode { get; set; }
        [StringLength(20)]
        public string InjectionCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateToTime { get; set; }
        [StringLength(50)]
        public string PhlebitisScale { get; set; }
        [StringLength(10)]
        public string ParentOrgCode { get; set; }
        public short? BloodPerMeability { get; set; }
        public short? Closure { get; set; }
        [Column("PullIVtubeOut")]
        public short? PullIvtubeOut { get; set; }
        public double? InjectionRate { get; set; }
        public double? InjectionRatePerHour { get; set; }
    }
}
