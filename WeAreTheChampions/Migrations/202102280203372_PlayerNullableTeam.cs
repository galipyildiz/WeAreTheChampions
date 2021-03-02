namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerNullableTeam : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Players", new[] { "TeamId" });
            AlterColumn("dbo.Players", "TeamId", c => c.Int());
            CreateIndex("dbo.Players", "TeamId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Players", new[] { "TeamId" });
            AlterColumn("dbo.Players", "TeamId", c => c.Int(nullable: false));
            CreateIndex("dbo.Players", "TeamId");
        }
    }
}
