using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("BroadcastTarget")]
    public partial class BroadcastTarget
    {
        [Key]
        public int BroadcastId { get; set; }
        [Key]
        [StringLength(50)]
        public string TargetId { get; set; }
    }
}
