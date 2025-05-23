using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InventariosCore.Business;
using InventariosCore.Model;
using InventariosCore.Controllers;

namespace InvSis
{
    public partial class frmAdminProd : Form
    {
        private readonly ProductosController _controller = new ProductosController();
        private List<Producto> _productosCache = new List<Producto>();
        private Producto? _productoSeleccionado = null;
        private bool _modoEdicion = false;

        public frmAdminProd()
        {
            InitializeComponent();

            spcProductos.Panel2Collapsed = true;

            cmbxCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxUbi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxImpuesto.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUbi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstatus.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;
            dgvProductos.AutoGenerateColumns = false;

            // Suscribimos evento para selección fila
            dgvProductos.SelectionChanged += DgvProductos_SelectionChanged;

            // Configura columnas manualmente (asegúrate que coincidan con tus columnas en diseñador)
            ConfigurarColumnasDGV();

            CargarProductosEnGrid();
        }

        private void ConfigurarColumnasDGV()
        {
            dgvProductos.Columns.Clear();

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 140,
                Name = "colNombre"
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Categoria",
                HeaderText = "Categoría",
                Width = 140,
                Name = "colCategoria"
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Costo",
                HeaderText = "Costo unitario",
                Width = 90,
                Name = "colCosto",
                DefaultCellStyle = { Format = "C2" }
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Stock",
                HeaderText = "Stock",
                Width = 60,
                Name = "colStock"
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Ubicacion",
                HeaderText = "Ubicación",
                Width = 120,
                Name = "colUbicacion"
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Impuesto",
                Width = 100,
                Name = "colImpuesto"
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Clave",
                HeaderText = "Clave",
                Width = 120,
                Name = "colClave"
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Estatus",
                Width = 90,
                Name = "colEstatus"
            });
        }

        private void CargarProductosEnGrid(string? categoria = null, int? estatus = null, string? ubicacion = null)
        {
            var productos = _controller.ObtenerProductos(categoria, estatus);

            if (!string.IsNullOrEmpty(ubicacion) && ubicacion != "Todo")
                productos = productos.FindAll(p => p.Ubicacion == ubicacion);

            _productosCache = productos;

            // Asignar datasource
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;

            // Como el impuesto no está directamente ligado a DataPropertyName, lo rellenamos aquí:
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.DataBoundItem is Producto p)
                {
                    row.Cells["colImpuesto"].Value = p.Impuesto?.TipoImpuesto ?? "No Aplica";
                    row.Cells["colEstatus"].Value = p.Estatus == 1 ? "Activo" : "Inactivo";
                }
            }
        }

        private void DgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                _productoSeleccionado = null;
                return;
            }

            _productoSeleccionado = dgvProductos.CurrentRow.DataBoundItem as Producto;

            if (_productoSeleccionado != null)
            {
                CargarProductoEnFormulario(_productoSeleccionado);
                _modoEdicion = true;
                spcProductos.Panel2Collapsed = false;
                spcProductos.Panel1.Enabled = false;
                txtClave.ReadOnly = true;
            }
        }

        private void btnApF_Click_1(object sender, EventArgs e)
        {
            string categoria = cmbCat.SelectedItem?.ToString() ?? "Todo";
            int? estatus = null;
            if (cmbEstatus.SelectedItem != null)
                estatus = cmbEstatus.SelectedItem.ToString() == "Activo" ? 1 : 0;

            string ubicacion = cmbUbi.SelectedItem?.ToString() ?? "Todo";

            if (categoria == "Todo" && estatus == null && (ubicacion == "Todo" || string.IsNullOrEmpty(ubicacion)))
            {
                MessageBox.Show("Debe seleccionar al menos un criterio de filtrado.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarProductosEnGrid(categoria, estatus, ubicacion);
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            _modoEdicion = false;
            _productoSeleccionado = null;
            ReiniciarCampos();
            spcProductos.Panel2Collapsed = false;
            spcProductos.Panel1.Enabled = false;
            txtClave.ReadOnly = false;
        }

        private void CargarProductoEnFormulario(Producto p)
        {
            txtNombre.Text = p.Nombre;
            txtClave.Text = p.Clave;
            txtCosto.Text = p.Costo.ToString("F2");
            nmupdnStock.Value = p.Stock ?? 0;
            cmbxCat.SelectedItem = p.Categoria;
            cmbxUbi.SelectedItem = p.Ubicacion;
            cmbxStatus.SelectedItem = p.Estatus == 1 ? "Activo" : "Inactivo";
            cmbxImpuesto.SelectedItem = p.Impuesto?.TipoImpuesto ?? "No Aplica";
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ClaveProducto.ValidarCodigoProducto(txtClave.Text))
                {
                    MessageBox.Show("La clave no es válida.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El campo de nombre no puede estar vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCosto.Text) || !decimal.TryParse(txtCosto.Text.Replace("$", ""), out decimal costo))
                {
                    MessageBox.Show("El campo de costo no es válido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var prod = new Producto
                {
                    IdProducto = _productoSeleccionado?.IdProducto ?? 0,
                    Nombre = txtNombre.Text,
                    Clave = txtClave.Text,
                    Costo = costo,
                    Stock = (int)nmupdnStock.Value,
                    Categoria = cmbxCat.SelectedItem?.ToString() ?? "",
                    Ubicacion = cmbxUbi.SelectedItem?.ToString() ?? "",
                    Estatus = cmbxStatus.SelectedItem?.ToString() == "Activo" ? 1 : 0,
                    AplicaImpuesto = cmbxImpuesto.SelectedItem?.ToString() != "No Aplica",
                    IdImpuesto = null // Aquí tienes que asignar el IdImpuesto correcto según tu combo
                };

                if (_modoEdicion)
                {
                    bool actualizado = _controller.ActualizarProducto(prod);
                    if (actualizado)
                        MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nuevoId = _controller.InsertarProducto(prod);
                    MessageBox.Show($"Producto agregado con ID {nuevoId}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                spcProductos.Panel2Collapsed = true;
                spcProductos.Panel1.Enabled = true;
                ReiniciarCampos();
                CargarProductosEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            spcProductos.Panel2Collapsed = true;
            spcProductos.Panel1.Enabled = true;
            ReiniciarCampos();
        }

        private void ReiniciarCampos()
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            txtCosto.Text = "";
            nmupdnStock.Value = 0;
            cmbxCat.SelectedIndex = 0;
            cmbxUbi.SelectedIndex = 0;
            cmbxStatus.SelectedIndex = 0;
            cmbxImpuesto.SelectedIndex = 0;
            _productoSeleccionado = null;
            _modoEdicion = false;
        }
    }
}
