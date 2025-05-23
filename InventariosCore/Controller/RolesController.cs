using System.Collections.Generic;
using System.Linq;
using InventariosCore.Data;
using InventariosCore.Model;

namespace InventariosCore.Controllers
{
    public class RolesController
    {
        internal readonly RolesDataAccess _rolesDataAccess;
        internal readonly PermisosController _permisosController;
        internal readonly RolPermisoDataAccess _rolPermisoDataAccess;

        public RolesController()
        {
            _rolesDataAccess = new RolesDataAccess();
            _permisosController = new PermisosController(); // Si quieres pasar vista, ajusta
            _rolPermisoDataAccess = new RolPermisoDataAccess();
        }

        public bool AgregarRol(Rol rol)
        {
            int id = _rolesDataAccess.InsertarRol(rol);
            return id > 0;
        }

        public bool ActualizarRol(Rol rol)
        {
            return _rolesDataAccess.ActualizarRol(rol);
        }

        public Rol? GetRolPorNombre(string nombreRol)
        {
            var todos = ObtenerRoles(soloActivos: false);
            foreach (var rol in todos)
            {
                if (rol.NombreRol.Equals(nombreRol, System.StringComparison.OrdinalIgnoreCase))
                    return rol;
            }
            return null;
        }

        public List<Rol> ObtenerRoles(bool soloActivos = true)
        {
            return _rolesDataAccess.ObtenerTodosLosRoles(soloActivos);
        }

        public bool InhabilitarRolPorId(int idRol)
        {
            return _rolesDataAccess.EliminarRol(idRol);
        }

        // Asignar permiso a rol
        public bool AsignarPermisoARol(int idRol, int idPermiso)
        {
            return _rolPermisoDataAccess.InsertarRolPermiso(idRol, idPermiso);
        }

        // Eliminar permiso asignado a rol
        public bool RemoverPermisoDeRol(int idRol, int idPermiso)
        {
            return _rolPermisoDataAccess.EliminarRolPermiso(idRol, idPermiso);
        }

        // Obtener permisos asignados a un rol
        public List<Permiso> ObtenerPermisosAsignados(int idRol)
        {
            return _rolPermisoDataAccess.ObtenerPermisosDeRol(idRol);
        }

        // Obtener permisos disponibles para asignar (todos menos los ya asignados)
        public List<Permiso> ObtenerPermisosDisponibles(int idRol)
        {
            var todos = _permisosController.ObtenerPermisos(soloActivos: true);
            var asignados = ObtenerPermisosAsignados(idRol);
            return todos.Where(p => !asignados.Any(a => a.IdPermiso == p.IdPermiso)).ToList();
        }
    }
}
