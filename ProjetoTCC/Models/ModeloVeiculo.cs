using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoTCC.Models
{
    public class ModeloVeiculo
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        [ForeignKey("MarcaFK")]
        public MarcaVeiculo MarcaVeiculo { get; set; }
        public int MarcaFK { get; set; }
    }
}