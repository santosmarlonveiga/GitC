using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoFinalTCC.Models
{
    public class ContexDb : DbContext
    {
        public DbSet<Cores> Cores { get; set; }
        public DbSet<MarcaVeiculo> MarcasVeiculos { get; set; }
        public DbSet<ModeloVeiculo> ModelosVeiculos { get; set; }
        public DbSet<TiposDeTransporte> TiposDeTransportes { get; set; }

        public DbSet<Termo> Termoes { get; set; }

        public DbSet<PeriodoDeLocacao> PeriodoDeLocacaos { get; set; }

        public System.Data.Entity.DbSet<ProjetoFinalTCC.Models.Locacao> Locacaos { get; set; }

        public System.Data.Entity.DbSet<ProjetoFinalTCC.Models.Colaborador> Colaboradors { get; set; }
        //public DbSet<OutrosTransportes> outrosTransportes { get; set; }

    }
}