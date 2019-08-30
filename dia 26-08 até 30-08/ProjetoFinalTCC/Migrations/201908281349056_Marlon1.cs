namespace ProjetoFinalTCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marlon1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        TipoDeCores = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MarcaVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        TipoDeVeiculo = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ModeloVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        MarcaFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MarcaVeiculoes", t => t.MarcaFK, cascadeDelete: true)
                .Index(t => t.MarcaFK);
            
            CreateTable(
                "dbo.TiposDeTransportes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Descricao = c.String(),
                        QntDeVagas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ModeloVeiculoes", "MarcaFK", "dbo.MarcaVeiculoes");
            DropIndex("dbo.ModeloVeiculoes", new[] { "MarcaFK" });
            DropTable("dbo.TiposDeTransportes");
            DropTable("dbo.ModeloVeiculoes");
            DropTable("dbo.MarcaVeiculoes");
            DropTable("dbo.Cores");
        }
    }
}
