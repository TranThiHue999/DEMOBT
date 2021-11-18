namespace DEMOBT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_Student_Adress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Adress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Adress");
        }
    }
}
