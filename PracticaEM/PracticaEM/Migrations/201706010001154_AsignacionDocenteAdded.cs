namespace PracticaEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AsignacionDocenteAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AsignacionDocentes",
                c => new
                    {
                        AsigDocente = c.Int(nullable: false, identity: true),
                        Mail = c.String(),
                        Ano = c.String(),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.AsigDocente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AsignacionDocentes");
        }
    }
}
