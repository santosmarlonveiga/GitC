using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinalTCC.Models
{
    public class PeriodoDeLocacao
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("TipoVeiculoFK")]
        public virtual TiposDeTransporte TiposDeTransporte { get; set; }
        public int TipoVeiculoFK { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataInicial { get; set; } 
        public DateTime DataFinal { get; set; }
        public bool Ativo { get; set; } = false;

    }
}