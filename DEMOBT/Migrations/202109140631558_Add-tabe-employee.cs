namespace DEMOBT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addtabeemployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Company", c => c.String());
            AddColumn("dbo.Person", "Address", c => c.String());
            AddColumn("dbo.Person", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Discriminator");
            DropColumn("dbo.Person", "Address");
            DropColumn("dbo.Person", "Company");
        }
    }
}
