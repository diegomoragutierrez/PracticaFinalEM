namespace PracticaEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GrupoClaseFixed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GrupoClases", "Cupo", c => c.Int(nullable: false));
            DropColumn("dbo.GrupoClases", "Curso");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GrupoClases", "Curso", c => c.String());
            DropColumn("dbo.GrupoClases", "Cupo");
        }
    }
}
