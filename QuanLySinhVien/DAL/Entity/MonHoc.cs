using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL.Entity
{
    class MonHoc
    {
        [Key]
        public string mamonhoc { get; set; }
        public string tenmonhoc { get; set; }

        public static List<MonHoc> GetMH()
        {
            return new Context().MonHocDbset.ToList();
        }
        public static void AddMH(MonHoc sv)
        {
            var db = new Context();
            db.MonHocDbset.Add(sv);
            db.SaveChanges();
        }
        public static void RemoveMH(MonHoc danhBa)
        {
            var db = new Context();
            var objSV = db.MonHocDbset.Where(e => e.mamonhoc == danhBa.mamonhoc).FirstOrDefault();
            if (objSV != null)
                db.MonHocDbset.Remove(objSV);
            db.SaveChanges();

        }
        public static void EditMH(MonHoc danhBa)
        {
            var db = new Context();
            var objSV = db.MonHocDbset.Where(e => e.mamonhoc == danhBa.mamonhoc).FirstOrDefault();
            if (objSV != null)
            {
                objSV.tenmonhoc = danhBa.tenmonhoc;
            }
            db.SaveChanges();

        }
    }
}
