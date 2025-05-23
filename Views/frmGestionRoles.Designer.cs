
namespace InvSis.Views
{
    partial class frmGestionRoles
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
            lblTitulo = new Label();
            btnAgregarRol = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvRoles = new DataGridView();
            NombrePermiso = new DataGridViewTextBoxColumn();
            EstatusPermiso = new DataGridViewTextBoxColumn();
            lblSelección = new Label();
            dgvPermisosAsignados = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Descripcion_Permiso = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dtvPermisosDiaponibles = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPermisosAsignados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvPermisosDiaponibles).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(159, 122, 234);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1347, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE ROLES";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgregarRol
            // 
            btnAgregarRol.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarRol.Location = new Point(300, 672);
            btnAgregarRol.Margin = new Padding(3, 2, 3, 2);
            btnAgregarRol.Name = "btnAgregarRol";
            btnAgregarRol.Size = new Size(102, 27);
            btnAgregarRol.TabIndex = 5;
            btnAgregarRol.Text = "Agregar rol";
            btnAgregarRol.UseVisualStyleBackColor = true;
            // 
            // dgvRoles
            // 
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Columns.AddRange(new DataGridViewColumn[] { NombrePermiso, EstatusPermiso });
            dgvRoles.Location = new Point(48, 102);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.Size = new Size(354, 565);
            dgvRoles.TabIndex = 19;
            // 
            // NombrePermiso
            // 
            NombrePermiso.DataPropertyName = "NombreRol";
            NombrePermiso.HeaderText = "Nombre";
            NombrePermiso.MinimumWidth = 150;
            NombrePermiso.Name = "NombrePermiso";
            NombrePermiso.Resizable = DataGridViewTriState.False;
            NombrePermiso.Width = 150;
            // 
            // EstatusPermiso
            // 
            EstatusPermiso.DataPropertyName = "Estatus";
            EstatusPermiso.HeaderText = "Estatus";
            EstatusPermiso.MinimumWidth = 150;
            EstatusPermiso.Name = "EstatusPermiso";
            EstatusPermiso.Width = 150;
            // 
            // lblSelección
            // 
            lblSelección.AutoSize = true;
            lblSelección.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelección.Location = new Point(48, 80);
            lblSelección.Name = "lblSelección";
            lblSelección.Size = new Size(268, 19);
            lblSelección.TabIndex = 21;
            lblSelección.Text = "Seleccione rol para asignación de permisos";
            // 
            // dgvPermisosAsignados
            // 
            dgvPermisosAsignados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermisosAsignados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Descripcion_Permiso, dataGridViewTextBoxColumn2 });
            dgvPermisosAsignados.Location = new Point(464, 419);
            dgvPermisosAsignados.Name = "dgvPermisosAsignados";
            dgvPermisosAsignados.RowHeadersWidth = 51;
            dgvPermisosAsignados.Size = new Size(829, 248);
            dgvPermisosAsignados.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 250;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn1.Width = 250;
            // 
            // Descripcion_Permiso
            // 
            Descripcion_Permiso.DataPropertyName = "Descripcion";
            Descripcion_Permiso.HeaderText = "Descripcion";
            Descripcion_Permiso.MinimumWidth = 400;
            Descripcion_Permiso.Name = "Descripcion_Permiso";
            Descripcion_Permiso.Resizable = DataGridViewTriState.False;
            Descripcion_Permiso.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Estatus";
            dataGridViewTextBoxColumn2.HeaderText = "Estatus";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dtvPermisosDiaponibles
            // 
            dtvPermisosDiaponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvPermisosDiaponibles.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dtvPermisosDiaponibles.Location = new Point(464, 102);
            dtvPermisosDiaponibles.Name = "dtvPermisosDiaponibles";
            dtvPermisosDiaponibles.RowHeadersWidth = 51;
            dtvPermisosDiaponibles.Size = new Size(829, 248);
            dtvPermisosDiaponibles.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            dataGridViewTextBoxColumn3.MinimumWidth = 250;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            dataGridViewTextBoxColumn4.MinimumWidth = 400;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn4.Width = 400;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Estatus";
            dataGridViewTextBoxColumn5.HeaderText = "Estatus";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(464, 397);
            label1.Name = "label1";
            label1.Size = new Size(223, 19);
            label1.TabIndex = 24;
            label1.Text = "Eliminar permisos asignados del rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(464, 80);
            label2.Name = "label2";
            label2.Size = new Size(151, 19);
            label2.TabIndex = 25;
            label2.Text = "Agregar permisos al rol";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1218, 356);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1218, 672);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmGestionRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 242, 248);
            ClientSize = new Size(1347, 722);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtvPermisosDiaponibles);
            Controls.Add(dgvPermisosAsignados);
            Controls.Add(lblSelección);
            Controls.Add(dgvRoles);
            Controls.Add(lblTitulo);
            Controls.Add(btnAgregarRol);
            ForeColor = SystemColors.Desktop;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGestionRoles";
            Text = "frmGestionRoles";
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPermisosAsignados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvPermisosDiaponibles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblNombreEliminacionRol_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Label lblTitulo;
        private Button btnAgregarRol;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvRoles;
        private DataGridViewTextBoxColumn NombrePermiso;
        private DataGridViewTextBoxColumn EstatusPermiso;
        private Label lblSelección;
        private DataGridView dgvPermisosAsignados;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Descripcion_Permiso;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView dtvPermisosDiaponibles;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label1;
        private Label label2;
        private Button btnAgregar;
        private Button btnEliminar;
    }
}