using System;
using System.Collections.Generic;
using System.Data;
using InventariosCore.Model;
using Npgsql;
using NLog;
using InventariosCore.Utilities;

namespace InventariosCore.Data
{
    public class RolPermisoDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("InvSis.Data.RolPermisoDataAccess");
        private readonly PostgreSQLDataAccess _dbAccess;

        public RolPermisoDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "Error al inicializar RolPermisoDataAccess");
                throw;
            }
        }

        public bool InsertarRolPermiso(int idRol, int idPermiso)
        {
            try
            {
                string query = "INSERT INTO roles_permisos (id_rol, id_permiso) VALUES (@IdRol, @IdPermiso)";
                var paramRol = _dbAccess.CreateParameter("@IdRol", idRol);
                var paramPermiso = _dbAccess.CreateParameter("@IdPermiso", idPermiso);

                _dbAccess.Connect();
                int filas = _dbAccess.ExecuteNonQuery(query, paramRol, paramPermiso);

                bool exito = filas > 0;
                if (exito)
                {
                    _logger.Info($"Asignación rol-permiso insertada: Rol {idRol}, Permiso {idPermiso}");
                }

                return exito;
            }
            catch (PostgresException ex) when (ex.SqlState == "23505") // Violation unique constraint (ya existe)
            {
                _logger.Warn($"Asignación rol-permiso ya existe: Rol {idRol}, Permiso {idPermiso}");
                return false;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al insertar asignación rol-permiso: Rol {idRol}, Permiso {idPermiso}");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        public bool EliminarRolPermiso(int idRol, int idPermiso)
        {
            try
            {
                string query = "DELETE FROM roles_permisos WHERE id_rol = @IdRol AND id_permiso = @IdPermiso";
                var paramRol = _dbAccess.CreateParameter("@IdRol", idRol);
                var paramPermiso = _dbAccess.CreateParameter("@IdPermiso", idPermiso);

                _dbAccess.Connect();
                int filas = _dbAccess.ExecuteNonQuery(query, paramRol, paramPermiso);

                bool exito = filas > 0;
                if (exito)
                {
                    _logger.Info($"Asignación rol-permiso eliminada: Rol {idRol}, Permiso {idPermiso}");
                }
                else
                {
                    _logger.Warn($"No se encontró la asignación para eliminar: Rol {idRol}, Permiso {idPermiso}");
                }

                return exito;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al eliminar asignación rol-permiso: Rol {idRol}, Permiso {idPermiso}");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        public List<RolPermiso> ObtenerTodasAsignaciones()
        {
            var lista = new List<RolPermiso>();

            try
            {
                string query = @"
                    SELECT rp.id_rol, rp.id_permiso,
                           r.nombre_rol, r.estatus as rol_estatus,
                           p.nombre as permiso_nombre, p.descripcion, p.estatus as permiso_estatus
                    FROM roles_permisos rp
                    INNER JOIN roles r ON rp.id_rol = r.id_rol
                    INNER JOIN permisos p ON rp.id_permiso = p.id_permiso";

                _dbAccess.Connect();
                DataTable dt = _dbAccess.ExecuteQuery_Reader(query);

                foreach (DataRow row in dt.Rows)
                {
                    var rol = new Rol(
                        Convert.ToInt32(row["id_rol"]),
                        row["nombre_rol"].ToString() ?? "",
                        Convert.ToInt32(row["rol_estatus"])
                    );

                    var permiso = new Permiso(
                        Convert.ToInt32(row["id_permiso"]),
                        row["permiso_nombre"].ToString() ?? "",
                        row["descripcion"].ToString() ?? "",
                        Convert.ToInt32(row["permiso_estatus"])
                    );

                    lista.Add(new RolPermiso(
                        Convert.ToInt32(row["id_rol"]),
                        Convert.ToInt32(row["id_permiso"]),
                        rol,
                        permiso
                    ));
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener todas las asignaciones rol-permiso");
            }
            finally
            {
                _dbAccess.Disconnect();
            }

            return lista;
        }

        public bool ExisteAsignacion(int idRol, int idPermiso)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM roles_permisos WHERE id_rol = @IdRol AND id_permiso = @IdPermiso";
                var paramRol = _dbAccess.CreateParameter("@IdRol", idRol);
                var paramPermiso = _dbAccess.CreateParameter("@IdPermiso", idPermiso);

                _dbAccess.Connect();
                object? result = _dbAccess.ExecuteScalar(query, paramRol, paramPermiso);
                int count = Convert.ToInt32(result);

                return count > 0;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al verificar asignación rol-permiso: Rol {idRol}, Permiso {idPermiso}");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        // Opcional: Obtener permisos asignados a un rol
        public List<Permiso> ObtenerPermisosDeRol(int idRol)
        {
            var permisos = new List<Permiso>();

            try
            {
                string query = @"
                    SELECT p.id_permiso, p.nombre, p.descripcion, p.estatus
                    FROM permisos p
                    INNER JOIN roles_permisos rp ON p.id_permiso = rp.id_permiso
                    WHERE rp.id_rol = @IdRol";

                var paramRol = _dbAccess.CreateParameter("@IdRol", idRol);

                _dbAccess.Connect();
                DataTable dt = _dbAccess.ExecuteQuery_Reader(query, paramRol);

                foreach (DataRow row in dt.Rows)
                {
                    permisos.Add(new Permiso(
                        Convert.ToInt32(row["id_permiso"]),
                        row["nombre"].ToString() ?? "",
                        row["descripcion"].ToString() ?? "",
                        Convert.ToInt32(row["estatus"])
                    ));
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener permisos del rol {idRol}");
            }
            finally
            {
                _dbAccess.Disconnect();
            }

            return permisos;
        }

        // Opcional: Obtener roles asignados a un permiso
        public List<Rol> ObtenerRolesDePermiso(int idPermiso)
        {
            var roles = new List<Rol>();

            try
            {
                string query = @"
                    SELECT r.id_rol, r.nombre_rol, r.estatus
                    FROM roles r
                    INNER JOIN roles_permisos rp ON r.id_rol = rp.id_rol
                    WHERE rp.id_permiso = @IdPermiso";

                var paramPermiso = _dbAccess.CreateParameter("@IdPermiso", idPermiso);

                _dbAccess.Connect();
                DataTable dt = _dbAccess.ExecuteQuery_Reader(query, paramPermiso);

                foreach (DataRow row in dt.Rows)
                {
                    roles.Add(new Rol(
                        Convert.ToInt32(row["id_rol"]),
                        row["nombre_rol"].ToString() ?? "",
                        Convert.ToInt32(row["estatus"])
                    ));
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener roles del permiso {idPermiso}");
            }
            finally
            {
                _dbAccess.Disconnect();
            }

            return roles;
        }
    }
}
