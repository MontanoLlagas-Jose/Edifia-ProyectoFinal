using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Edifia_ADO;

namespace Edifia_BL
{
    public class TipoVisitaBL
    {
        TipoVisitaADO objTipoVisitaADO = new TipoVisitaADO();

        public DataTable ListarTipoVisita()
        {
            return objTipoVisitaADO.ListarTipoVisita();
        }
    }
}
