namespace IJCharityDotNetFramwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_FamilyTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        AreaId = c.Guid(nullable: false),
                        AreaName = c.String(maxLength: 10),
                        AreaCode = c.String(maxLength: 5),
                        AreaChairman = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.AreaId);
            
            CreateTable(
                "dbo.FamilyFiles",
                c => new
                    {
                        FamilyFileId = c.Guid(nullable: false),
                        FamilyFileNumber = c.Int(nullable: false),
                        FamilyType = c.Int(nullable: false),
                        FamilyFileDate = c.DateTime(nullable: false),
                        NumberOfFamilyMemebr = c.Int(nullable: false),
                        NumberOfOrphans = c.Int(nullable: false),
                        FamilyIntroducer = c.String(maxLength: 50),
                        Address = c.String(maxLength: 300),
                        Tel = c.String(maxLength: 10),
                        Mobile1 = c.String(maxLength: 11),
                        Mobile2 = c.String(maxLength: 11),
                        DegreeOfPoverty = c.Int(nullable: false),
                        Tags = c.String(maxLength: 200),
                        IsFamilyFileActive = c.Boolean(nullable: false),
                        Area_AreaId = c.Guid(),
                    })
                .PrimaryKey(t => t.FamilyFileId)
                .ForeignKey("dbo.Areas", t => t.Area_AreaId)
                .Index(t => t.Area_AreaId);
            
            CreateTable(
                "dbo.FamilyMembers",
                c => new
                    {
                        FamilyMemberId = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 25),
                        LastName = c.String(nullable: false, maxLength: 25),
                        FatherName = c.String(nullable: false, maxLength: 25),
                        IsFatherAlive = c.Boolean(nullable: false),
                        Gender = c.Int(nullable: false),
                        BirthDay = c.DateTime(nullable: false),
                        BirthPlace = c.String(maxLength: 25),
                        HealthStatus = c.String(nullable: false, maxLength: 25),
                        IdCardType = c.Int(nullable: false),
                        IdCardNumber = c.String(maxLength: 11),
                        FamilyIdCardNumber = c.String(maxLength: 9),
                        PassportNumber = c.String(maxLength: 9),
                        DedicatedNumber = c.String(maxLength: 12),
                        EducationGrade = c.Int(nullable: false),
                        EducationalStatus = c.Int(nullable: false),
                        CurrentJob = c.String(nullable: false, maxLength: 25),
                        Skills = c.String(maxLength: 300),
                        IsActivePerson = c.Boolean(nullable: false),
                        IsFamilyLeader = c.Boolean(nullable: false),
                        FamilyType = c.Int(nullable: false),
                        FamilyFileNumber = c.Int(nullable: false),
                        FamilyFile_FamilyFileId = c.Guid(),
                    })
                .PrimaryKey(t => t.FamilyMemberId)
                .ForeignKey("dbo.FamilyFiles", t => t.FamilyFile_FamilyFileId)
                .Index(t => t.FamilyFile_FamilyFileId);
            
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        SponsorId = c.Guid(nullable: false),
                        FamilyFile_FamilyFileId = c.Guid(),
                    })
                .PrimaryKey(t => t.SponsorId)
                .ForeignKey("dbo.FamilyFiles", t => t.FamilyFile_FamilyFileId)
                .Index(t => t.FamilyFile_FamilyFileId);
            
           
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Persons", "shomare_parvande", "dbo.Parvande");
            DropForeignKey("dbo.Parvandehamkaran_manategh", "hamkaran_manategh_id_hamkaran_mantaghe", "dbo.hamkaran_manategh");
            DropForeignKey("dbo.Parvandehamkaran_manategh", "Parvande_shomare_parvande", "dbo.Parvande");
            DropForeignKey("dbo.Sponsors", "FamilyFile_FamilyFileId", "dbo.FamilyFiles");
            DropForeignKey("dbo.FamilyMembers", "FamilyFile_FamilyFileId", "dbo.FamilyFiles");
            DropForeignKey("dbo.FamilyFiles", "Area_AreaId", "dbo.Areas");
            DropIndex("dbo.Parvandehamkaran_manategh", new[] { "hamkaran_manategh_id_hamkaran_mantaghe" });
            DropIndex("dbo.Parvandehamkaran_manategh", new[] { "Parvande_shomare_parvande" });
            DropIndex("dbo.Persons", new[] { "shomare_parvande" });
            DropIndex("dbo.Sponsors", new[] { "FamilyFile_FamilyFileId" });
            DropIndex("dbo.FamilyMembers", new[] { "FamilyFile_FamilyFileId" });
            DropIndex("dbo.FamilyFiles", new[] { "Area_AreaId" });
            DropTable("dbo.Parvandehamkaran_manategh");
            DropTable("dbo.Manategh");
            DropTable("dbo.Persons");
            DropTable("dbo.Parvande");
            DropTable("dbo.hamkaran_manategh");
            DropTable("dbo.Sponsors");
            DropTable("dbo.FamilyMembers");
            DropTable("dbo.FamilyFiles");
            DropTable("dbo.Areas");
        }
    }
}
