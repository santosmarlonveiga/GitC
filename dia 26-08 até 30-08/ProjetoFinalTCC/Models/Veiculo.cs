//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Web;

//namespace ProjetoFinalTCC.Models
//{
//    public class Veiculo
//    {
//        public int Id { get; set; }
//        public string Placa { get; set; }
//        [ForeignKey("ModeloFK")]
//        public ModeloVeiculo ModeloVeiculo { get; set; }
//        public int ModeloFK { get; set; }
//        [ForeignKey("CorFK")]
//        public Cores Cores { get; set; }
//        public int CorFK { get; set; }
//    }
//}