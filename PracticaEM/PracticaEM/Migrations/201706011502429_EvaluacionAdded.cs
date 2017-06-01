namespace PracticaEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EvaluacionAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Evaluacions",
                c => new
                    {
                        EvaluacionId = c.Int(nullable: false, identity: true),
                        NotaT1 = c.Single(nullable: false),
                        NotaT2 = c.Single(nullable: false),
                        NotaT3 = c.Single(nullable: false),
                        NotaPr = c.Single(nullable: false),
                        NotaTest = c.Single(nullable: false),
                        Convocatoria = c.String(),
                    })
                .PrimaryKey(t => t.EvaluacionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Evaluacions");
        }
    }
}
