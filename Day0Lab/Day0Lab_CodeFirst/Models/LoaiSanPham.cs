using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day0Lab_CodeFirst.Entities
{

    [Table("LoaiSanPham")]
    public partial class LoaiSanPham
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string MaLoai { get; set; } = null!;

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string TenLoai { get; set; }

        [Required]
        public int TrangThai { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
