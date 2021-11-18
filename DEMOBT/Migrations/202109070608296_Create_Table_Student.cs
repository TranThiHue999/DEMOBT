namespace DEMOBT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128, unicode: false),
                        StudentName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
            DropTable("dbo.KhachHangs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenKhachHang = c.String(),
                        SoDienThoai = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
            DropTable("dbo.Students");
        }
    }
}
