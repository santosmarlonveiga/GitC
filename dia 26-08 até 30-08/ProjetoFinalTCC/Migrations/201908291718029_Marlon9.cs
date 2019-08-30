namespace ProjetoFinalTCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marlon9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colaboradors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdRegistration = c.Int(nullable: false),
                        NomeColaborador = c.String(),
                        Email = c.String(),
                        ResideBlumenau = c.Boolean(nullable: false),
                        Carona = c.Boolean(nullable: false),
                        PCD = c.Boolean(nullable: false),
                        TrabalhoNoturno = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Colaboradors");
        }
    }
}
