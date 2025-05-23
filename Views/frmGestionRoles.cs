using InventariosCore.Controllers;
using InventariosCore.Model;
using System;
using System.Windows.Forms;

namespace InvSis.Views
{
    public partial class frmGestionRoles : Form
    {
        private RolesController _rolesController;
        private Rol? rolSeleccionado = null;

        public frmGestionRoles()
        {
            InitializeComponent();
            _rolesController = new RolesController();

            CargarRoles();

            dgvRoles.SelectionChanged += DgvRoles_SelectionChanged;
            dgvPermisosAsignados.SelectionChanged += DgvPermisosAsignados_SelectionChanged;
            dtvPermisosDiaponibles.SelectionChanged += DtvPermisosDiaponibles_SelectionChanged;

            btnAgregar.Click += BtnAgregar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnAgregarRol.Click += BtnAgregarRol_Click;

            // Usar CellFormatting con tus nombres de columnas actuales
            dgvRoles.CellFormatting += Dgv_CellFormatting_Estatus;
            dgvPermisosAsignados.CellFormatting += Dgv_CellFormatting_Estatus;
            dtvPermisosDiaponibles.CellFormatting += Dgv_CellFormatting_Estatus;

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void CargarRoles()
        {
            var roles = _rolesController.ObtenerRoles(soloActivos: false);
            dgvRoles.DataSource = roles;
            dgvRoles.Refresh();

            LimpiarPermisos();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void DgvRoles_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow == null)
            {
                rolSeleccionado = null;
                LimpiarPermisos();
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                return;
            }

            rolSeleccionado = dgvRoles.CurrentRow.DataBoundItem as Rol;

            if (rolSeleccionado != null)
            {
                ActualizarPermisos(rolSeleccionado.IdRol);
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
            }
            else
            {
                LimpiarPermisos();
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void ActualizarPermisos(int idRol)
        {
            var asignados = _rolesController.ObtenerPermisosAsignados(idRol);
            dgvPermisosAsignados.DataSource = asignados;
            dgvPermisosAsignados.Refresh();

            var disponibles = _rolesController.ObtenerPermisosDisponibles(idRol);
            dtvPermisosDiaponibles.DataSource = disponibles;
            dtvPermisosDiaponibles.Refresh();

            btnEliminar.Enabled = false;
        }

        private void LimpiarPermisos()
        {
            dgvPermisosAsignados.DataSource = null;
            dtvPermisosDiaponibles.DataSource = null;
        }

        private void BtnAgregar_Click(object? sender, EventArgs e)
        {
            if (rolSeleccionado == null)
            {
                MessageBox.Show("Por favor selecciona un rol primero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtvPermisosDiaponibles.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un permiso disponible para agregar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var permiso = dtvPermisosDiaponibles.CurrentRow.DataBoundItem as Permiso;
            if (permiso == null) return;

            bool exito = _rolesController.AsignarPermisoARol(rolSeleccionado.IdRol, permiso.IdPermiso);
            if (exito)
            {
                MessageBox.Show("Permiso asignado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarPermisos(rolSeleccionado.IdRol);
            }
            else
            {
                MessageBox.Show("El permiso ya está asignado o hubo un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object? sender, EventArgs e)
        {
            if (rolSeleccionado == null)
            {
                MessageBox.Show("Por favor selecciona un rol primero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvPermisosAsignados.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un permiso asignado para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var permiso = dgvPermisosAsignados.CurrentRow.DataBoundItem as Permiso;
            if (permiso == null) return;

            var confirm = MessageBox.Show($"¿Seguro que deseas eliminar el permiso '{permiso.Nombre}' del rol '{rolSeleccionado.NombreRol}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            bool exito = _rolesController.RemoverPermisoDeRol(rolSeleccionado.IdRol, permiso.IdPermiso);
            if (exito)
            {
                MessageBox.Show("Permiso eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarPermisos(rolSeleccionado.IdRol);
            }
            else
            {
                MessageBox.Show("Error al eliminar el permiso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarRol_Click(object? sender, EventArgs e)
        {
            using var formRoles = new frmCreacionRoles();
            formRoles.ShowDialog();
            CargarRoles();
        }

        private void dgvPermisosAsignados_SelectionChanged(object? sender, EventArgs e)
        {
            btnEliminar.Enabled = dgvPermisosAsignados.CurrentRow != null;
        }

        private void dtvPermisosDiaponibles_SelectionChanged(object? sender, EventArgs e)
        {
            btnAgregar.Enabled = dtvPermisosDiaponibles.CurrentRow != null && rolSeleccionado != null;
        }

        private void Dgv_CellFormatting_Estatus(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null)
                return;

            string estatusColName = "";
            if (dgv == dgvRoles)
                estatusColName = "EstatusPermiso"; // según tu InitializeComponent
            else if (dgv == dgvPermisosAsignados)
                estatusColName = "dataGridViewTextBoxColumn2"; // columna estatus asignados
            else if (dgv == dtvPermisosDiaponibles)
                estatusColName = "dataGridViewTextBoxColumn5"; // columna estatus disponibles

            if (dgv.Columns[e.ColumnIndex].Name == estatusColName && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int estatus))
                {
                    e.Value = estatus switch
                    {
                        1 => "Activo",
                        2 => "Inactivo",
                        _ => "Desconocido"
                    };
                    e.FormattingApplied = true;
                }
            }
        }


        private void DgvPermisosAsignados_SelectionChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = dgvPermisosAsignados.CurrentRow != null;
        }

        private void DtvPermisosDiaponibles_SelectionChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = dtvPermisosDiaponibles.CurrentRow != null && rolSeleccionado != null;
        }



    }
}
