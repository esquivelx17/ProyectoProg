using System.Collections.Generic;
using InventariosCore.Data;
using InventariosCore.Model;
//using InvSis.Views;

namespace InventariosCore.Controllers
{
    public class PermisosController
    {
        private readonly PermisosDataAccess _dataAccess;
        //private readonly frmGestrionPermisos _view;

        public PermisosController(/*frmGestrionPermisos view*/)
        {
            //_view = view;
            _dataAccess = new PermisosDataAccess();
        }

        public bool AgregarPermiso(Permiso permiso)
        {
            int id = _dataAccess.InsertarPermiso(permiso);
            return id > 0;
        }

        public bool ActualizarPermiso(Permiso permiso)
        {
            return _dataAccess.ActualizarPermiso(permiso);
        }

        public Permiso? GetPermisoByNombre(string nombre)
        {
            return _dataAccess.ObtenerPermisoPorNombre(nombre);
        }

        public List<Permiso> ObtenerPermisos(bool soloActivos = true)
        {
            return _dataAccess.ObtenerTodosLosPermisos(soloActivos);
        }

        public bool InhabilitarPermisoPorNombre(string nombre)
        {
            var permiso = _dataAccess.ObtenerPermisoPorNombre(nombre);
            if (permiso == null) return false;

            permiso.Estatus = 2; // Inactivo
            return _dataAccess.ActualizarPermiso(permiso);
        }
    }
}