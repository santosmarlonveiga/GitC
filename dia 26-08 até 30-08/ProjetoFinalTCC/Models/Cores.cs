using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalTCC.Models
{
    public class Cores
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string TipoDeCores { get; set; }
    }
}