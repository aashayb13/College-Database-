namespace CLG_DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewTableColours1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        ColorId = c.Int(nullable: false, identity: true),
                        ColorName = c.String(),
                    })
                .PrimaryKey(t => t.ColorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Colors");
        }
    }
}
