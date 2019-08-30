using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalTCC.Models
{
    public class Locacao
    {
        [Key]
        public int Id { get; set; }

        public int CodTipoDeVeiculo { get; set; }
        public int CodMarca { get; set; } = 0;
        public int CodModelo { get; set; } = 0;
        public int CodCor { get; set; } = 0;
        [CustomValidFields(Enums.ValidFields.ValidaPlacaCarro)]
        public string PlacaCarro { get; set; }
        public int CodPeriodoLoc { get; set; }
        public int CodColaborador { get; set; } = 1;
        public bool AceitaTermo { get; set; }
        public int Status { get; set; }
    }
}