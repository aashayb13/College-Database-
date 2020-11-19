namespace CLG_DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedAge : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Age", c => c.Int(nullable: false));
        }
    }
}
