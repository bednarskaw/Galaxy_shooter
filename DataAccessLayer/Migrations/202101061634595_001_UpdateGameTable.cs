namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001_UpdateGameTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Games", "User_UserId", "dbo.Users");
            DropIndex("dbo.Games", new[] { "User_UserId" });
            AlterColumn("dbo.Games", "User_UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Games", "User_UserId");
            AddForeignKey("dbo.Games", "User_UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "User_UserId", "dbo.Users");
            DropIndex("dbo.Games", new[] { "User_UserId" });
            AlterColumn("dbo.Games", "User_UserId", c => c.Int());
            CreateIndex("dbo.Games", "User_UserId");
            AddForeignKey("dbo.Games", "User_UserId", "dbo.Users", "UserId");
        }
    }
}
