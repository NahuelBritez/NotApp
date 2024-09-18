using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class TareasNegocio
    {
        public List<Tarea> Listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Tarea> tareas = new List<Tarea>();
            string query = @"
    SELECT 
        T.IdTarea AS IdTarea, 
        T.Descripcion AS Descripcion, 
        T.FechaCreacion, 
        T.FechaRecordatorio, 
        T.Categoria, 
        T.Estado, 
        P.Nombre AS ProyectoNombre,  
        U.Nombre AS NombreUsuario    
    FROM 
        Tareas T 
    JOIN 
        Proyectos P ON T.IdProyecto = P.IdProyecto 
    JOIN 
        Usuarios U ON T.IdUsuario = U.IdUsuario";

            try
            {
                datos.Consulta(query);
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Tarea aux = new Tarea();
                    aux.IdTarea = (int)datos.Lector["IdTarea"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.FechaCreacion = (DateTime)datos.Lector["FechaCreacion"];
                    aux.Recordatorio = (DateTime)datos.Lector["FechaRecordatorio"];
                    aux.Categoria = (string)datos.Lector["Categoria"];
                    aux.Estado = (string)datos.Lector["Estado"];

                    Usuario usuario = new Usuario();
                    usuario.NombreUsuario = (string)datos.Lector["NombreUsuario"];
                    aux.NombreUsuario = usuario;

                    Proyecto proyecto = new Proyecto();
                    proyecto.ProyectoNombre = (string)datos.Lector["ProyectoNombre"];
                    aux.ProyectoNombre = proyecto;

                    tareas.Add(aux);
                }
                datos.CerrarConexion();
                return tareas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
