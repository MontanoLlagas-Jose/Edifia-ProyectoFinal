using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edifia_ADO;
using Edifia_BE;

namespace Edifia_BL
{
    public class UsuarioBL
    {
        private readonly UsuarioADO _usuarioDao;
        private int _intentosFallidos;

        public UsuarioBL()
        {
            _usuarioDao = new UsuarioADO();
            _intentosFallidos = 0; // Inicializamos los intentos a 0
        }

        public Usuario Login(string login, string password)
        {
            if (_intentosFallidos >= 3)
            {
                throw new Exception("Has alcanzado el límite máximo de intentos. Por favor, intenta más tarde.");
            }

            Usuario usuario = _usuarioDao.Login(login, password);
            if (usuario == null)
            {
                _intentosFallidos++; // Incrementamos el contador de intentos fallidos
                throw new Exception($"Credenciales incorrectas. Intentos restantes: {3 - _intentosFallidos}");
            }

            // Reiniciamos el contador de intentos si el inicio de sesión es exitoso
            _intentosFallidos = 0;
            return usuario;
        }
    }
}
