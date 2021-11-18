namespace DEMOBT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Altr_Column_Person : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Person", "PersonName", c => c.String(nullable: false));
            AlterColumn("dbo.Person", "Adress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person", "Adress", c => c.String());
            AlterColumn("dbo.Person", "PersonName", c => c.String());
        }
    }
}
