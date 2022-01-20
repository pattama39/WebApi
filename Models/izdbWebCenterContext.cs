using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApi.Models
{
    public partial class izdbWebCenterContext : DbContext
    {
        public izdbWebCenterContext()
        {
        }

        public izdbWebCenterContext(DbContextOptions<izdbWebCenterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Broadcast> Broadcasts { get; set; }
        public virtual DbSet<BroadcastTarget> BroadcastTargets { get; set; }
        public virtual DbSet<Mdatabase> Mdatabases { get; set; }
        public virtual DbSet<Mhospital> Mhospitals { get; set; }
        public virtual DbSet<Muser> Musers { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_CI_AS");

            modelBuilder.Entity<Broadcast>(entity =>
            {
                entity.Property(e => e.BroadcastDate).HasComment("วันที่จะประกาศ");

                entity.Property(e => e.BroadcastMessage).HasComment("ข้อความ");

                entity.Property(e => e.BroadcastStatusId).HasComment("สถานะ 1=ฉบับร่าง 2=ตั้งเวลา 3=ส่งแล้ว");

                entity.Property(e => e.BroadcastTypeId).HasComment("ประเภทที่จะส่ง 1=ระบบ 2=อัปเดต 3=ประกาศ");
            });

            modelBuilder.Entity<BroadcastTarget>(entity =>
            {
                entity.HasKey(e => new { e.BroadcastId, e.TargetId });
            });

            modelBuilder.Entity<Mhospital>(entity =>
            {
                entity.Property(e => e.ExpireDate).HasComment("วันหมดอายุ");

                entity.Property(e => e.MaxOrganization).HasComment("จำนวนสาขาที่สามารถมีได้สูงสุด");

                entity.Property(e => e.MaxUser).HasComment("จำนวนผู้ใช้งานที่สามารถมีได้สูงสุด");

                entity.Property(e => e.VersionTypeId).HasComment("Version ที่แต่ละโรงพยาบาลใช้");
            });

            modelBuilder.Entity<Muser>(entity =>
            {
                entity.HasKey(e => new { e.Email, e.HospitalId });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
