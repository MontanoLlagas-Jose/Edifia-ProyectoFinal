using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_BE
{    public class EmpleadoBE
    {
    
        public String nombre { get; set; }

        public String apellido { get; set; }

        public String documento { get; set; }

        public bool sexo { get; set; }

        public Int16 horario_id { get; set; }

        public DateTime fecha_de_nacimiento { get; set; }

        public String telefono { get; set; }

        public String correo { get; set; }

        public DateTime fecha_inicio { get; set; }

        public DateTime fecha_fin { get; set; }

        public Int16 tipo_id { get; set; }

        public byte[] foto { get; set; }

        public DateTime fec_reg { get; set; }

        public String usu_reg { get; set; }

        public String usu_ult_mod { get; set; }


    }
}
