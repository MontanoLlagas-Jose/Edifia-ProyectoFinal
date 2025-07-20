using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edifia_ADO;

namespace Edifia_BL
{
    public class EdificioBL
    {
        EdificioADO objEdificioADO = new EdificioADO();

        public DataTable ListarEdificios()
        {
            return objEdificioADO.ListarEdificios();
        }

        public string ObtenerNombreEdificio(int edificioId)  
        {
            return objEdificioADO.ObtenerNombreEdificio(edificioId);
        }

    }
}
