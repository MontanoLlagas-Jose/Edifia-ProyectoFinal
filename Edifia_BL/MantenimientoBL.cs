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
    public class MantenimientoBL
    {
        MantenimientoADO objMantenimientoADO = new MantenimientoADO();

        public Boolean InsertarMantenimiento(MantenimientoBE objMantenimientoBE)
        {
            return objMantenimientoADO.InsertarMantenimiento(objMantenimientoBE);
        }

        public DataTable ListarMantenimiento()
        {
            return objMantenimientoADO.ListarMantenimiento();
        }

        public MantenimientoBE ConsultarMantenimiento(Int32 Codigo)
        {
            return objMantenimientoADO.ConsultarMantenimiento(Codigo);
        }

        public Boolean ActualizarMantenimiento(MantenimientoBE objMantenimientoBE)
        {
            return objMantenimientoADO.ActualizarMantenimiento(objMantenimientoBE);
        }

        public Boolean EliminarMantenimiento(String codigo) {
            return objMantenimientoADO.EliminarMantenimiento(codigo);
        }

        public List<MantenimientoBE> ListarMantenimientosProximos24Horas()
        {
            return objMantenimientoADO.ListarMantenimientosProximos24Horas();
        }

    }
}