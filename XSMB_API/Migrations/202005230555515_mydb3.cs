namespace XSMB_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mydb3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_giai1",
                c => new
                    {
                        tbl_giai1_ID = c.Int(nullable: false, identity: true),
                        tbl_time_ID = c.Int(nullable: false),
                        so1 = c.Int(),
                        ghichu = c.String(),
                    })
                .PrimaryKey(t => t.tbl_giai1_ID);
            
            CreateTable(
                "dbo.tbl_giai2",
                c => new
                    {
                        tbl_giai2_ID = c.Int(nullable: false, identity: true),
                        tbl_time_ID = c.Int(nullable: false),
                        so1 = c.Int(),
                        so2 = c.Int(),
                        ghichu = c.String(),
                    })
                .PrimaryKey(t => t.tbl_giai2_ID);
            
            CreateTable(
                "dbo.tbl_giai3",
                c => new
                    {
                        tbl_giai3_ID = c.Int(nullable: false, identity: true),
                        tbl_time_ID = c.Int(nullable: false),
                        so1 = c.Int(),
                        so2 = c.Int(),
                        so3 = c.Int(),
                        so4 = c.Int(),
                        so5 = c.Int(),
                        so6 = c.Int(),
                        ghichu = c.String(),
                    })
                .PrimaryKey(t => t.tbl_giai3_ID);
            
            CreateTable(
                "dbo.tbl_giai4",
                c => new
                    {
                        tbl_giai4_ID = c.Int(nullable: false, identity: true),
                        tbl_time_ID = c.Int(nullable: false),
                        so1 = c.Int(),
                        so2 = c.Int(),
                        so3 = c.Int(),
                        so4 = c.Int(),
                        ghichu = c.String(),
                    })
                .PrimaryKey(t => t.tbl_giai4_ID);
            
            CreateTable(
                "dbo.tbl_giai5",
                c => new
                    {
                        tbl_giai5_ID = c.Int(nullable: false, identity: true),
                        tbl_time_ID = c.Int(nullable: false),
                        so1 = c.Int(),
                        so2 = c.Int(),
                        so3 = c.Int(),
                        so4 = c.Int(),
                        so5 = c.Int(),
                        so6 = c.Int(),
                        ghichu = c.String(),
                    })
                .PrimaryKey(t => t.tbl_giai5_ID);
            
            CreateTable(
                "dbo.tbl_giai6",
                c => new
                    {
                        tbl_giai6_ID = c.Int(nullable: false, identity: true),
                        tbl_time_ID = c.Int(nullable: false),
                        so1 = c.Int(),
                        so2 = c.Int(),
                        so3 = c.Int(),
                        ghichu = c.String(),
                    })
                .PrimaryKey(t => t.tbl_giai6_ID);
            
            CreateTable(
                "dbo.tbl_giai7",
                c => new
                    {
                        tbl_giai7_ID = c.Int(nullable: false, identity: true),
                        tbl_time_ID = c.Int(nullable: false),
                        so1 = c.Int(),
                        so2 = c.Int(),
                        so3 = c.Int(),
                        so4 = c.Int(),
                        ghichu = c.String(),
                    })
                .PrimaryKey(t => t.tbl_giai7_ID);
            
            CreateTable(
                "dbo.tbl_giaidb",
                c => new
                    {
                        tbl_giaidb_ID = c.Int(nullable: false, identity: true),
                        tbl_time_ID = c.Int(nullable: false),
                        so1 = c.Int(),
                        ghichu = c.String(),
                    })
                .PrimaryKey(t => t.tbl_giaidb_ID);
            
            CreateTable(
                "dbo.tbl_time",
                c => new
                    {
                        tbl_time_ID = c.Int(nullable: false, identity: true),
                        time = c.DateTime(),
                        ghichu = c.String(),
                        tbl_giai1_tbl_giai1_ID = c.Int(),
                        tbl_giai2_tbl_giai2_ID = c.Int(),
                        tbl_giai3_tbl_giai3_ID = c.Int(),
                        tbl_giai4_tbl_giai4_ID = c.Int(),
                        tbl_giai5_tbl_giai5_ID = c.Int(),
                        tbl_giai6_tbl_giai6_ID = c.Int(),
                        tbl_giai7_tbl_giai7_ID = c.Int(),
                        tbl_giaidb_tbl_giaidb_ID = c.Int(),
                    })
                .PrimaryKey(t => t.tbl_time_ID)
                .ForeignKey("dbo.tbl_giai1", t => t.tbl_giai1_tbl_giai1_ID)
                .ForeignKey("dbo.tbl_giai2", t => t.tbl_giai2_tbl_giai2_ID)
                .ForeignKey("dbo.tbl_giai3", t => t.tbl_giai3_tbl_giai3_ID)
                .ForeignKey("dbo.tbl_giai4", t => t.tbl_giai4_tbl_giai4_ID)
                .ForeignKey("dbo.tbl_giai5", t => t.tbl_giai5_tbl_giai5_ID)
                .ForeignKey("dbo.tbl_giai6", t => t.tbl_giai6_tbl_giai6_ID)
                .ForeignKey("dbo.tbl_giai7", t => t.tbl_giai7_tbl_giai7_ID)
                .ForeignKey("dbo.tbl_giaidb", t => t.tbl_giaidb_tbl_giaidb_ID)
                .Index(t => t.tbl_giai1_tbl_giai1_ID)
                .Index(t => t.tbl_giai2_tbl_giai2_ID)
                .Index(t => t.tbl_giai3_tbl_giai3_ID)
                .Index(t => t.tbl_giai4_tbl_giai4_ID)
                .Index(t => t.tbl_giai5_tbl_giai5_ID)
                .Index(t => t.tbl_giai6_tbl_giai6_ID)
                .Index(t => t.tbl_giai7_tbl_giai7_ID)
                .Index(t => t.tbl_giaidb_tbl_giaidb_ID);
            
            DropTable("dbo.Blogs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BlogId);
            
            DropForeignKey("dbo.tbl_time", "tbl_giaidb_tbl_giaidb_ID", "dbo.tbl_giaidb");
            DropForeignKey("dbo.tbl_time", "tbl_giai7_tbl_giai7_ID", "dbo.tbl_giai7");
            DropForeignKey("dbo.tbl_time", "tbl_giai6_tbl_giai6_ID", "dbo.tbl_giai6");
            DropForeignKey("dbo.tbl_time", "tbl_giai5_tbl_giai5_ID", "dbo.tbl_giai5");
            DropForeignKey("dbo.tbl_time", "tbl_giai4_tbl_giai4_ID", "dbo.tbl_giai4");
            DropForeignKey("dbo.tbl_time", "tbl_giai3_tbl_giai3_ID", "dbo.tbl_giai3");
            DropForeignKey("dbo.tbl_time", "tbl_giai2_tbl_giai2_ID", "dbo.tbl_giai2");
            DropForeignKey("dbo.tbl_time", "tbl_giai1_tbl_giai1_ID", "dbo.tbl_giai1");
            DropIndex("dbo.tbl_time", new[] { "tbl_giaidb_tbl_giaidb_ID" });
            DropIndex("dbo.tbl_time", new[] { "tbl_giai7_tbl_giai7_ID" });
            DropIndex("dbo.tbl_time", new[] { "tbl_giai6_tbl_giai6_ID" });
            DropIndex("dbo.tbl_time", new[] { "tbl_giai5_tbl_giai5_ID" });
            DropIndex("dbo.tbl_time", new[] { "tbl_giai4_tbl_giai4_ID" });
            DropIndex("dbo.tbl_time", new[] { "tbl_giai3_tbl_giai3_ID" });
            DropIndex("dbo.tbl_time", new[] { "tbl_giai2_tbl_giai2_ID" });
            DropIndex("dbo.tbl_time", new[] { "tbl_giai1_tbl_giai1_ID" });
            DropTable("dbo.tbl_time");
            DropTable("dbo.tbl_giaidb");
            DropTable("dbo.tbl_giai7");
            DropTable("dbo.tbl_giai6");
            DropTable("dbo.tbl_giai5");
            DropTable("dbo.tbl_giai4");
            DropTable("dbo.tbl_giai3");
            DropTable("dbo.tbl_giai2");
            DropTable("dbo.tbl_giai1");
        }
    }
}
