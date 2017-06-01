namespace PracticaEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AsignacionDocenteFixed : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.AsignacionDocentes");
            DropColumn("dbo.AsignacionDocentes", "AsigDocente");
            DropColumn("dbo.AsignacionDocentes", "Mail");
            DropColumn("dbo.AsignacionDocentes", "Ano");
            DropColumn("dbo.AsignacionDocentes", "Nombre");
            AddColumn("dbo.AsignacionDocentes", "AsigDocenteId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.AsignacionDocentes", "AsigDocenteId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AsignacionDocentes", "Nombre", c => c.String());
            AddColumn("dbo.AsignacionDocentes", "Ano", c => c.String());
            AddColumn("dbo.AsignacionDocentes", "Mail", c => c.String());
            AddColumn("dbo.AsignacionDocentes", "AsigDocente", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.AsignacionDocentes");
            DropColumn("dbo.AsignacionDocentes", "AsigDocenteId");
            AddPrimaryKey("dbo.AsignacionDocentes", "AsigDocente");
        }
    }
}
