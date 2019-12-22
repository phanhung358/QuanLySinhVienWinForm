namespace QuanLySinhVien.Migrations
{
    using QuanLySinhVien.DAL.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuanLySinhVien.DAL.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QuanLySinhVien.DAL.Context context)
        {
            context.MonHocDbset.AddOrUpdate(new MonHoc
            {
                mamonhoc = "1",
                tenmonhoc = "Java"
            }, new MonHoc
            {
                mamonhoc = "2",
                tenmonhoc = "PHP"
            });
            context.LopHocPhanDbset.AddOrUpdate(new LopHocPhan
            {
                malophocphan = "1",
                tenlophocphan = "Java cơ bản",
                giaovienphutrach = "Nguyễn Hoàng Hà",
                soluongmin = 10,
                soluongmax = 20,
                soluongdangky = 3,
                mamonhoc = "1"
            }, new LopHocPhan
            {
                malophocphan = "2",
                tenlophocphan = "Java nâng cao",
                giaovienphutrach = "Nguyễn Hoàng Hà",
                soluongmin = 10,
                soluongmax = 20,
                soluongdangky = 3,
                mamonhoc = "1"
            }, new LopHocPhan
            {
                malophocphan = "3",
                tenlophocphan = "PHP cơ bản",
                giaovienphutrach = "Nguyễn Dũng",
                soluongmin = 10,
                soluongmax = 20,
                soluongdangky = 3,
                mamonhoc = "2"
            }, new LopHocPhan
            {
                malophocphan = "4",
                tenlophocphan = "PHP nâng cao",
                giaovienphutrach = "Nguyễn Dũng",
                soluongmin = 10,
                soluongmax = 20,
                soluongdangky = 3,
                mamonhoc = "2"
            });
            context.HocPhanDbset.AddOrUpdate(new HocPhan
            {
                mahocphan = "1",
                malophocphan = "1",
                masinhvien = "1"
            }, new HocPhan
            {
                mahocphan = "2",
                malophocphan = "1",
                masinhvien = "2"
            }, new HocPhan
            {
                mahocphan = "3",
                malophocphan = "1",
                masinhvien = "3"
            }, new HocPhan
            {
                mahocphan = "4",
                malophocphan = "2",
                masinhvien = "4"
            }, new HocPhan
            {
                mahocphan = "5",
                malophocphan = "2",
                masinhvien = "5"
            }, new HocPhan
            {
                mahocphan = "6",
                malophocphan = "2",
                masinhvien = "6"
            }, new HocPhan
            {
                mahocphan = "7",
                malophocphan = "3",
                masinhvien = "1"
            }, new HocPhan
            {
                mahocphan = "8",
                malophocphan = "3",
                masinhvien = "3"
            }, new HocPhan
            {
                mahocphan = "9",
                malophocphan = "3",
                masinhvien = "5"
            }, new HocPhan
            {
                mahocphan = "10",
                malophocphan = "4",
                masinhvien = "2"
            }, new HocPhan
            {
                mahocphan = "11",
                malophocphan = "4",
                masinhvien = "4"
            }, new HocPhan
            {
                mahocphan = "12",
                malophocphan = "4",
                masinhvien = "6"
            });
            context.SinhVienDbset.AddOrUpdate(new SinhVien
            {
                masinhvien ="1",
                hodem ="Phan",
                ten = "Hùng",
                ngaysinh = new DateTime(1998, 05, 03),
                quequan = "Huế"
            }, new SinhVien
            {
                masinhvien = "2",
                hodem = "Nguyễn Quang",
                ten = "Thái",
                ngaysinh = new DateTime(1998, 05, 03),
                quequan = "Huế"
            }, new SinhVien
            {
                masinhvien = "3",
                hodem = "Phan Viết",
                ten = "Thuận",
                ngaysinh = new DateTime(1998, 05, 03),
                quequan = "Huế"
            }, new SinhVien
            {
                masinhvien = "4",
                hodem = "Nguyễn Thị Kim",
                ten = "Thoa",
                ngaysinh = new DateTime(1998, 05, 03),
                quequan = "Huế"
            }, new SinhVien
            {
                masinhvien = "5",
                hodem = "Lê Thị Ngọc",
                ten = "Diệu",
                ngaysinh = new DateTime(1998, 05, 03),
                quequan = "Huế"
            },  new SinhVien
            {
                masinhvien = "6",
                hodem = "Võ Thị",
                ten = "Chung",
                ngaysinh = new DateTime(1998, 05, 03),
                quequan = "Huế"
            });
        }
    }
}
