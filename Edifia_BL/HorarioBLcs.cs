using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edifia_ADO;

namespace Edifia_BL
{
    public class HorarioBL
    {
        HorarioADO objHorarioADO = new HorarioADO();

        public DataTable ListarHorario()
        {
            return objHorarioADO.ListarHorario();
        }

        public string ObtenerDescripcionHorario(int horarioId)
        {
            return objHorarioADO.ObtenerDescripcionHorario(horarioId);
        }
    }
}
