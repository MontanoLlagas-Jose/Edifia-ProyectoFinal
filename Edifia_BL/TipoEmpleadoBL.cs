using Edifia_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_BL
{
    public class TipoEmpleadoBL
    {
        TipoEmpleadoADO objTipoEmpleadoADO = new TipoEmpleadoADO();

        public DataTable ListarTipoEmpleado()
        {
            return objTipoEmpleadoADO.ListarTipo();
        }

        public DataTable ListarCargo()
        {
            return objTipoEmpleadoADO.ListarCargo();
        }
    }
}
