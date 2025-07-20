using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edifia_ADO;
using Edifia_BE;

namespace Edifia_BL
{
    public class EmpleadoBL
    {
        EmpleadoADO objEmpleadoADO = new EmpleadoADO();

        public DataTable ListarEmpleado()
        {
            return objEmpleadoADO.ListarEmpleado();
        }

        public DataTable ListarEmpleadoEmpleado()
        {
            return objEmpleadoADO.ListarEmpleadoEmpleado();
        }

        public EmpleadoBE ConsultarEmpleado(String documento)
        {
            return objEmpleadoADO.ConsultarEmpleado(documento);
        }

        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.InsertarEmpleado(objEmpleadoBE);
        }
        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.ActualizarEmpleado(objEmpleadoBE);
        }
        public Boolean EliminarEmpleado(String strDNI)
        {
            return objEmpleadoADO.EliminarEmpleado(strDNI);
        }

        public DataTable ListarEmpleadoReporteExcel()
        {
            return objEmpleadoADO.ListarEmpleadoReporteExcel();
        }

    }
}
