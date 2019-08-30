namespace ProjetoFinalTCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marlon3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MarcaVeiculoes", "TipoVeiculoFK", c => c.Int(nullable: false));
            CreateIndex("dbo.MarcaVeiculoes", "TipoVeiculoFK");
            AddForeignKey("dbo.MarcaVeiculoes", "TipoVeiculoFK", "dbo.TiposDeTransportes", "Id", cascadeDelete: true);
            DropColumn("dbo.MarcaVeiculoes", "TipoDeVeiculo");
            DropColumn("dbo.TiposDeTransportes", "QntDeVagas");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TiposDeTransportes", "QntDeVagas", c => c.Int(nullable: false));
            AddColumn("dbo.MarcaVeiculoes", "TipoDeVeiculo", c => c.String());
            DropForeignKey("dbo.MarcaVeiculoes", "TipoVeiculoFK", "dbo.TiposDeTransportes");
            DropIndex("dbo.MarcaVeiculoes", new[] { "TipoVeiculoFK" });
            DropColumn("dbo.MarcaVeiculoes", "TipoVeiculoFK");
        }
    }
}
