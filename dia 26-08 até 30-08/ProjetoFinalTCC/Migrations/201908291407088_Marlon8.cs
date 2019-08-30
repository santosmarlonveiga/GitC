namespace ProjetoFinalTCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marlon8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodTipoDeVeiculo = c.Int(nullable: false),
                        CodMarca = c.Int(nullable: false),
                        CodModelo = c.Int(nullable: false),
                        CodCor = c.Int(nullable: false),
                        PlacaCarro = c.String(),
                        CodPeriodoLoc = c.Int(nullable: false),
                        CodColaborador = c.Int(nullable: false),
                        AceitaTermo = c.Boolean(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Locacaos");
        }
    }
}
