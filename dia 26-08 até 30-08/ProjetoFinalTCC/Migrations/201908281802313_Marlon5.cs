namespace ProjetoFinalTCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marlon5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PeriodoDeLocacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoDeVeiculo = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataInicial = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PeriodoDeLocacaos");
        }
    }
}
