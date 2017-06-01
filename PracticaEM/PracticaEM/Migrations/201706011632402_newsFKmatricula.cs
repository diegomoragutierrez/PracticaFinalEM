namespace PracticaEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newsFKmatricula : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matriculas", "GrupoClaseId", c => c.Int(nullable: false));
            AddColumn("dbo.Matriculas", "CursoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Matriculas", "GrupoClaseId");
            CreateIndex("dbo.Matriculas", "CursoId");
            AddForeignKey("dbo.Matriculas", "CursoId", "dbo.Cursoes", "CursoId", cascadeDelete: true);
            AddForeignKey("dbo.Matriculas", "GrupoClaseId", "dbo.GrupoClases", "GrupoClaseID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matriculas", "GrupoClaseId", "dbo.GrupoClases");
            DropForeignKey("dbo.Matriculas", "CursoId", "dbo.Cursoes");
            DropIndex("dbo.Matriculas", new[] { "CursoId" });
            DropIndex("dbo.Matriculas", new[] { "GrupoClaseId" });
            DropColumn("dbo.Matriculas", "CursoId");
            DropColumn("dbo.Matriculas", "GrupoClaseId");
        }
    }
}
