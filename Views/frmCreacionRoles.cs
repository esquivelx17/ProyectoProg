using InventariosCore.Controllers;
using InventariosCore.Model;
using System;
using System.Windows.Forms;

namespace InvSis.Views
{
    public partial class frmCreacionRoles : Form
    {
        private RolesController _controller;
        private Rol? rolSeleccionado = null;

        public frmCreacionRoles()
        {
            InitializeComponent();
            _controller = new RolesController();
            ActualizarListadoRoles();

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

            // Opcional: formatea la columna de Estatus para mostrar texto legible
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void ActualizarListadoRoles()
        {
            var listaRoles = _controller.ObtenerRoles(soloActivos: false);
            dataGridView1.DataSource = listaRoles;
            dataGridView1.Refresh();
        }

        private void LimpiarCampos()
        {
            txtNombrePermiso.Text = "";
            rolSeleccionado = null;
            btnAgregar.Text = "Agregar";
        }

        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            rolSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Rol;

            if (rolSeleccionado != null)
            {
                txtNombrePermiso.Text = rolSeleccionado.NombreRol;
                btnAgregar.Text = "Editar";
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombrePermiso.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingresa el nombre del rol.");
                return;
            }

            if (rolSeleccionado != null && rolSeleccionado.IdRol > 0)
            {
                // Si cambió el nombre, verificar que no exista otro rol con ese nombre distinto
                if (!rolSeleccionado.NombreRol.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    var rolConMismoNombre = _controller.GetRolPorNombre(nombre);
                    if (rolConMismoNombre != null && rolConMismoNombre.IdRol != rolSeleccionado.IdRol)
                    {
                        MessageBox.Show("Ya existe un rol con ese nombre.");
                        return;
                    }
                }

                // Actualizar rol seleccionado
                rolSeleccionado.NombreRol = nombre;

                // Si estaba inactivo, activarlo
                if (rolSeleccionado.Estatus == 2)
                    rolSeleccionado.Estatus = 1;

                if (_controller.ActualizarRol(rolSeleccionado))
                {
                    MessageBox.Show("Rol actualizado correctamente.");
                    ActualizarListadoRoles();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el rol.");
                }

                return;
            }
            else
            {
                // Nuevo rol: verificar que no exista el nombre
                var rolExistente = _controller.GetRolPorNombre(nombre);
                if (rolExistente != null)
                {
                    rolSeleccionado = rolExistente;
                    txtNombrePermiso.Text = rolExistente.NombreRol;
                    btnAgregar.Text = "Editar";
                    MessageBox.Show("El rol ya existe. Puedes editarlo.");
                    return;
                }

                // Crear nuevo rol
                var nuevoRol = new Rol
                {
                    NombreRol = nombre,
                    Estatus = 1
                };

                if (_controller.AgregarRol(nuevoRol))
                {
                    MessageBox.Show("Rol agregado correctamente.");
                    ActualizarListadoRoles();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el rol.");
                }
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un rol en la lista para inhabilitar.");
                return;
            }

            var rol = dataGridView1.CurrentRow.DataBoundItem as Rol;
            if (rol == null)
            {
                MessageBox.Show("No se pudo obtener el rol seleccionado.");
                return;
            }

            if (_controller.InhabilitarRolPorId(rol.IdRol))
            {
                MessageBox.Show("Rol inhabilitado correctamente.");
                ActualizarListadoRoles();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al inhabilitar el rol.");
            }
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "EstatusPermiso" && e.Value != null)
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
    }
}

