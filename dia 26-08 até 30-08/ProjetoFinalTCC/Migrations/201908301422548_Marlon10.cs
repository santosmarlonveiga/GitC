namespace ProjetoFinalTCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marlon10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TiposDeTransportes", "QntDeVagas", c => c.Int(nullable: false));
            DropColumn("dbo.TiposDeTransportes", "ValidaCampos");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TiposDeTransportes", "ValidaCampos", c => c.Boolean(nullable: false));
            DropColumn("dbo.TiposDeTransportes", "QntDeVagas");
        }
    }
}
