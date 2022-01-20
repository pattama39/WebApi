using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    //Custom Field
    public partial class Roles : IdentityRole
    {
        [Column(TypeName = "text")]
        public string Remark { get; set; }
    }
}
