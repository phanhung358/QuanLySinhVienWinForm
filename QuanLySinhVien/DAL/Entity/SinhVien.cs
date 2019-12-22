using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL.Entity
{
    class SinhVien
    {
        [Key]
        public string masinhvien { get; set; }
        public string hodem { get; set; }
        public string ten { get; set; }
        public DateTime ngaysinh { get; set; }
        public string quequan { get; set; }

        public static List<SinhVien> GetSV()
        {
            return new Context().SinhVienDbset.ToList();
        }
        public static SinhVien Get1SV(string masinhvien)
        {
            return new Context().SinhVienDbset.Where(e => e.masinhvien == masinhvien).Single();
        }
        public static void AddSV(SinhVien sv)
        {
            var db = new Context();
            db.SinhVienDbset.Add(sv);
            db.SaveChanges();
        }
        public static void RemoveSV(SinhVien danhBa)
        {
            var db = new Context();
            var objSV = db.SinhVienDbset.Where(e => e.masinhvien == danhBa.masinhvien).FirstOrDefault();
            if (objSV != null)
                db.SinhVienDbset.Remove(objSV);
            db.SaveChanges();

        }
        public static void EditSV(SinhVien danhBa)
        {
            var db = new Context();
            var objSV = db.SinhVienDbset.Where(e => e.masinhvien == danhBa.masinhvien).FirstOrDefault();
            if (objSV != null)
            {
                objSV.hodem = danhBa.hodem;
                objSV.ten = danhBa.ten;
                objSV.ngaysinh = danhBa.ngaysinh;
                objSV.quequan = danhBa.quequan;
            }
            db.SaveChanges();

        }
    }
}
