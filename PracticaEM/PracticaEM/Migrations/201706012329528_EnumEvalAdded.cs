namespace PracticaEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnumEvalAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Evaluacions", "Convocatoria", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Evaluacions", "Convocatoria", c => c.String());
        }
    }
}
