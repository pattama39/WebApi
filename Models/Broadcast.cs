using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi.Models
{
    [Table("Broadcast")]
    public partial class Broadcast
    {
        [Key]
        public int Id { get; set; }
        public string BroadcastMessage { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BroadcastDate { get; set; }
        [Column("BroadcastStatusID")]
        public short? BroadcastStatusId { get; set; }
        [Column("BroadcastTypeID")]
        public short? BroadcastTypeId { get; set; }
        [StringLength(255)]
        public string BroadcastHeader { get; set; }
    }
}
