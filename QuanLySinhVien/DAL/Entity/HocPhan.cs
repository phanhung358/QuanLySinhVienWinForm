using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL.Entity
{
    class HocPhan
    {
        [Key]
        public string mahocphan { get; set; }
        public string malophocphan { get; set; }
        [ForeignKey("malophocphan")]
        public virtual LopHocPhan LopHocPhan { get; set; }
        public string masinhvien { get; set; }
        [ForeignKey("masinhvien")]
        public virtual SinhVien SinhVien { get; set; }

        public static List<HocPhan> GetHP()
        {
            return new Context().HocPhanDbset.ToList();
        }
        public static List<HocPhan> GetHPtheoMaLop(string malop)
        {
            return new Context().HocPhanDbset.Where(e => e.malophocphan == malop).ToList();
        }
        public static void AddHP(HocPhan HP)
        {
            var db = new Context();
            db.HocPhanDbset.Add(HP);
            db.SaveChanges();
        }
        public static void RemoveHP(HocPhan HP)
        {
            var db = new Context();
            var objHP = db.HocPhanDbset.Where(e => e.malophocphan == HP.malophocphan).FirstOrDefault();
            if (objHP != null)
                db.HocPhanDbset.Remove(objHP);
            db.SaveChanges();

        }      
    }
}
