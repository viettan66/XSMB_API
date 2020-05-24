namespace XSMB_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mydb4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tbl_giai1", "ghichu");
            DropColumn("dbo.tbl_giai2", "ghichu");
            DropColumn("dbo.tbl_giai3", "ghichu");
            DropColumn("dbo.tbl_giai4", "ghichu");
            DropColumn("dbo.tbl_giai5", "ghichu");
            DropColumn("dbo.tbl_giai6", "ghichu");
            DropColumn("dbo.tbl_giai7", "ghichu");
            DropColumn("dbo.tbl_giaidb", "ghichu");
            DropColumn("dbo.tbl_time", "ghichu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_time", "ghichu", c => c.String());
            AddColumn("dbo.tbl_giaidb", "ghichu", c => c.String());
            AddColumn("dbo.tbl_giai7", "ghichu", c => c.String());
            AddColumn("dbo.tbl_giai6", "ghichu", c => c.String());
            AddColumn("dbo.tbl_giai5", "ghichu", c => c.String());
            AddColumn("dbo.tbl_giai4", "ghichu", c => c.String());
            AddColumn("dbo.tbl_giai3", "ghichu", c => c.String());
            AddColumn("dbo.tbl_giai2", "ghichu", c => c.String());
            AddColumn("dbo.tbl_giai1", "ghichu", c => c.String());
        }
    }
}
