using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_BE
{
    public class Usuario
    {
        public int Id { get; set; }
        public string LoginUsuario { get; set; }
        public string PassUsuario { get; set; }
        public int PersonaId { get; set; }
        public int NivelUsuario { get; set; }
        public bool EstadoUsuario { get; set; }
        public DateTime FecRegistro { get; set; }
    }
}
