//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace ProjetoTCC.Models
//{
//    public class Veiculo
//    {
//        [Key]  
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