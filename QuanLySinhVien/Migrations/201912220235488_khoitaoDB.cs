namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class khoitaoDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SinhViens", "malophocphan", "dbo.LopHocPhans");
            DropIndex("dbo.SinhViens", new[] { "malophocphan" });
            CreateTable(
                "dbo.HocPhans",
                c => new
                    {
                        mahocphan = c.String(nullable: false, maxLength: 128),
                        malophocphan = c.String(maxLength: 128),
                        masinhvien = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.mahocphan)
                .ForeignKey("dbo.LopHocPhans", t => t.malophocphan)
                .ForeignKey("dbo.SinhViens", t => t.masinhvien)
                .Index(t => t.malophocphan)
                .Index(t => t.masinhvien);
            
            DropColumn("dbo.SinhViens", "malophocphan");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SinhViens", "malophocphan", c => c.String(maxLength: 128));
            DropForeignKey("dbo.HocPhans", "masinhvien", "dbo.SinhViens");
            DropForeignKey("dbo.HocPhans", "malophocphan", "dbo.LopHocPhans");
            DropIndex("dbo.HocPhans", new[] { "masinhvien" });
            DropIndex("dbo.HocPhans", new[] { "malophocphan" });
            DropTable("dbo.HocPhans");
            CreateIndex("dbo.SinhViens", "malophocphan");
            AddForeignKey("dbo.SinhViens", "malophocphan", "dbo.LopHocPhans", "malophocphan");
        }
    }
}
