using InventariosCore.Business;
using InventariosCore.Controllers;
using System;
using System.Windows.Forms;

namespace InvSis.Views
{
    public partial class frmRepAPI : Form
    {
        private readonly ProductosController _productosController;

        public frmRepAPI()
        {
            InitializeComponent();
            _productosController = new ProductosController();

            // Desactivar auto generación de columnas para usar las del diseñador
            dgvProductos.AutoGenerateColumns = false;

            // Carga inicial
            CargarProductos();
        }

        private void CargarProductos(string? claveFiltro = null)
        {
            var productos = _productosController.ObtenerProductosParaAPI(claveFiltro);

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string clave = txtBusID.Text.Trim();

            if (string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Ingrese una clave para filtrar los productos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBusID.Focus();
                return;
            }

            try
            {
                CargarProductos(clave);

                if (dgvProductos.Rows.Count == 0)
                {
                    MessageBox.Show($"No se encontró ningún producto con clave '{clave}'.",
                        "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar productos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarProductos();
                txtBusID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad pendiente: Resumen de ventas.",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
