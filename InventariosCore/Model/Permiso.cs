using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosCore.Model
{
    public class Permiso
    {
        /// <summary>
        /// Identificador único del permiso
        /// </summary>
        public int IdPermiso { get; set; }

        /// <summary>
        /// Descripción del permiso
        /// </summary>

        // Propiedad adicional para el nombre del permiso
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        /// <summary>
        /// Estado del permiso (1=activo, 2=inactivo)
        /// </summary>
        public int Estatus { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Permiso()
        {
            Descripcion = string.Empty;
            Estatus = 1; // Activo por defecto
        }

        /// <summary>
        /// Constructor con datos básicos
        /// </summary>
        public Permiso(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Estatus = 1; // Activo por defecto
        }

        /// <summary>
        /// Constructor completo
        /// </summary>
        public Permiso(int idPermiso, string nombre, string descripcion, int estatus)
        {
            IdPermiso = idPermiso;
            Nombre = nombre;
            Descripcion = descripcion;
            Estatus = estatus;
        }
    
    }

}
