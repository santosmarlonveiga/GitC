namespace ProjetoFinalTCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marlon6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PeriodoDeLocacaos", "TipoVeiculoFK", c => c.Int(nullable: false));
            CreateIndex("dbo.PeriodoDeLocacaos", "TipoVeiculoFK");
            AddForeignKey("dbo.PeriodoDeLocacaos", "TipoVeiculoFK", "dbo.TiposDeTransportes", "Id", cascadeDelete: true);
            DropColumn("dbo.PeriodoDeLocacaos", "TipoDeVeiculo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PeriodoDeLocacaos", "TipoDeVeiculo", c => c.Int(nullable: false));
            DropForeignKey("dbo.PeriodoDeLocacaos", "TipoVeiculoFK", "dbo.TiposDeTransportes");
            DropIndex("dbo.PeriodoDeLocacaos", new[] { "TipoVeiculoFK" });
            DropColumn("dbo.PeriodoDeLocacaos", "TipoVeiculoFK");
        }
    }
}
