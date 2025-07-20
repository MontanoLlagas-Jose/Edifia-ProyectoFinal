using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edifia_ADO;

namespace Edifia_BL
{
    public class AreaComunBL
    {
        AreaComunADO objAreaComunADO = new AreaComunADO();

        public DataTable ListarAreaComun()
        {
            return objAreaComunADO.ListarAreaComun();
        }
    }
}
