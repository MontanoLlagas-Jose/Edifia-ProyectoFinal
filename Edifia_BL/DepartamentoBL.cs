using Edifia_ADO;
using Edifia_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_BL
{
    public class DepartamentoBL
    {
        DepartamentoADO objDepartamentoADO = new DepartamentoADO();

        public DataTable ListarDepartamento()
        {
            return objDepartamentoADO.ListarDepartamento();
        }
        public DepartamentoBE ConsultarDepartamento(String strCodigo)
        {
            return objDepartamentoADO.ConsultarDepartamento(strCodigo);
        }

        public Boolean InsertarDepartamento(DepartamentoBE objDepartamentoBE)
        {
            return objDepartamentoADO.InsertarDepartamento(objDepartamentoBE);
        }
        public Boolean ActualizarDepartamento(DepartamentoBE objDepartamentoBE)
        {
            return objDepartamentoADO.ActualizarDepartamento(objDepartamentoBE);
        }
        public Boolean EliminarDepartamento(int numero)
        {
            return objDepartamentoADO.EliminarDepartamento(numero);
        }

        public DataTable ListarDepartamentosVisita()
        {
            return objDepartamentoADO.ListarDepartamentosVisita();
        }

    }
}
