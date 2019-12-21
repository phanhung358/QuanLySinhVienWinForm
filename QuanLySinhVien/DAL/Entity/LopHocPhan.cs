using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL.Entity
{
    class LopHocPhan
    {
        [Key]
        public string malophocphan { get; set; }
        public string tenlophocphan { get; set; }
        public string giaovienphutrach { get; set; }
        public int soluongmin { get; set; }
        public int soluongmax { get; set; }
        public int soluongdangky { get; set; }
        public string mamonhoc { get; set; }
        [ForeignKey("mamonhoc")]
        public virtual MonHoc MonHoc { get; set; }

        public static List<LopHocPhan> GetLHP()
        {
            return new Context().LopHocPhanDbset.ToList();
        }
        public static List<LopHocPhan> GetLHPtheoMaMonHoc(string mamonhoc)
        {
            return new Context().LopHocPhanDbset.Where(e => e.mamonhoc == mamonhoc).ToList();
        }
        public static void AddLHP(LopHocPhan sv)
        {
            var db = new Context();
            db.LopHocPhanDbset.Add(sv);
            db.SaveChanges();
        }
        public static void RemoveLHP(LopHocPhan danhBa)
        {
            var db = new Context();
            var objSV = db.LopHocPhanDbset.Where(e => e.malophocphan == danhBa.malophocphan).FirstOrDefault();
            if (objSV != null)
                db.LopHocPhanDbset.Remove(objSV);
            db.SaveChanges();

        }
        public static void EditLHP(LopHocPhan danhBa)
        {
            var db = new Context();
            var objSV = db.LopHocPhanDbset.Where(e => e.malophocphan == danhBa.malophocphan).FirstOrDefault();
            if (objSV != null)
            {
                objSV.tenlophocphan = danhBa.tenlophocphan;
                objSV.giaovienphutrach = danhBa.giaovienphutrach;
                objSV.soluongmin = danhBa.soluongmin;
                objSV.soluongmax = danhBa.soluongmax;
                objSV.soluongdangky = danhBa.soluongdangky;
                objSV.mamonhoc = danhBa.mamonhoc;
            }
            db.SaveChanges();

        }
    }
}
