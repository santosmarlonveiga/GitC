namespace ProjetoFinalTCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marlon7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PeriodoDeLocacaos", "DataFinal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PeriodoDeLocacaos", "DataFinal", c => c.DateTime(nullable: false));
        }
    }
}
