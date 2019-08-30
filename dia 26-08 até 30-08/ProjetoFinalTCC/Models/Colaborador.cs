using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalTCC.Models
{
    public class Colaborador
    {
        [Key]
        public int Id { get; set; }
        public int IdRegistration { get; set; }
        public string NomeColaborador { get; set; }
        public string Email { get; set; }
        public bool ResideBlumenau { get; set; } = false;
        public bool Carona { get; set; } = false;
        public bool PCD { get; set; } = false;
        public bool TrabalhoNoturno { get; set; } = false;
    }
}