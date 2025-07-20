using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_BE
{
    public class MantenimientoBE
    {
        public Int32 id {  get; set; }
        public Int16 actividad_id { get; set; }

        public DateTime? fecha_programada { get; set; }
        public DateTime? fecha_realizacion { get; set; }

        public String responsable { get; set; }
        public String tipoEmpleado { get; set; }

        public Int16 edificio_id { get; set; }
        public DateTime Fec_Reg { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public String Usu_Ult_Mod { get; set; }

        //----------
        public String codigo { get; set; }
        public String descripcion { get; set; }

        public string actividad_nombre { get; set; }
        public string edificio_nombre { get; set; }
        public string responsable_nombre { get; set; }


    }
}