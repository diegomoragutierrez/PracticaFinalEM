namespace PracticaEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CursoAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Ano = c.String(),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.CursoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cursoes");
        }
    }
}
