namespace DemoReport
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tGau")]
    public partial class tGau
    {
        [Key]
        [StringLength(10)]
        public string MaGau { get; set; }

        [StringLength(200)]
        public string TenGau { get; set; }

        [StringLength(10)]
        public string MaLoai { get; set; }

        [StringLength(10)]
        public string MaNCC { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGiaNhap { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGiaBan { get; set; }

        [StringLength(50)]
        public string KichThuoc { get; set; }

        [StringLength(200)]
        public string Anh { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public virtual tTheLoai tTheLoai { get; set; }
    }
}
