using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DemoReport
{
    public partial class GauBongContext : DbContext
    {
        public GauBongContext()
            : base("name=GauBongContext1")
        {
        }

        public virtual DbSet<tGau> tGaus { get; set; }
        public virtual DbSet<tTheLoai> tTheLoais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tGau>()
                .Property(e => e.DonGiaNhap)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tGau>()
                .Property(e => e.DonGiaBan)
                .HasPrecision(19, 4);
        }
    }
}
