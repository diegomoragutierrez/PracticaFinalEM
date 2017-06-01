namespace PracticaEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MatriculaFixed : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Matriculas", "Mail");
            DropColumn("dbo.Matriculas", "Ano");
            DropColumn("dbo.Matriculas", "Nombre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matriculas", "Nombre", c => c.String());
            AddColumn("dbo.Matriculas", "Ano", c => c.String());
            AddColumn("dbo.Matriculas", "Mail", c => c.String());
        }
    }
}
