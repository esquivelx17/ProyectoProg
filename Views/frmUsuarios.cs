using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InventariosCore.Controllers;
using InventariosCore.Model;

namespace InvSis.Views
{
    public partial class frmUsuarios : Form
    {
        private UsuariosController _usuarioController;

        public frmUsuarios()
        {
            InitializeComponent();
            _usuarioController = new UsuariosController();

            PoblarComboEstatus(cbEstatus);
            PoblarComboEstatus(cbCambioEstatus);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarPersonasEnDataGridView();
            CargarRolesEnCombo(cbRol);
            CargarRolesEnCombo(cbCambioRol);
            CargarUsuariosEnGrid();
        }

        private void PoblarComboEstatus(ComboBox comboBox)
        {
            var list_estatus = new Dictionary<int, string>()
            {
                { 1, "Activo"},
                { 0, "Inactivo"},
            };
            comboBox.DataSource = new BindingSource(list_estatus, null);
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
            comboBox.SelectedValue = 1;
        }

        private void CargarRolesEnCombo(ComboBox comboBox)
        {
            try
            {
                var roles = _usuarioController.ObtenerTodosLosRoles();

                comboBox.DataSource = null;    // Limpiar antes por si acaso
                comboBox.DataSource = roles;
                comboBox.DisplayMember = "NombreRol";   // Debe coincidir con propiedad real de Rol
                comboBox.ValueMember = "IdRol";       // Debe coincidir con propiedad real de Rol
                comboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarPersonasEnDataGridView()
        {
            try
            {
                var personas = _usuarioController.ObtenerTodasLasPersonas();
                dgvSeleccionPersona.Rows.Clear();

                foreach (var p in personas)
                {
                    int filaIndex = dgvSeleccionPersona.Rows.Add(
                        p.NombreCompleto,
                        p.Edad.HasValue ? p.Edad.Value.ToString() : "",
                        p.Sexo,
                        p.Nacionalidad
                    );

                    dgvSeleccionPersona.Rows[filaIndex].Tag = p.IdPersona;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar personas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuariosEnGrid()
        {
            try
            {
                dgvSeleccionUsuario.Rows.Clear();
                var usuarios = _usuarioController.ObtenerUsuarios();

                foreach (var u in usuarios)
                {
                    int filaIndex = dgvSeleccionUsuario.Rows.Add(
                        u.Rol.NombreRol,
                        u.Nickname,
                        "********",  // No mostrar contraseña real
                        u.Estatus == 1 ? "Activo" : "Inactivo",
                        u.Persona.NombreCompleto
                    );

                    dgvSeleccionUsuario.Rows[filaIndex].Tag = u.IdUsuario;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DatosVacios()
        {
            return string.IsNullOrWhiteSpace(txtNickname.Text)
                || string.IsNullOrWhiteSpace(txtContraseña.Text)
                || cbRol.SelectedIndex == -1
                || cbEstatus.SelectedIndex == -1
                || dgvSeleccionPersona.SelectedRows.Count == 0;
        }

        private int ObtenerIdPersonaSeleccionada()
        {
            if (dgvSeleccionPersona.SelectedRows.Count == 0)
                throw new InvalidOperationException("No hay persona seleccionada.");

            return (int)dgvSeleccionPersona.SelectedRows[0].Tag;
        }

        private int ObtenerIdUsuarioSeleccionado()
        {
            if (dgvSeleccionUsuario.SelectedRows.Count == 0)
                throw new InvalidOperationException("No hay usuario seleccionado.");

            return (int)dgvSeleccionUsuario.SelectedRows[0].Tag;
        }

        private void LimpiarCamposAlta()
        {
            txtNickname.Clear();
            txtContraseña.Clear();
            cbRol.SelectedIndex = -1;
            cbEstatus.SelectedValue = 1;
            dgvSeleccionPersona.ClearSelection();
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            if (DatosVacios())
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idPersona = ObtenerIdPersonaSeleccionada();

                var usuario = new Usuario
                {
                    Nickname = txtNickname.Text.Trim(),
                    Contraseña = txtContraseña.Text.Trim(),
                    IdRol = (int)cbRol.SelectedValue,
                    IdPersona = idPersona,
                    Estatus = (int)cbEstatus.SelectedValue
                };

                int nuevoId = _usuarioController.InsertarUsuario(usuario);

                MessageBox.Show($"Usuario guardado correctamente con ID {nuevoId}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarUsuariosEnGrid();
                LimpiarCamposAlta();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btGuardarCambios_Click(object sender, EventArgs e)
        {
            if (dgvSeleccionUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idUsuario = ObtenerIdUsuarioSeleccionado();
                var usuarioExistente = _usuarioController.ObtenerUsuarioPorId(idUsuario);

                if (usuarioExistente == null)
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                usuarioExistente.Nickname = txtCambioNickname.Text.Trim();
                usuarioExistente.Contraseña = txtCambioContraseña.Text.Trim();
                usuarioExistente.IdRol = (int)cbCambioRol.SelectedValue;
                usuarioExistente.Estatus = (int)cbCambioEstatus.SelectedValue;

                bool resultado = _usuarioController.ActualizarUsuario(usuarioExistente);

                if (resultado)
                {
                    MessageBox.Show("Usuario editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuariosEnGrid();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSeleccionUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("¿Está seguro que desea eliminar el usuario seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                int idUsuario = ObtenerIdUsuarioSeleccionado();

                bool resultado = _usuarioController.EliminarUsuario(idUsuario);

                if (resultado)
                {
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuariosEnGrid();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRegistroPersona_Click(object sender, EventArgs e)
        {
            var formPersona = new frmPersona();
            formPersona.ShowDialog();

            // Refrescar personas tras posible nueva
            CargarPersonasEnDataGridView();
        }
    }
}
