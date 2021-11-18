namespace DEMOBT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetabeaccountroleID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "RoleID", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "RoleID");
        }
    }
}
