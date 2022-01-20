using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using WebApi.Modules;

namespace WebApi.Models
{
    public partial class IdentityContext : IdentityDbContext<IdentityUser, Roles, string>
    {
        public IdentityContext()
        {
        }

        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {
        }

        //เปลี่ยนเส้นทาง database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var strConn = GlobalFunctions.GetConnection();
            if (strConn != null)
            {
                optionsBuilder.UseSqlServer(strConn);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Gen Class ใหม่ ต้องมาเพิ่มตรงนี้ด้วย อย่าลืม!! By U 24/01/2019
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("AspNetRoleClaims");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("AspNetRoles");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("AspNetUserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("AspNetUserLogins");
            });

            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("AspNetUserRoles");
            });

            modelBuilder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable("AspNetUsers");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("AspNetUserTokens");
            });
            //end Gen
        }
    }
}
