namespace InvSis.Views
{
    partial class frmRepAPI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblConsulta = new Label();
            txtBusID = new TextBox();
            lblClave = new Label();
            btnActualizar = new Button();
            btnBuscar = new Button();
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            dgvProductos = new DataGridView();
            btnResumen = new Button();
            colClave = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCosto = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colImpuesto = new DataGridViewTextBoxColumn();
            colEstatus = new DataGridViewTextBoxColumn();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Location = new Point(12, 38);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(206, 15);
            lblConsulta.TabIndex = 2;
            lblConsulta.Text = "Consultar existencia de un producto";
            // 
            // txtBusID
            // 
            txtBusID.Location = new Point(29, 92);
            txtBusID.Name = "txtBusID";
            txtBusID.Size = new Size(165, 23);
            txtBusID.TabIndex = 3;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(29, 74);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(111, 15);
            lblClave.TabIndex = 4;
            lblClave.Text = "Clave de producto:";
            // 
            // btnActualizar
            // 
            btnActualizar.AutoSize = true;
            btnActualizar.Location = new Point(586, 92);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(136, 25);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar existencias";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(226, 92);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(66, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(159, 122, 234);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Margin = new Padding(2);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(752, 36);
            pnlTitulo.TabIndex = 0;
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
            lblTitulo.Size = new Size(752, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "API";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.Anchor = AnchorStyles.None;
            dgvProductos.BackgroundColor = Color.FromArgb(42, 34, 58);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(159, 122, 234);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colClave, colNombre, colCosto, colStock, colImpuesto, colEstatus });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(159, 122, 234);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(232, 218, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.MediumPurple;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle7;
            dgvProductos.GridColor = SystemColors.Info;
            dgvProductos.ImeMode = ImeMode.Disable;
            dgvProductos.Location = new Point(29, 141);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(693, 399);
            dgvProductos.TabIndex = 16;
            // 
            // btnResumen
            // 
            btnResumen.AutoSize = true;
            btnResumen.Location = new Point(596, 61);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(126, 25);
            btnResumen.TabIndex = 17;
            btnResumen.Text = "Resumen de ventas";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // colClave
            // 
            colClave.DataPropertyName = "Clave";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle3.ForeColor = Color.White;
            colClave.DefaultCellStyle = dataGridViewCellStyle3;
            colClave.HeaderText = "Clave";
            colClave.MinimumWidth = 8;
            colClave.Name = "colClave";
            colClave.ReadOnly = true;
            colClave.Width = 120;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle4.ForeColor = Color.White;
            colNombre.DefaultCellStyle = dataGridViewCellStyle4;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 140;
            // 
            // colCosto
            // 
            colCosto.DataPropertyName = "CostoUnitario";
            colCosto.HeaderText = "Costo unitario";
            colCosto.Name = "colCosto";
            colCosto.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            dataGridViewCellStyle5.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle5.ForeColor = Color.White;
            colStock.DefaultCellStyle = dataGridViewCellStyle5;
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 8;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colImpuesto
            // 
            colImpuesto.DataPropertyName = "Impuesto";
            colImpuesto.HeaderText = "Impuesto";
            colImpuesto.Name = "colImpuesto";
            colImpuesto.ReadOnly = true;
            // 
            // colEstatus
            // 
            colEstatus.DataPropertyName = "EstatusTexto";
            dataGridViewCellStyle6.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle6.ForeColor = Color.White;
            colEstatus.DefaultCellStyle = dataGridViewCellStyle6;
            colEstatus.HeaderText = "Estatus";
            colEstatus.MinimumWidth = 8;
            colEstatus.Name = "colEstatus";
            colEstatus.ReadOnly = true;
            colEstatus.Width = 130;
            // 
            // frmRepAPI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 242, 248);
            ClientSize = new Size(752, 564);
            Controls.Add(btnResumen);
            Controls.Add(dgvProductos);
            Controls.Add(pnlTitulo);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(lblClave);
            Controls.Add(txtBusID);
            Controls.Add(lblConsulta);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.FromArgb(159, 122, 234);
            Name = "frmRepAPI";
            Text = "frmRepAPI";
            pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblConsulta;
        private TextBox txtBusID;
        private Label lblClave;
        private Button btnActualizar;
        private Button btnBuscar;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private DataGridView dgvProductos;
        private Button btnResumen;
        private DataGridViewTextBoxColumn colClave;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCosto;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colImpuesto;
        private DataGridViewTextBoxColumn colEstatus;
    }
}