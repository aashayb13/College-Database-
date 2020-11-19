namespace CLG_DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewTableColours : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "colours", c => c.String(nullable: false));

        }
        public override void Down()
        {
        }
    }
}
