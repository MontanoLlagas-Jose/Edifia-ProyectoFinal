using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_BE
{
    public class ResultadoOperacion
    {
        public bool Exito { get; set; }
        public string Tipo { get; set; } // "OK", "RECUPERABLE", "CRITICO"
        public string Mensaje { get; set; }

        public static ResultadoOperacion Ok(string mensaje) =>
            new ResultadoOperacion { Exito = true, Tipo = "OK", Mensaje = mensaje };

        public static ResultadoOperacion Recuperable(string mensaje) =>
            new ResultadoOperacion { Exito = false, Tipo = "RECUPERABLE", Mensaje = mensaje };

        public static ResultadoOperacion Critico(string mensaje) =>
            new ResultadoOperacion { Exito = false, Tipo = "CRITICO", Mensaje = mensaje };
    }
}
