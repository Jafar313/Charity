namespace IJCharityDotNetFramwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_New_Manategh_Family_Tables : DbMigration
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
                        FamilyFileId = c.Int(nullable: false),
                        NumberOfFamilyMemebr = c.Int(nullable: false),
                        NumberOfOrphans = c.Int(nullable: false),
                        FamilyIntroducer = c.String(maxLength: 50),
                        Address = c.String(maxLength: 200),
                        Tel = c.String(maxLength: 10),
                        Mobile1 = c.String(nullable: false, maxLength: 11),
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
                        FamilyFileId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 25),
                        LastName = c.String(nullable: false, maxLength: 25),
                        FatherName = c.String(nullable: false, maxLength: 25),
                        IsOrphan = c.Boolean(nullable: false),
                        Gender = c.Int(nullable: false),
                        BirthDay = c.DateTime(nullable: false),
                        BirthPlace = c.String(maxLength: 25),
                        HealthStatus = c.String(nullable: false, maxLength: 25),
                        IdCardType = c.Int(nullable: false),
                        FamilyIdCardNumber = c.Int(nullable: false),
                        PassportNumber = c.String(maxLength: 9),
                        DedicatedNumber = c.Int(nullable: false),
                        EducationGrade = c.Int(nullable: false),
                        MariageStatus = c.Int(nullable: false),
                        CurrentJob = c.String(nullable: false, maxLength: 25),
                        Skills = c.String(maxLength: 300),
                        IsActivePerson = c.Boolean(nullable: false),
                        IsFamilyLeader = c.Boolean(nullable: false),
                        FamilyType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FamilyMemberId)
                .ForeignKey("dbo.FamilyFiles", t => t.FamilyFileId, cascadeDelete: true)
                .Index(t => t.FamilyFileId);
            
            //CreateTable(
            //    "dbo.hamkaran_manategh",
            //    c => new
            //        {
            //            id_hamkaran_mantaghe = c.Int(nullable: false, identity: true),
            //            hamkar_or_manager = c.Int(),
            //            name_hamkar_mantaghe = c.String(),
            //            family_hamkar_mantaghe = c.String(),
            //            fullname_hamkar_mantaghe = c.String(),
            //            mantaghe_khedmat = c.String(),
            //            mantaghe_khedmat_decimal = c.Decimal(precision: 18, scale: 2),
            //            shomare_card_pass_hamkar = c.String(),
            //            tarikh_tavalod_hamkar_mantaghe = c.String(),
            //            tarikh_tavalod_hamkar_mantaghe_date = c.DateTime(storeType: "date"),
            //            vaziate_taahol_hamkar_mantaghe = c.String(),
            //            tahsilate_hamkar_mantaghe = c.String(),
            //            savabegh_emdadi_hamkar_mantaghe = c.String(),
            //            savabegh_siasi_hamkar_mantaghe = c.String(),
            //            moarref_hamkar_mantaghe = c.String(),
            //            address_manzel_hamkar_mantaghe = c.String(),
            //            address_kar_hamkar_mantaghe = c.String(),
            //            tel_manzel_hamkar_mantaghe = c.String(),
            //            tel_kar_hamkar_mantaghe = c.String(),
            //            mobile_hamkar_mantaghe = c.String(),
            //            picture_hamkar_mantaghe = c.Binary(storeType: "image"),
            //        })
            //    .PrimaryKey(t => t.id_hamkaran_mantaghe);
            
            //CreateTable(
            //    "dbo.Parvande",
            //    c => new
            //        {
            //            shomare_parvande = c.Int(nullable: false),
            //            id_parvande = c.Int(nullable: false, identity: true),
            //            id_moarref = c.Int(),
            //            tarikh_parvande = c.String(maxLength: 10),
            //            tarikh_parvande_miladi = c.DateTime(storeType: "date"),
            //            zaman_sabt_parvande = c.String(maxLength: 50),
            //            id_ellate_paziresh = c.Int(),
            //            id_location = c.Int(),
            //            id_last_user_edit = c.Int(),
            //            mantaghe = c.String(maxLength: 10),
            //            shomare_khanevar = c.String(maxLength: 25),
            //            tedad_nafar = c.Int(),
            //            tedad_kol_afrad = c.Int(),
            //            tedad_yatim = c.Int(),
            //            ellate_fote_pedar = c.String(),
            //            address = c.String(),
            //            tel = c.String(maxLength: 25),
            //            mobile1 = c.String(maxLength: 25),
            //            Tozihat_parvande = c.String(),
            //            Tozihat_systemi = c.String(),
            //            radif_nobat_mantaghe = c.Int(),
            //            kart_kheirie_darad = c.Boolean(),
            //            parvande_pic_darad = c.Boolean(),
            //            zaman_akharin_eslah = c.String(maxLength: 50),
            //            id_noe_komak = c.Int(),
            //            id_vaziate_parvande = c.Int(),
            //            expire_date = c.DateTime(storeType: "date"),
            //        })
            //    .PrimaryKey(t => t.shomare_parvande);
            
            //CreateTable(
            //    "dbo.Persons",
            //    c => new
            //        {
            //            ID_Person = c.Int(nullable: false, identity: true),
            //            shomare_parvande = c.Int(),
            //            first_name = c.String(maxLength: 100),
            //            last_name = c.String(maxLength: 100),
            //            full_name = c.String(maxLength: 250),
            //            name_pedar = c.String(maxLength: 50),
            //            tarikh_tavalod = c.String(maxLength: 10),
            //            tarikh_tavalod_miladi = c.DateTime(storeType: "date"),
            //            shomare_shenasaie = c.String(maxLength: 25),
            //            vaziate_salamat = c.String(maxLength: 80),
            //            shogl = c.String(maxLength: 50),
            //            id_noe_khanevade = c.Int(),
            //            id_vaziate_taahol = c.Int(),
            //            size_kafsh = c.Int(),
            //            size_lebas = c.String(maxLength: 50),
            //            jensiat_zan_ast = c.Boolean(),
            //            tozihat = c.String(maxLength: 300),
            //            is_sarparast = c.Boolean(),
            //            id_vaziate_tahte_poshesh = c.Int(),
            //            zaman_sabt_person = c.String(maxLength: 50),
            //            id_mahal_tavalod = c.Int(),
            //            noe_madrak_shenasaie = c.Int(),
            //            id_tahsilat = c.Int(),
            //            is_yatim = c.Boolean(),
            //        })
            //    .PrimaryKey(t => t.ID_Person)
            //    .ForeignKey("dbo.Parvande", t => t.shomare_parvande)
            //    .Index(t => t.shomare_parvande);
            
            //CreateTable(
            //    "dbo.Manategh",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Name_mantaghe = c.String(maxLength: 50),
            //            shomare_mantaghe_deci = c.Decimal(precision: 18, scale: 2),
            //            shomare_mantaghe = c.String(maxLength: 5),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.Parvandehamkaran_manategh",
            //    c => new
            //        {
            //            Parvande_shomare_parvande = c.Int(nullable: false),
            //            hamkaran_manategh_id_hamkaran_mantaghe = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.Parvande_shomare_parvande, t.hamkaran_manategh_id_hamkaran_mantaghe })
            //    .ForeignKey("dbo.Parvande", t => t.Parvande_shomare_parvande, cascadeDelete: true)
            //    .ForeignKey("dbo.hamkaran_manategh", t => t.hamkaran_manategh_id_hamkaran_mantaghe, cascadeDelete: true)
            //    .Index(t => t.Parvande_shomare_parvande)
            //    .Index(t => t.hamkaran_manategh_id_hamkaran_mantaghe);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Persons", "shomare_parvande", "dbo.Parvande");
            DropForeignKey("dbo.Parvandehamkaran_manategh", "hamkaran_manategh_id_hamkaran_mantaghe", "dbo.hamkaran_manategh");
            DropForeignKey("dbo.Parvandehamkaran_manategh", "Parvande_shomare_parvande", "dbo.Parvande");
            DropForeignKey("dbo.FamilyMembers", "FamilyFileId", "dbo.FamilyFiles");
            DropForeignKey("dbo.FamilyFiles", "Area_AreaId", "dbo.Areas");
            DropIndex("dbo.Parvandehamkaran_manategh", new[] { "hamkaran_manategh_id_hamkaran_mantaghe" });
            DropIndex("dbo.Parvandehamkaran_manategh", new[] { "Parvande_shomare_parvande" });
            DropIndex("dbo.Persons", new[] { "shomare_parvande" });
            DropIndex("dbo.FamilyMembers", new[] { "FamilyFileId" });
            DropIndex("dbo.FamilyFiles", new[] { "Area_AreaId" });
            DropTable("dbo.Parvandehamkaran_manategh");
            DropTable("dbo.Manategh");
            DropTable("dbo.Persons");
            DropTable("dbo.Parvande");
            DropTable("dbo.hamkaran_manategh");
            DropTable("dbo.FamilyMembers");
            DropTable("dbo.FamilyFiles");
            DropTable("dbo.Areas");
        }
    }
}
