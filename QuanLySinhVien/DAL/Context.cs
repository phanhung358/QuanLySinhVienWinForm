using QuanLySinhVien.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    class Context : DbContext
    {
        public Context()
          : base("Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True;User ID=sa,Password=123")
        {

        }
        public DbSet<MonHoc> MonHocDbset { get; set; }
        public DbSet<LopHocPhan> LopHocPhanDbset { get; set; }
        public DbSet<HocPhan> HocPhanDbset { get; set; }
        public DbSet<SinhVien> SinhVienDbset { get; set; }
    }
}
