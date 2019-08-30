using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalTCC.Models
{
    public class Termo
    {
        [Key]
        public int Id { get; set; }
        public string TermoDeUsoLocacao { get; set; }
        public bool Ativo { get; set; } = true;
    }
}