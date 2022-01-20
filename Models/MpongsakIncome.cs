using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("MPongsakIncome")]
    public partial class MpongsakIncome
    {
        [Key]
        [StringLength(10)]
        public string CreateByOrgCode { get; set; }
        [Key]
        [Column(TypeName = "smalldatetime")]
        public DateTime IncomeDate { get; set; }
        public short? IsSystem { get; set; }
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
        public float? CourseStaff { get; set; }
        public float? CourseDoc { get; set; }
        public float? CourseAcc { get; set; }
        public float? CusBuyMed { get; set; }
        public float? MeetDoc { get; set; }
        public float? DisCourseStaff { get; set; }
        public float? DisCourseDoc { get; set; }
        public float? DisCourseAcc { get; set; }
        public float? DisCusBuyMed { get; set; }
        public float? DisMeetDoc { get; set; }
        public float? NetCourseStaff { get; set; }
        public float? NetCourseDoc { get; set; }
        public float? NetCourseAcc { get; set; }
        public float? NetCusBuyMed { get; set; }
        public float? NetReturnMed { get; set; }
        public float? NetMeetDoc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateSave { get; set; }
        [StringLength(50)]
        public string SaveBy { get; set; }
        public byte? IsSyncToServer { get; set; }
    }
}
