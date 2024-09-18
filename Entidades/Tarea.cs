using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tarea
    {
        public int IdTarea { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime Recordatorio { get; set; }
        public string Categoria { get; set; }
        public string Estado { get; set; }
        [DisplayName("Usuario")]
        public Usuario NombreUsuario { get; set; }
        [DisplayName("Nombre del Proyecto")]
        public Proyecto ProyectoNombre { get; set; }
    }
}
