namespace IJCharityDotNetFramwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_FullName_FamilyMember : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FamilyMembers", "FullName", c => c.String(maxLength: 51));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FamilyMembers", "FullName");
        }
    }
}
