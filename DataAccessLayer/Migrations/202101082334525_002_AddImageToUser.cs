namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002_AddImageToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ImageFile", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ImageFile");
        }
    }
}
