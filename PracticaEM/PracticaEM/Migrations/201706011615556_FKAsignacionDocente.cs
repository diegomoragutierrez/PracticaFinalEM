namespace PracticaEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKAsignacionDocente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AsignacionDocentes", "UserId", c => c.String(maxLength: 128));
            AddColumn("dbo.AsignacionDocentes", "GrupoClaseId", c => c.Int(nullable: false));
            AddColumn("dbo.AsignacionDocentes", "CursoId", c => c.Int(nullable: false));
            CreateIndex("dbo.AsignacionDocentes", "UserId");
            CreateIndex("dbo.AsignacionDocentes", "GrupoClaseId");
            CreateIndex("dbo.AsignacionDocentes", "CursoId");
            AddForeignKey("dbo.AsignacionDocentes", "CursoId", "dbo.Cursoes", "CursoId", cascadeDelete: true);
            AddForeignKey("dbo.AsignacionDocentes", "GrupoClaseId", "dbo.GrupoClases", "GrupoClaseID", cascadeDelete: true);
            AddForeignKey("dbo.AsignacionDocentes", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AsignacionDocentes", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AsignacionDocentes", "GrupoClaseId", "dbo.GrupoClases");
            DropForeignKey("dbo.AsignacionDocentes", "CursoId", "dbo.Cursoes");
            DropIndex("dbo.AsignacionDocentes", new[] { "CursoId" });
            DropIndex("dbo.AsignacionDocentes", new[] { "GrupoClaseId" });
            DropIndex("dbo.AsignacionDocentes", new[] { "UserId" });
            DropColumn("dbo.AsignacionDocentes", "CursoId");
            DropColumn("dbo.AsignacionDocentes", "GrupoClaseId");
            DropColumn("dbo.AsignacionDocentes", "UserId");
        }
    }
}
