using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_BE
{
    public class HabitanteBE
    {   
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string documento { get; set; }
        public bool es_propietario { get; set; }
         public Int16 Activo { get; set; }
        public DateTime? fecha_ingreso { get; set; }
        public DateTime? fecha_egreso { get; set; }
        public int departamento_id { get; set; }
        public string Edificio { get; set; }
        public int numero { get; set; }
        public Byte[] foto { get; set; }
        public DateTime Fec_reg { get; set; }
        public string Usu_Registro { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
        
    }
}
