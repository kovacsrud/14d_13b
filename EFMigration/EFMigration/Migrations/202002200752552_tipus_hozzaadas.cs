namespace EFMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tipus_hozzaadas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auto", "Tipus", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Auto", "Tipus");
        }
    }
}
