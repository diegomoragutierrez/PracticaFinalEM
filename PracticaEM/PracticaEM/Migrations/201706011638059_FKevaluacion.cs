namespace PracticaEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKevaluacion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Evaluacions", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Evaluacions", "UserId");
            AddForeignKey("dbo.Evaluacions", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Evaluacions", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Evaluacions", new[] { "UserId" });
            DropColumn("dbo.Evaluacions", "UserId");
        }
    }
}
