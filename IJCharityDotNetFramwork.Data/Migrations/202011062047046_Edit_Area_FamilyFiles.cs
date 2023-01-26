namespace IJCharityDotNetFramwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit_Area_FamilyFiles : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FamilyFiles", "Area_AreaId", "dbo.Areas");
            DropIndex("dbo.FamilyFiles", new[] { "Area_AreaId" });
            RenameColumn(table: "dbo.FamilyFiles", name: "Area_AreaId", newName: "AreaId");
            AlterColumn("dbo.FamilyFiles", "AreaId", c => c.Guid(nullable: false));
            CreateIndex("dbo.FamilyFiles", "AreaId");
            AddForeignKey("dbo.FamilyFiles", "AreaId", "dbo.Areas", "AreaId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FamilyFiles", "AreaId", "dbo.Areas");
            DropIndex("dbo.FamilyFiles", new[] { "AreaId" });
            AlterColumn("dbo.FamilyFiles", "AreaId", c => c.Guid());
            RenameColumn(table: "dbo.FamilyFiles", name: "AreaId", newName: "Area_AreaId");
            CreateIndex("dbo.FamilyFiles", "Area_AreaId");
            AddForeignKey("dbo.FamilyFiles", "Area_AreaId", "dbo.Areas", "AreaId");
        }
    }
}
