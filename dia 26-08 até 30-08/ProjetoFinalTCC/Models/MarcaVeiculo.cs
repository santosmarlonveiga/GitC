using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinalTCC.Models
{
    public class MarcaVeiculo
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        [ForeignKey("TipoVeiculoFK")]
        public virtual TiposDeTransporte TiposDeTransporte { get; set; }
        public int TipoVeiculoFK { get; set; }
        public string Descricao { get; set; }
        
    }
}