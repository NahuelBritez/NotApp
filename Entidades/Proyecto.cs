using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proyecto
    {
        public int IdProyecto { get; set; }

        public string ProyectoNombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin{ get; set; }
        public Usuario IdRol { get; set; }

        public override string ToString()
        {
            return ProyectoNombre;
        }

    }
}
