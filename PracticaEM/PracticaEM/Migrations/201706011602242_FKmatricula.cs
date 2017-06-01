namespace PracticaEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKmatricula : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matriculas", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Matriculas", "UserId");
            AddForeignKey("dbo.Matriculas", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matriculas", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Matriculas", new[] { "UserId" });
            DropColumn("dbo.Matriculas", "UserId");
        }
    }
}
