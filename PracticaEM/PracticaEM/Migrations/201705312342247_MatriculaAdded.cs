namespace PracticaEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MatriculaAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matriculas",
                c => new
                    {
                        MatriculaId = c.Int(nullable: false, identity: true),
                        Mail = c.String(),
                        Ano = c.String(),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.MatriculaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Matriculas");
        }
    }
}
