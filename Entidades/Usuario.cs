using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string IdRol { get; set; }
        public string NombreUsuario { get; set; }
        public string Mail { get; set; }
        public Hash Contraseña { get; set; }

        public override string ToString()
        {
            return NombreUsuario;
        }

    }
}
