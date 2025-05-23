namespace InvSis.Views
{
    partial class frmVReportesAuditoria
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
        // En el archivo AuditoriasForm.Designer.cs (dentro del InitializeComponent)
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            gbFiltros = new GroupBox();
            btnExportar = new Button();
            btnGenerar = new Button();
            cmbMovimiento = new ComboBox();
            lblMovimiento = new Label();
            lblUsuario = new Label();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dgvAuditorias = new DataGridView();
            toolTip = new ToolTip(components);
            colIdMovimiento = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colTipoMovimiento = new DataGridViewTextBoxColumn();
            colTabla = new DataGridViewTextBoxColumn();
            colIdUsuario = new DataGridViewTextBoxColumn();
            colIpEquipo = new DataGridViewTextBoxColumn();
            colNombreEquipo = new DataGridViewTextBoxColumn();
            txtUsuario = new TextBox();
            pnlTitulo.SuspendLayout();
            gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditorias).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(159, 122, 234);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1307, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(159, 122, 234);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(0, 10, 0, 0);
            lblTitulo.Size = new Size(1307, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REPORTE DE AUDITORÍAS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbFiltros
            // 
            gbFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFiltros.BackColor = Color.FromArgb(230, 242, 248);
            gbFiltros.Controls.Add(txtUsuario);
            gbFiltros.Controls.Add(btnExportar);
            gbFiltros.Controls.Add(btnGenerar);
            gbFiltros.Controls.Add(cmbMovimiento);
            gbFiltros.Controls.Add(lblMovimiento);
            gbFiltros.Controls.Add(lblUsuario);
            gbFiltros.Controls.Add(dtpFechaFin);
            gbFiltros.Controls.Add(dtpFechaInicio);
            gbFiltros.Controls.Add(label2);
            gbFiltros.Controls.Add(label1);
            gbFiltros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            gbFiltros.ForeColor = Color.FromArgb(159, 122, 234);
            gbFiltros.Location = new Point(12, 77);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(1283, 157);
            gbFiltros.TabIndex = 1;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros de Auditoría";
            // 
            // btnExportar
            // 
            btnExportar.AutoSize = true;
            btnExportar.BackColor = Color.FromArgb(76, 175, 80);
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(922, 43);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(180, 35);
            btnExportar.TabIndex = 11;
            btnExportar.Text = "Exportar a Excel";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // btnGenerar
            // 
            btnGenerar.AutoSize = true;
            btnGenerar.BackColor = Color.FromArgb(159, 122, 234);
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(692, 43);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(180, 35);
            btnGenerar.TabIndex = 10;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = false;
            // 
            // cmbMovimiento
            // 
            cmbMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovimiento.FormattingEnabled = true;
            cmbMovimiento.Items.AddRange(new object[] { "Todos", "Creación", "Modificación", "Eliminación", "Login", "Acceso" });
            cmbMovimiento.Location = new Point(455, 43);
            cmbMovimiento.Name = "cmbMovimiento";
            cmbMovimiento.Size = new Size(150, 25);
            cmbMovimiento.TabIndex = 7;
            // 
            // lblMovimiento
            // 
            lblMovimiento.AutoSize = true;
            lblMovimiento.Location = new Point(362, 40);
            lblMovimiento.Name = "lblMovimiento";
            lblMovimiento.Size = new Size(87, 17);
            lblMovimiento.TabIndex = 6;
            lblMovimiento.Text = "Movimiento:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(362, 97);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 17);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "ID Usuario:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(171, 100);
            dtpFechaFin.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(120, 25);
            dtpFechaFin.TabIndex = 3;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(171, 43);
            dtpFechaInicio.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(120, 25);
            dtpFechaInicio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 100);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 1;
            label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 43);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 0;
            label1.Text = "Fecha Inicio:";
            // 
            // dgvAuditorias
            // 
            dgvAuditorias.AllowUserToAddRows = false;
            dgvAuditorias.AllowUserToDeleteRows = false;
            dgvAuditorias.AllowUserToResizeColumns = false;
            dgvAuditorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(250, 250, 250);
            dgvAuditorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvAuditorias.Anchor = AnchorStyles.None;
            dgvAuditorias.BackgroundColor = Color.FromArgb(42, 34, 58);
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(159, 122, 234);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvAuditorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvAuditorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditorias.Columns.AddRange(new DataGridViewColumn[] { colIdMovimiento, colFecha, colTipoMovimiento, colTabla, colIdUsuario, colIpEquipo, colNombreEquipo });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Window;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(232, 218, 255);
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dgvAuditorias.DefaultCellStyle = dataGridViewCellStyle16;
            dgvAuditorias.GridColor = SystemColors.Info;
            dgvAuditorias.ImeMode = ImeMode.Disable;
            dgvAuditorias.Location = new Point(69, 254);
            dgvAuditorias.Margin = new Padding(4, 5, 4, 5);
            dgvAuditorias.Name = "dgvAuditorias";
            dgvAuditorias.ReadOnly = true;
            dgvAuditorias.RowHeadersVisible = false;
            dgvAuditorias.RowHeadersWidth = 62;
            dgvAuditorias.Size = new Size(1147, 437);
            dgvAuditorias.TabIndex = 0;
            // 
            // colIdMovimiento
            // 
            colIdMovimiento.DataPropertyName = "id_Movimiento_Producto";
            colIdMovimiento.HeaderText = "ID MOVIMIENTO";
            colIdMovimiento.MinimumWidth = 8;
            colIdMovimiento.Name = "colIdMovimiento";
            colIdMovimiento.ReadOnly = true;
            colIdMovimiento.Width = 150;
            // 
            // colFecha
            // 
            colFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle11.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle11.ForeColor = Color.White;
            colFecha.DefaultCellStyle = dataGridViewCellStyle11;
            colFecha.HeaderText = "FECHA";
            colFecha.MinimumWidth = 8;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 150;
            // 
            // colTipoMovimiento
            // 
            colTipoMovimiento.DataPropertyName = "tipo_movimiento";
            dataGridViewCellStyle12.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle12.ForeColor = Color.White;
            colTipoMovimiento.DefaultCellStyle = dataGridViewCellStyle12;
            colTipoMovimiento.HeaderText = "TIPO DE MOVIMIENTO";
            colTipoMovimiento.MinimumWidth = 8;
            colTipoMovimiento.Name = "colTipoMovimiento";
            colTipoMovimiento.ReadOnly = true;
            colTipoMovimiento.Width = 180;
            // 
            // colTabla
            // 
            colTabla.HeaderText = "TABLA AFECTADA";
            colTabla.Name = "colTabla";
            colTabla.ReadOnly = true;
            colTabla.Width = 150;
            // 
            // colIdUsuario
            // 
            colIdUsuario.DataPropertyName = "id_Usuario";
            dataGridViewCellStyle13.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle13.ForeColor = Color.White;
            colIdUsuario.DefaultCellStyle = dataGridViewCellStyle13;
            colIdUsuario.HeaderText = "ID USUARIO";
            colIdUsuario.MinimumWidth = 8;
            colIdUsuario.Name = "colIdUsuario";
            colIdUsuario.ReadOnly = true;
            colIdUsuario.Width = 180;
            // 
            // colIpEquipo
            // 
            colIpEquipo.DataPropertyName = "ip_equipo";
            dataGridViewCellStyle14.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle14.ForeColor = Color.White;
            colIpEquipo.DefaultCellStyle = dataGridViewCellStyle14;
            colIpEquipo.HeaderText = "IP EQUIPO";
            colIpEquipo.MinimumWidth = 8;
            colIpEquipo.Name = "colIpEquipo";
            colIpEquipo.ReadOnly = true;
            colIpEquipo.Width = 150;
            // 
            // colNombreEquipo
            // 
            colNombreEquipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombreEquipo.DataPropertyName = "nombre_equipo";
            dataGridViewCellStyle15.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle15.ForeColor = Color.White;
            colNombreEquipo.DefaultCellStyle = dataGridViewCellStyle15;
            colNombreEquipo.HeaderText = "NOMBRE DE EQUIPO";
            colNombreEquipo.MinimumWidth = 8;
            colNombreEquipo.Name = "colNombreEquipo";
            colNombreEquipo.ReadOnly = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(455, 100);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 25);
            txtUsuario.TabIndex = 12;
            // 
            // frmVReportesAuditoria
            // 
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1307, 661);
            Controls.Add(dgvAuditorias);
            Controls.Add(gbFiltros);
            Controls.Add(pnlTitulo);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmVReportesAuditoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte de Auditorías";
            pnlTitulo.ResumeLayout(false);
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblMovimiento;
        private System.Windows.Forms.ComboBox cmbMovimiento;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnExportar;
        private DataGridView dgvAuditorias;
        private System.Windows.Forms.ToolTip toolTip;
        private DataGridViewTextBoxColumn colIdMovimiento;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colTipoMovimiento;
        private DataGridViewTextBoxColumn colTabla;
        private DataGridViewTextBoxColumn colIdUsuario;
        private DataGridViewTextBoxColumn colIpEquipo;
        private DataGridViewTextBoxColumn colNombreEquipo;
        private TextBox txtUsuario;
    }
}