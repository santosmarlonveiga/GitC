namespace ProjetoFinalTCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marlon4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Termoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TermoDeUsoLocacao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Termoes");
        }
    }
}
