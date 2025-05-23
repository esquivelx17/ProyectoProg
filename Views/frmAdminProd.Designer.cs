namespace InvSis
{
    partial class frmAdminProd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            spcProductos = new SplitContainer();
            lblFilUbi = new Label();
            cmbUbi = new ComboBox();
            lblFilCat = new Label();
            lblFilStatus = new Label();
            cmbCat = new ComboBox();
            btnApF = new Button();
            cmbEstatus = new ComboBox();
            btnAgregar = new Button();
            btnEdittemp = new Button();
            btnCarga = new Button();
            dgvProductos = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colCosto = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colUbicacion = new DataGridViewTextBoxColumn();
            colImpuesto = new DataGridViewTextBoxColumn();
            colClave = new DataGridViewTextBoxColumn();
            colEstatus = new DataGridViewTextBoxColumn();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cmbxImpuesto = new ComboBox();
            cmbxStatus = new ComboBox();
            nmupdnStock = new NumericUpDown();
            txtCosto = new TextBox();
            txtClave = new TextBox();
            cmbxUbi = new ComboBox();
            cmbxCat = new ComboBox();
            txtNombre = new TextBox();
            lblImpuesto = new Label();
            lblEstatus = new Label();
            lblClave = new Label();
            lblUbicacion = new Label();
            lblStock = new Label();
            lblCosto = new Label();
            lblCat = new Label();
            lblNombre = new Label();
            label1 = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)spcProductos).BeginInit();
            spcProductos.Panel1.SuspendLayout();
            spcProductos.Panel2.SuspendLayout();
            spcProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmupdnStock).BeginInit();
            SuspendLayout();
            // 
            // spcProductos
            // 
            spcProductos.Location = new Point(0, 40);
            spcProductos.Name = "spcProductos";
            // 
            // spcProductos.Panel1
            // 
            spcProductos.Panel1.Controls.Add(lblFilUbi);
            spcProductos.Panel1.Controls.Add(cmbUbi);
            spcProductos.Panel1.Controls.Add(lblFilCat);
            spcProductos.Panel1.Controls.Add(lblFilStatus);
            spcProductos.Panel1.Controls.Add(cmbCat);
            spcProductos.Panel1.Controls.Add(btnApF);
            spcProductos.Panel1.Controls.Add(cmbEstatus);
            spcProductos.Panel1.Controls.Add(btnAgregar);
            spcProductos.Panel1.Controls.Add(btnEdittemp);
            spcProductos.Panel1.Controls.Add(btnCarga);
            spcProductos.Panel1.Controls.Add(dgvProductos);
            // 
            // spcProductos.Panel2
            // 
            spcProductos.Panel2.Controls.Add(btnCancelar);
            spcProductos.Panel2.Controls.Add(btnGuardar);
            spcProductos.Panel2.Controls.Add(cmbxImpuesto);
            spcProductos.Panel2.Controls.Add(cmbxStatus);
            spcProductos.Panel2.Controls.Add(nmupdnStock);
            spcProductos.Panel2.Controls.Add(txtCosto);
            spcProductos.Panel2.Controls.Add(txtClave);
            spcProductos.Panel2.Controls.Add(cmbxUbi);
            spcProductos.Panel2.Controls.Add(cmbxCat);
            spcProductos.Panel2.Controls.Add(txtNombre);
            spcProductos.Panel2.Controls.Add(lblImpuesto);
            spcProductos.Panel2.Controls.Add(lblEstatus);
            spcProductos.Panel2.Controls.Add(lblClave);
            spcProductos.Panel2.Controls.Add(lblUbicacion);
            spcProductos.Panel2.Controls.Add(lblStock);
            spcProductos.Panel2.Controls.Add(lblCosto);
            spcProductos.Panel2.Controls.Add(lblCat);
            spcProductos.Panel2.Controls.Add(lblNombre);
            spcProductos.Panel2.Controls.Add(label1);
            spcProductos.Size = new Size(1409, 744);
            spcProductos.SplitterDistance = 1010;
            spcProductos.TabIndex = 4;
            // 
            // lblFilUbi
            // 
            lblFilUbi.AutoSize = true;
            lblFilUbi.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFilUbi.ForeColor = Color.MediumPurple;
            lblFilUbi.Location = new Point(771, 23);
            lblFilUbi.Name = "lblFilUbi";
            lblFilUbi.Size = new Size(222, 30);
            lblFilUbi.TabIndex = 26;
            lblFilUbi.Text = "Filtrar por ubicación";
            // 
            // cmbUbi
            // 
            cmbUbi.BackColor = Color.Lavender;
            cmbUbi.ForeColor = Color.Black;
            cmbUbi.FormattingEnabled = true;
            cmbUbi.Items.AddRange(new object[] { "Todo", "Cat X", "Cat Y", "Cat Z" });
            cmbUbi.Location = new Point(771, 60);
            cmbUbi.Name = "cmbUbi";
            cmbUbi.Size = new Size(223, 23);
            cmbUbi.TabIndex = 25;
            // 
            // lblFilCat
            // 
            lblFilCat.AutoSize = true;
            lblFilCat.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFilCat.ForeColor = Color.MediumPurple;
            lblFilCat.Location = new Point(395, 23);
            lblFilCat.Name = "lblFilCat";
            lblFilCat.Size = new Size(221, 30);
            lblFilCat.TabIndex = 24;
            lblFilCat.Text = "Filtrar por categoría";
            // 
            // lblFilStatus
            // 
            lblFilStatus.AutoSize = true;
            lblFilStatus.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFilStatus.ForeColor = Color.MediumPurple;
            lblFilStatus.Location = new Point(21, 26);
            lblFilStatus.Name = "lblFilStatus";
            lblFilStatus.Size = new Size(198, 30);
            lblFilStatus.TabIndex = 23;
            lblFilStatus.Text = "Filtrar por estatus";
            // 
            // cmbCat
            // 
            cmbCat.BackColor = Color.Lavender;
            cmbCat.ForeColor = Color.Black;
            cmbCat.FormattingEnabled = true;
            cmbCat.Items.AddRange(new object[] { "Todo", "Cat X", "Cat Y", "Cat Z" });
            cmbCat.Location = new Point(395, 60);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(223, 23);
            cmbCat.TabIndex = 22;
            // 
            // btnApF
            // 
            btnApF.AutoSize = true;
            btnApF.BackColor = Color.MediumPurple;
            btnApF.FlatStyle = FlatStyle.Flat;
            btnApF.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnApF.ForeColor = Color.White;
            btnApF.Location = new Point(850, 142);
            btnApF.Name = "btnApF";
            btnApF.Size = new Size(144, 37);
            btnApF.TabIndex = 20;
            btnApF.Text = "Aplicar Filtro";
            btnApF.UseVisualStyleBackColor = false;
            btnApF.Click += btnApF_Click_1;
            // 
            // cmbEstatus
            // 
            cmbEstatus.BackColor = Color.Lavender;
            cmbEstatus.ForeColor = Color.Black;
            cmbEstatus.FormattingEnabled = true;
            cmbEstatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstatus.Location = new Point(21, 59);
            cmbEstatus.Name = "cmbEstatus";
            cmbEstatus.Size = new Size(197, 23);
            cmbEstatus.TabIndex = 19;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.BackColor = Color.MediumPurple;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(21, 533);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(228, 48);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar Productos";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnEdittemp
            // 
            btnEdittemp.AutoSize = true;
            btnEdittemp.BackColor = Color.FromArgb(159, 122, 234);
            btnEdittemp.Cursor = Cursors.Hand;
            btnEdittemp.FlatAppearance.BorderSize = 0;
            btnEdittemp.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 80, 140);
            btnEdittemp.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 95, 160);
            btnEdittemp.FlatStyle = FlatStyle.Flat;
            btnEdittemp.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            btnEdittemp.ForeColor = Color.Black;
            btnEdittemp.Location = new Point(395, 533);
            btnEdittemp.Name = "btnEdittemp";
            btnEdittemp.Size = new Size(78, 36);
            btnEdittemp.TabIndex = 16;
            btnEdittemp.Text = "Editar";
            btnEdittemp.UseVisualStyleBackColor = false;
            //btnEdittemp.Click += btnEdittemp_Click_1;
            // 
            // btnCarga
            // 
            btnCarga.AutoSize = true;
            btnCarga.BackColor = Color.FromArgb(159, 122, 234);
            btnCarga.FlatAppearance.BorderSize = 0;
            btnCarga.FlatStyle = FlatStyle.Flat;
            btnCarga.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            btnCarga.ForeColor = Color.Black;
            btnCarga.Location = new Point(840, 540);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(153, 36);
            btnCarga.TabIndex = 17;
            btnCarga.Text = "Carga Excel";
            btnCarga.UseVisualStyleBackColor = false;
            //btnCarga.Click += btnCarga_Clic
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = Color.FromArgb(250, 250, 250);
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            dgvProductos.Anchor = AnchorStyles.None;
            dgvProductos.BackgroundColor = Color.FromArgb(42, 34, 58);
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(159, 122, 234);
            dataGridViewCellStyle26.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = Color.MediumPurple;
            dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colNombre, colCategoria, colCosto, colStock, colUbicacion, colImpuesto, colClave, colEstatus });
            dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = SystemColors.Window;
            dataGridViewCellStyle32.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle32.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = Color.FromArgb(232, 218, 255);
            dataGridViewCellStyle32.SelectionForeColor = Color.MediumPurple;
            dataGridViewCellStyle32.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle32;
            dgvProductos.GridColor = SystemColors.Info;
            dgvProductos.ImeMode = ImeMode.Disable;
            dgvProductos.Location = new Point(21, 211);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(973, 262);
            dgvProductos.TabIndex = 15;
            // 
            // colNombre
            // 
            dataGridViewCellStyle27.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle27.ForeColor = Color.White;
            colNombre.DefaultCellStyle = dataGridViewCellStyle27;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 140;
            // 
            // colCategoria
            // 
            dataGridViewCellStyle28.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle28.ForeColor = Color.White;
            colCategoria.DefaultCellStyle = dataGridViewCellStyle28;
            colCategoria.HeaderText = "Categoria";
            colCategoria.MinimumWidth = 8;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            colCategoria.Width = 140;
            // 
            // colCosto
            // 
            colCosto.HeaderText = "Costo unitario";
            colCosto.Name = "colCosto";
            colCosto.ReadOnly = true;
            // 
            // colStock
            // 
            dataGridViewCellStyle29.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle29.ForeColor = Color.White;
            colStock.DefaultCellStyle = dataGridViewCellStyle29;
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 8;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colUbicacion
            // 
            colUbicacion.HeaderText = "Ubicación";
            colUbicacion.Name = "colUbicacion";
            colUbicacion.ReadOnly = true;
            colUbicacion.Width = 140;
            // 
            // colImpuesto
            // 
            colImpuesto.HeaderText = "Impuesto";
            colImpuesto.Name = "colImpuesto";
            colImpuesto.ReadOnly = true;
            // 
            // colClave
            // 
            dataGridViewCellStyle30.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle30.ForeColor = Color.White;
            colClave.DefaultCellStyle = dataGridViewCellStyle30;
            colClave.HeaderText = "Clave";
            colClave.MinimumWidth = 8;
            colClave.Name = "colClave";
            colClave.ReadOnly = true;
            colClave.Width = 120;
            // 
            // colEstatus
            // 
            dataGridViewCellStyle31.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle31.ForeColor = Color.White;
            colEstatus.DefaultCellStyle = dataGridViewCellStyle31;
            colEstatus.HeaderText = "Estatus";
            colEstatus.MinimumWidth = 8;
            colEstatus.Name = "colEstatus";
            colEstatus.ReadOnly = true;
            colEstatus.Width = 130;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(245, 245, 245);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(159, 122, 234);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(159, 122, 234);
            btnCancelar.Location = new Point(208, 694);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 53;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(159, 122, 234);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(58, 694);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 52;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // cmbxImpuesto
            // 
            cmbxImpuesto.BackColor = Color.White;
            cmbxImpuesto.FlatStyle = FlatStyle.Flat;
            cmbxImpuesto.ForeColor = Color.FromArgb(42, 34, 58);
            cmbxImpuesto.FormattingEnabled = true;
            cmbxImpuesto.Items.AddRange(new object[] { "No Aplica", "Impuesto A", "Impuesto B", "Impuesto C" });
            cmbxImpuesto.Location = new Point(58, 613);
            cmbxImpuesto.Name = "cmbxImpuesto";
            cmbxImpuesto.Size = new Size(253, 23);
            cmbxImpuesto.TabIndex = 51;
            // 
            // cmbxStatus
            // 
            cmbxStatus.BackColor = Color.White;
            cmbxStatus.FlatStyle = FlatStyle.Flat;
            cmbxStatus.ForeColor = Color.FromArgb(42, 34, 58);
            cmbxStatus.FormattingEnabled = true;
            cmbxStatus.Items.AddRange(new object[] { "Inactivo", "Activo" });
            cmbxStatus.Location = new Point(58, 537);
            cmbxStatus.Name = "cmbxStatus";
            cmbxStatus.Size = new Size(253, 23);
            cmbxStatus.TabIndex = 50;
            // 
            // nmupdnStock
            // 
            nmupdnStock.BackColor = Color.White;
            nmupdnStock.BorderStyle = BorderStyle.FixedSingle;
            nmupdnStock.Font = new Font("MS PGothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmupdnStock.ForeColor = Color.FromArgb(42, 34, 58);
            nmupdnStock.Location = new Point(58, 304);
            nmupdnStock.Name = "nmupdnStock";
            nmupdnStock.Size = new Size(120, 22);
            nmupdnStock.TabIndex = 49;
            // 
            // txtCosto
            // 
            txtCosto.BackColor = Color.FromArgb(245, 245, 245);
            txtCosto.BorderStyle = BorderStyle.FixedSingle;
            txtCosto.ForeColor = Color.FromArgb(159, 122, 234);
            txtCosto.Location = new Point(58, 233);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(253, 23);
            txtCosto.TabIndex = 48;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.White;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.ForeColor = Color.FromArgb(42, 34, 58);
            txtClave.Location = new Point(58, 461);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(253, 23);
            txtClave.TabIndex = 47;
            // 
            // cmbxUbi
            // 
            cmbxUbi.BackColor = Color.FromArgb(245, 245, 245);
            cmbxUbi.FlatStyle = FlatStyle.Flat;
            cmbxUbi.Font = new Font("Segoe UI", 10F);
            cmbxUbi.ForeColor = Color.FromArgb(159, 122, 234);
            cmbxUbi.FormattingEnabled = true;
            cmbxUbi.Items.AddRange(new object[] { "Tijuana", "CDMX", "Toluca", "Durango", "SLP", "Cancún" });
            cmbxUbi.Location = new Point(58, 385);
            cmbxUbi.Name = "cmbxUbi";
            cmbxUbi.Size = new Size(253, 25);
            cmbxUbi.TabIndex = 46;
            // 
            // cmbxCat
            // 
            cmbxCat.BackColor = Color.FromArgb(245, 245, 245);
            cmbxCat.FlatStyle = FlatStyle.Flat;
            cmbxCat.Font = new Font("Segoe UI", 10F);
            cmbxCat.ForeColor = Color.FromArgb(159, 122, 234);
            cmbxCat.FormattingEnabled = true;
            cmbxCat.Items.AddRange(new object[] { "Cat X", "Cat Y", "Cat Z" });
            cmbxCat.Location = new Point(58, 154);
            cmbxCat.Name = "cmbxCat";
            cmbxCat.Size = new Size(253, 25);
            cmbxCat.Sorted = true;
            cmbxCat.TabIndex = 45;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(245, 245, 245);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = Color.FromArgb(159, 122, 234);
            txtNombre.Location = new Point(58, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 25);
            txtNombre.TabIndex = 44;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblImpuesto.ForeColor = Color.FromArgb(159, 122, 234);
            lblImpuesto.Location = new Point(58, 589);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(86, 21);
            lblImpuesto.TabIndex = 43;
            lblImpuesto.Text = "Impuesto:";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEstatus.ForeColor = Color.FromArgb(159, 122, 234);
            lblEstatus.Location = new Point(58, 513);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(68, 21);
            lblEstatus.TabIndex = 42;
            lblEstatus.Text = "Estatus:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblClave.ForeColor = Color.FromArgb(159, 122, 234);
            lblClave.Location = new Point(58, 437);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(56, 21);
            lblClave.TabIndex = 41;
            lblClave.Text = "Clave:";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblUbicacion.ForeColor = Color.FromArgb(159, 122, 234);
            lblUbicacion.Location = new Point(58, 363);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(101, 19);
            lblUbicacion.TabIndex = 40;
            lblUbicacion.Text = "Ubicacion:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblStock.ForeColor = Color.FromArgb(159, 122, 234);
            lblStock.Location = new Point(58, 282);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(66, 19);
            lblStock.TabIndex = 39;
            lblStock.Text = "Stock:";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblCosto.ForeColor = Color.FromArgb(159, 122, 234);
            lblCosto.Location = new Point(58, 211);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(144, 19);
            lblCosto.TabIndex = 38;
            lblCosto.Text = "Costo unitario:";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblCat.ForeColor = Color.FromArgb(159, 122, 234);
            lblCat.Location = new Point(58, 132);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(108, 19);
            lblCat.TabIndex = 37;
            lblCat.Text = "Categoria: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(159, 122, 234);
            lblNombre.Location = new Point(58, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 19);
            lblNombre.TabIndex = 36;
            lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(189, 30);
            label1.TabIndex = 15;
            label1.Text = "Alta de producto";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(159, 122, 234);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1409, 42);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = " ADMINISTRACIÓN DE PRODUCTOS ";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // Estatus (igual que cmbxStatus)
            cmbEstatus.Items.Clear();
            cmbEstatus.Items.AddRange(new object[] { "Inactivo", "Activo" });
            cmbEstatus.SelectedIndex = -1; // Sin selección

            // Categoria (igual que cmbxCat)
            cmbCat.Items.Clear();
            cmbCat.Items.AddRange(new object[] { "Cat X", "Cat Y", "Cat Z" });
            cmbCat.Sorted = true;
            cmbCat.SelectedIndex = -1;

            // Ubicación (igual que cmbxUbi)
            cmbUbi.Items.Clear();
            cmbUbi.Items.AddRange(new object[] { "Tijuana", "CDMX", "Toluca", "Durango", "SLP", "Cancún" });
            cmbUbi.SelectedIndex = -1;

            // 
            // frmAdminProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 242, 248);
            ClientSize = new Size(1409, 813);
            Controls.Add(lblTitulo);
            Controls.Add(spcProductos);
            Name = "frmAdminProd";
            Text = "Administración de Inventarios";
            spcProductos.Panel1.ResumeLayout(false);
            spcProductos.Panel1.PerformLayout();
            spcProductos.Panel2.ResumeLayout(false);
            spcProductos.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spcProductos).EndInit();
            spcProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmupdnStock).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer spcProductos;
        private Label lblTitulo;
        private Label label1;
        private Label lblFilCat;
        private Label lblFilStatus;
        private ComboBox cmbCat;
        private Button btnApF;
        private ComboBox cmbEstatus;
        private Button btnAgregar;
        private Button btnEdittemp;
        private Button btnCarga;
        private DataGridView dgvProductos;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cmbxImpuesto;
        private ComboBox cmbxStatus;
        private NumericUpDown nmupdnStock;
        private TextBox txtCosto;
        private TextBox txtClave;
        private ComboBox cmbxUbi;
        private ComboBox cmbxCat;
        private TextBox txtNombre;
        private Label lblImpuesto;
        private Label lblEstatus;
        private Label lblClave;
        private Label lblUbicacion;
        private Label lblStock;
        private Label lblCosto;
        private Label lblCat;
        private Label lblNombre;
        private Label lblFilUbi;
        private ComboBox cmbUbi;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colCosto;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colUbicacion;
        private DataGridViewTextBoxColumn colImpuesto;
        private DataGridViewTextBoxColumn colClave;
        private DataGridViewTextBoxColumn colEstatus;
    }
}
