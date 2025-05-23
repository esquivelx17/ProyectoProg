using InventariosCore.Data;
using InventariosCore.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InvSis.Views
{
    public partial class frmPersona : Form
    {
        private PersonasDataAccess _personasDA;
        private List<Persona> _personasCache;
        private Persona? _personaSeleccionada;

        public frmPersona()
        {
            InitializeComponent();
            _personasDA = new PersonasDataAccess();
            PoblaComboSexo(cbSexo);
            PoblaComboSexo(cbCambioSexo);

            CargarPersonas();

            // Asignar eventos para DataGridView
            dgvSeleccionPersona.SelectionChanged += DgvSeleccionPersona_SelectionChanged;

            // Asignar eventos para botones
            btGuardarCambios.Click += BtGuardarCambios_Click;
            btEliminar.Click += BtEliminar_Click;
        }

        private void PoblaComboSexo(ComboBox comboBox)
        {
            var list_estatus = new Dictionary<int, string>()
            {
                { 1, "Masculino"},
                { 0, "Femenino"},
            };
            comboBox.DataSource = new BindingSource(list_estatus, null);
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
        }

        private void CargarPersonas()
        {
            try
            {
                _personasCache = _personasDA.ObtenerTodasLasPersonas();
                dgvSeleccionPersona.Rows.Clear();

                foreach (var p in _personasCache)
                {
                    dgvSeleccionPersona.Rows.Add(
                        p.NombreCompleto,
                        p.Edad ?? 0,
                        p.Sexo,
                        p.Nacionalidad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando personas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvSeleccionPersona_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvSeleccionPersona.SelectedRows.Count == 0)
            {
                LimpiarCamposEdicion();
                _personaSeleccionada = null;
                return;
            }

            // Obtener índice de fila seleccionada
            int indice = dgvSeleccionPersona.SelectedRows[0].Index;
            if (indice < 0 || indice >= _personasCache.Count)
            {
                LimpiarCamposEdicion();
                _personaSeleccionada = null;
                return;
            }

            _personaSeleccionada = _personasCache[indice];
            CargarDatosEdicion(_personaSeleccionada);
        }

        private void CargarDatosEdicion(Persona persona)
        {
            txtCambioNombre.Text = persona.NombreCompleto;
            nudCambioEdad.Value = persona.Edad ?? nudCambioEdad.Minimum;
            cbCambioSexo.SelectedIndex = persona.Sexo == "Masculino" ? 0 : 1;
            txtCambioNacionalidad.Text = persona.Nacionalidad;
        }

        private void LimpiarCamposEdicion()
        {
            txtCambioNombre.Text = "";
            nudCambioEdad.Value = nudCambioEdad.Minimum;
            cbCambioSexo.SelectedIndex = -1;
            txtCambioNacionalidad.Text = "";
        }

        private bool ValidarCamposEdicion()
        {
            if (string.IsNullOrWhiteSpace(txtCambioNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCambioNacionalidad.Text) ||
                cbCambioSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos de edición.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void BtGuardarCambios_Click(object? sender, EventArgs e)
        {
            if (_personaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una persona para editar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidarCamposEdicion()) return;

            try
            {
                _personaSeleccionada.NombreCompleto = txtCambioNombre.Text.Trim();
                _personaSeleccionada.Edad = (int)nudCambioEdad.Value;
                _personaSeleccionada.Sexo = ((KeyValuePair<int, string>)cbCambioSexo.SelectedItem).Value;
                _personaSeleccionada.Nacionalidad = txtCambioNacionalidad.Text.Trim();

                bool exito = _personasDA.ActualizarPersona(_personaSeleccionada);
                if (exito)
                {
                    MessageBox.Show("Persona actualizada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPersonas();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la persona.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtEliminar_Click(object? sender, EventArgs e)
        {
            if (_personaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una persona para eliminar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var resultado = MessageBox.Show(
                $"¿Está seguro que desea eliminar a {_personaSeleccionada.NombreCompleto}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes)
                return;

            try
            {
                bool exito = _personasDA.EliminarPersona(_personaSeleccionada.IdPersona);
                if (exito)
                {
                    MessageBox.Show("Persona eliminada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposEdicion();
                    CargarPersonas();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la persona.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            if (DatosVaciosAlta())
            {
                MessageBox.Show("Por favor, llene todos los campos obligatorios para alta.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Persona nuevaPersona = new Persona
                {
                    NombreCompleto = txtNombre.Text.Trim(),
                    Edad = (int)nudEdad.Value,
                    Sexo = ((KeyValuePair<int, string>)cbSexo.SelectedItem).Value,
                    Nacionalidad = txtNacionalidad.Text.Trim()
                };

                int idGenerado = _personasDA.InsertarPersona(nuevaPersona);

                if (idGenerado > 0)
                {
                    MessageBox.Show("Persona agregada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposAlta();
                    CargarPersonas();
                }
                else
                {
                    MessageBox.Show("Error al agregar la persona.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DatosVaciosAlta()
        {
            return string.IsNullOrWhiteSpace(txtNombre.Text) ||
                   string.IsNullOrWhiteSpace(txtNacionalidad.Text) ||
                   cbSexo.SelectedIndex == -1;
        }

        private void LimpiarCamposAlta()
        {
            txtNombre.Clear();
            txtNacionalidad.Clear();
            nudEdad.Value = nudEdad.Minimum;
            cbSexo.SelectedIndex = -1;
        }

    }
}

