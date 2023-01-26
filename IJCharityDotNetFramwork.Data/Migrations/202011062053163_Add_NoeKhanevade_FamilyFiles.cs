namespace IJCharityDotNetFramwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_NoeKhanevade_FamilyFiles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FamilyFiles", "FamilyType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FamilyFiles", "FamilyType");
        }
    }
}
