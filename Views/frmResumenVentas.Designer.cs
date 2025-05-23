namespace InvSis.Views
{
    partial class frmResumenVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            dgvProductos = new DataGridView();
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            btnBuscar = new Button();
            lblClave = new Label();
            txtBusID = new TextBox();
            colClave = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colEstatus = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colCosto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(250, 250, 250);
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvProductos.Anchor = AnchorStyles.None;
            dgvProductos.BackgroundColor = Color.FromArgb(42, 34, 58);
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(159, 122, 234);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.MediumPurple;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colClave, colNombre, colFecha, colStock, colEstatus, colCantidad, colCosto });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(159, 122, 234);
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(232, 218, 255);
            dataGridViewCellStyle14.SelectionForeColor = Color.MediumPurple;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle14;
            dgvProductos.GridColor = SystemColors.Info;
            dgvProductos.ImeMode = ImeMode.Disable;
            dgvProductos.Location = new Point(12, 112);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(915, 399);
            dgvProductos.TabIndex = 24;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(159, 122, 234);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Margin = new Padding(2);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(944, 36);
            pnlTitulo.TabIndex = 18;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(159, 122, 234);
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(0, 6, 0, 0);
            lblTitulo.Size = new Size(944, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "RESUMEN DE VENTAS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.MediumPurple;
            btnBuscar.Location = new Point(210, 68);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(66, 23);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClave.ForeColor = Color.MediumPurple;
            lblClave.Location = new Point(12, 50);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(177, 15);
            lblClave.TabIndex = 21;
            lblClave.Text = "Filtrado por clave de producto:";
            // 
            // txtBusID
            // 
            txtBusID.Location = new Point(12, 68);
            txtBusID.Name = "txtBusID";
            txtBusID.Size = new Size(177, 23);
            txtBusID.TabIndex = 20;
            // 
            // colClave
            // 
            dataGridViewCellStyle10.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle10.ForeColor = Color.White;
            colClave.DefaultCellStyle = dataGridViewCellStyle10;
            colClave.HeaderText = "Clave";
            colClave.MinimumWidth = 8;
            colClave.Name = "colClave";
            colClave.ReadOnly = true;
            colClave.Width = 120;
            // 
            // colNombre
            // 
            dataGridViewCellStyle11.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle11.ForeColor = Color.White;
            colNombre.DefaultCellStyle = dataGridViewCellStyle11;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 140;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha de la venta";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 150;
            // 
            // colStock
            // 
            dataGridViewCellStyle12.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle12.ForeColor = Color.White;
            colStock.DefaultCellStyle = dataGridViewCellStyle12;
            colStock.HeaderText = "Cliente";
            colStock.MinimumWidth = 8;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.Width = 150;
            // 
            // colEstatus
            // 
            dataGridViewCellStyle13.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle13.ForeColor = Color.White;
            colEstatus.DefaultCellStyle = dataGridViewCellStyle13;
            colEstatus.HeaderText = "Estatus";
            colEstatus.MinimumWidth = 8;
            colEstatus.Name = "colEstatus";
            colEstatus.ReadOnly = true;
            colEstatus.Width = 130;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad vendida";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colCosto
            // 
            colCosto.HeaderText = "Costo";
            colCosto.Name = "colCosto";
            colCosto.ReadOnly = true;
            colCosto.Width = 120;
            // 
            // frmResumenVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 532);
            Controls.Add(dgvProductos);
            Controls.Add(pnlTitulo);
            Controls.Add(btnBuscar);
            Controls.Add(lblClave);
            Controls.Add(txtBusID);
            Name = "frmResumenVentas";
            Text = "frmResumenVentas";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            pnlTitulo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvProductos;
        private Panel pnlTitulo;
        private Label lblTitulo;
        private Button btnBuscar;
        private Label lblClave;
        private TextBox txtBusID;
        private DataGridViewTextBoxColumn colClave;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colEstatus;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colCosto;
    }
}