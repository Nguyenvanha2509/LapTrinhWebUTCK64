using Day0Lab_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace Day0Lab_CodeFirst.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        }
        public virtual DbSet<CtHoaDon> CtHoaDons { get; set; }

        public virtual DbSet<HoaDon> HoaDons { get; set; }

        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

        public virtual DbSet<QuanTri> QuanTris { get; set; }

        public virtual DbSet<SanPham> SanPhams { get; set; }



    }
}
