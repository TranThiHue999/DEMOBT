namespace DEMOBT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            DropTable("dbo.Students");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128, unicode: false),
                        StudentName = c.String(unicode: false),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
            DropTable("dbo.Person");
        }
    }
}
