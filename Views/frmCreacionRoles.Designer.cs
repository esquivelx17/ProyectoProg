namespace InvSis.Views
{
    partial class frmCreacionRoles
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
            dataGridView1 = new DataGridView();
            btnInhabilitar = new Button();
            btnAgregar = new Button();
            lblTitulo = new Label();
            lbAgregarEditarPermiso = new Label();
            lblNombreRol = new Label();
            txtNombrePermiso = new TextBox();
            NombrePermiso = new DataGridViewTextBoxColumn();
            EstatusPermiso = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombrePermiso, EstatusPermiso });
            dataGridView1.Location = new Point(39, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(855, 596);
            dataGridView1.TabIndex = 18;

            // 
            // btnInhabilitar
            // 
            btnInhabilitar.AutoSize = true;
            btnInhabilitar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInhabilitar.Location = new Point(1071, 337);
            btnInhabilitar.Margin = new Padding(3, 2, 3, 2);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(110, 38);
            btnInhabilitar.TabIndex = 17;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = true;
            btnInhabilitar.Click += btnInhabilitar_Click;

            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(1296, 337);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 38);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;

            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(159, 122, 234);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1490, 41);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "CREACION Y ELIMINACION DE ROLES";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lbAgregarEditarPermiso
            // 
            lbAgregarEditarPermiso.AutoSize = true;
            lbAgregarEditarPermiso.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgregarEditarPermiso.Location = new Point(1054, 223);
            lbAgregarEditarPermiso.Name = "lbAgregarEditarPermiso";
            lbAgregarEditarPermiso.Size = new Size(205, 30);
            lbAgregarEditarPermiso.TabIndex = 13;
            lbAgregarEditarPermiso.Text = "Agregar o editar rol";

            // 
            // lblNombreRol
            // 
            lblNombreRol.AutoSize = true;
            lblNombreRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreRol.Location = new Point(924, 284);
            lblNombreRol.Name = "lblNombreRol";
            lblNombreRol.Size = new Size(116, 21);
            lblNombreRol.TabIndex = 14;
            lblNombreRol.Text = "Nombre del rol";

            // 
            // txtNombrePermiso
            // 
            txtNombrePermiso.Location = new Point(1071, 284);
            txtNombrePermiso.Margin = new Padding(3, 2, 3, 2);
            txtNombrePermiso.Name = "txtNombrePermiso";
            txtNombrePermiso.Size = new Size(319, 23);
            txtNombrePermiso.TabIndex = 15;

            // 
            // NombrePermiso
            // 
            NombrePermiso.DataPropertyName = "NombreRol"; // Aquí la propiedad correcta
            NombrePermiso.HeaderText = "Nombre";
            NombrePermiso.MinimumWidth = 400;
            NombrePermiso.Name = "NombrePermiso";
            NombrePermiso.Resizable = DataGridViewTriState.False;
            NombrePermiso.Width = 400;

            // 
            // EstatusPermiso
            // 
            EstatusPermiso.DataPropertyName = "Estatus";
            EstatusPermiso.HeaderText = "Estatus";
            EstatusPermiso.MinimumWidth = 400;
            EstatusPermiso.Name = "EstatusPermiso";
            EstatusPermiso.Width = 400;

            // 
            // frmCreacionRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 714);
            Controls.Add(dataGridView1);
            Controls.Add(btnInhabilitar);
            Controls.Add(btnAgregar);
            Controls.Add(lblTitulo);
            Controls.Add(lbAgregarEditarPermiso);
            Controls.Add(lblNombreRol);
            Controls.Add(txtNombrePermiso);
            Name = "frmCreacionRoles";
            Text = "frmCreacionRoles";

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private DataGridView dataGridView1;
        private Button btnInhabilitar;
        private Button btnAgregar;
        private Label lblTitulo;
        private Label lbAgregarEditarPermiso;
        private Label lblNombreRol;
        private TextBox txtNombrePermiso;
        private DataGridViewTextBoxColumn NombrePermiso;
        private DataGridViewTextBoxColumn EstatusPermiso;
    }
}