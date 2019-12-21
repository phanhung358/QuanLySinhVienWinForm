namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class khoitaodb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHocPhans",
                c => new
                    {
                        malophocphan = c.String(nullable: false, maxLength: 128),
                        tenlophocphan = c.String(),
                        giaovienphutrach = c.String(),
                        soluongmin = c.Int(nullable: false),
                        soluongmax = c.Int(nullable: false),
                        soluongdangky = c.Int(nullable: false),
                        mamonhoc = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.malophocphan)
                .ForeignKey("dbo.MonHocs", t => t.mamonhoc)
                .Index(t => t.mamonhoc);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        mamonhoc = c.String(nullable: false, maxLength: 128),
                        tenmonhoc = c.String(),
                    })
                .PrimaryKey(t => t.mamonhoc);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        masinhvien = c.String(nullable: false, maxLength: 128),
                        hodem = c.String(),
                        ten = c.String(),
                        ngaysinh = c.DateTime(nullable: false),
                        quequan = c.String(),
                        malophocphan = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.masinhvien)
                .ForeignKey("dbo.LopHocPhans", t => t.malophocphan)
                .Index(t => t.malophocphan);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "malophocphan", "dbo.LopHocPhans");
            DropForeignKey("dbo.LopHocPhans", "mamonhoc", "dbo.MonHocs");
            DropIndex("dbo.SinhViens", new[] { "malophocphan" });
            DropIndex("dbo.LopHocPhans", new[] { "mamonhoc" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.MonHocs");
            DropTable("dbo.LopHocPhans");
        }
    }
}
