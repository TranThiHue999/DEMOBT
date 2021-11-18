namespace DEMOBT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Table_Khachhag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 128),
                        TenKhachHang = c.String(),
                        SoDienThoai = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHangs");
        }
    }
}
