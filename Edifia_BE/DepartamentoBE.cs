using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_BE
{
    public class DepartamentoBE
    {
        public Int16 id { get; set; }
        public Int16 numero { get; set; }
        public Int16 piso { get; set; }
        public Int16 edificio_id { get; set; }
        public byte[] plano { get; set; }
        public DateTime Fec_reg { get; set; }
        public String Usu_registro { get; set; }
        public DateTime Fec_ult_mod { get; set; }
        public String Usu_ult_mod { get; set; }
        public bool habitado { get; set; }
    }
}
