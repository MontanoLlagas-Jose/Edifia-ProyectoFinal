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
    public class VisitaBL
    {
        VisitaADO objVisitaADO = new VisitaADO();

        public DataTable ListarVisita()
        {
            return objVisitaADO.ListarVisita();
        }

        public VisitaBE ConsultarVisita(String strVisita)
        {
            return objVisitaADO.ConsultarVisita(strVisita);
        }

        public Boolean InsertarVisita(VisitaBE objVisitaBE)
        {
            return objVisitaADO.InsertarVisita(objVisitaBE);
        }
        public Boolean ActualizarVisita(VisitaBE objVisitaBE)
        {
            return objVisitaADO.ActualizarVisita(objVisitaBE);
        }
        //Jose
        public Boolean EliminarVisita(String strVisita, DateTime fecUltMod, String usuUltMod)
        {
            return objVisitaADO.EliminarVisita(strVisita, fecUltMod, usuUltMod);
        }
        //Jose

        public VisitaBE ObtenerVisitaPorId(int id)
        {
            return objVisitaADO.ObtenerVisitaPorId(id);
        }

        public DataTable ListarVisitasReporteExcel()
        {
            return objVisitaADO.ListarVisitasReporteExcel();
        }
    }
}
