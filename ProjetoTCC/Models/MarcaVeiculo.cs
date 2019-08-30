using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTCC.Models
{
    public class MarcaVeiculo
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string TipoDeVeiculo { get; set; }
        public string Descricao { get; set; }
    }
}