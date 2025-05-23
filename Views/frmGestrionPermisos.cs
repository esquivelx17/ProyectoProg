using InventariosCore.Controllers;
using InventariosCore.Model;
using System;
using System.Windows.Forms;

namespace InvSis.Views
{
    public partial class frmGestrionPermisos : Form
    {
        private PermisosController _controller;
        private Permiso? permisoSeleccionado = null;

        public frmGestrionPermisos()
        {
            InitializeComponent();
            _controller = new PermisosController();
            ActualizarListadoPermisos();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombrePermiso.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                ShowMessage("Por favor, ingresa el nombre del permiso.");
                return;
            }

            if (string.IsNullOrEmpty(descripcion))
            {
                ShowMessage("Por favor, ingresa la descripción del permiso.");
                return;
            }

            if (permisoSeleccionado != null && permisoSeleccionado.IdPermiso > 0)
            {
                // Si cambió el nombre, verificar que no exista otro permiso con ese nombre distinto
                if (permisoSeleccionado.Nombre != nombre)
                {
                    var permisoConMismoNombre = _controller.GetPermisoByNombre(nombre);
                    if (permisoConMismoNombre != null && permisoConMismoNombre.IdPermiso != permisoSeleccionado.IdPermiso)
                    {
                        ShowMessage("Ya existe un permiso con ese nombre.");
                        return;
                    }
                }

                // Actualizar datos del permiso seleccionado
                permisoSeleccionado.Nombre = nombre;
                permisoSeleccionado.Descripcion = descripcion;

                // Si estaba inactivo, activarlo
                if (permisoSeleccionado.Estatus == 2)
                    permisoSeleccionado.Estatus = 1;

                bool actualizado = _controller.ActualizarPermiso(permisoSeleccionado);

                if (actualizado)
                {
                    ShowMessage("Permiso actualizado correctamente.");
                    ActualizarListadoPermisos();
                    LimpiarCampos();
                    btnAgregar.Text = "Agregar";
                    permisoSeleccionado = null;
                }
                else
                {
                    ShowMessage("Error al actualizar el permiso.");
                }

                return;
            }
            else
            {
                // No hay permiso seleccionado: agregar uno nuevo

                // Verificar que no exista un permiso con ese nombre
                var permisoExistente = _controller.GetPermisoByNombre(nombre);
                if (permisoExistente != null)
                {
                    // Cargar datos para editar
                    permisoSeleccionado = permisoExistente;
                    txtNombrePermiso.Text = permisoExistente.Nombre;
                    txtDescripcion.Text = permisoExistente.Descripcion;
                    btnAgregar.Text = "Editar";
                    ShowMessage("El permiso ya existe. Puedes editarlo.");
                    return;
                }

                var nuevoPermiso = new Permiso
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Estatus = 1
                };

                if (_controller.AgregarPermiso(nuevoPermiso))
                {
                    ShowMessage("Permiso agregado correctamente.");
                    ActualizarListadoPermisos();
                    LimpiarCampos();
                    btnAgregar.Text = "Agregar";
                    permisoSeleccionado = null;
                }
                else
                {
                    ShowMessage("Error al agregar el permiso.");
                }
            }
        }


        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                ShowMessage("Selecciona un permiso en la lista para inhabilitar.");
                return;
            }

            string nombre = dataGridView1.CurrentRow.Cells["NombrePermiso"].Value?.ToString();

            if (string.IsNullOrEmpty(nombre))
            {
                ShowMessage("No se pudo obtener el nombre del permiso seleccionado.");
                return;
            }

            bool resultado = _controller.InhabilitarPermisoPorNombre(nombre);

            if (resultado)
            {
                ShowMessage("Permiso inhabilitado correctamente.");
                ActualizarListadoPermisos();
                LimpiarCampos();
                btnAgregar.Text = "Agregar";
                permisoSeleccionado = null;
            }
            else
            {
                ShowMessage("Error al inhabilitar el permiso.");
            }
        }

        public void ActualizarListadoPermisos()
        {
            var listaPermisos = _controller.ObtenerPermisos(soloActivos: false);
            permisosControllerBindingSource.DataSource = listaPermisos;
            dataGridView1.Refresh();
        }


        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            permisoSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Permiso;

            if (permisoSeleccionado != null)
            {
                txtNombrePermiso.Text = permisoSeleccionado.Nombre;
                txtDescripcion.Text = permisoSeleccionado.Descripcion;
                btnAgregar.Text = "Editar";
            }
            else
            {
                LimpiarCampos();
            }
        }


        private void LimpiarCampos()
        {
            txtNombrePermiso.Text = "";
            txtDescripcion.Text = "";
            permisoSeleccionado = null;
            btnAgregar.Text = "Agregar";
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
