namespace InvSis.Views
{
    partial class frmUsuarios
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            scUsuarios = new SplitContainer();
            gbAlta = new GroupBox();
            dgvSeleccionPersona = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Nacionalidad = new DataGridViewTextBoxColumn();
            btAlta = new Button();
            btRegistroPersona = new Button();
            lblPersona = new Label();
            lblDatosObligatorios = new Label();
            cbEstatus = new ComboBox();
            lblEstatus = new Label();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            cbRol = new ComboBox();
            lblRol = new Label();
            txtNickname = new TextBox();
            lblNickname = new Label();
            gbEdicionOEliminacion = new GroupBox();
            dgvSeleccionUsuario = new DataGridView();
            Rol = new DataGridViewTextBoxColumn();
            Nickname = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            Persona = new DataGridViewTextBoxColumn();
            btEliminar = new Button();
            btGuardarCambios = new Button();
            lblCambioPersona = new Label();
            cbCambioEstatus = new ComboBox();
            lblCambioEstatus = new Label();
            txtCambioContraseña = new TextBox();
            lblCambioContraseña = new Label();
            cbCambioRol = new ComboBox();
            lblCambioRol = new Label();
            txtCambioNickname = new TextBox();
            lblCambioNickname = new Label();
            lblSelección = new Label();
            toolTipPersona = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)scUsuarios).BeginInit();
            scUsuarios.Panel1.SuspendLayout();
            scUsuarios.Panel2.SuspendLayout();
            scUsuarios.SuspendLayout();
            gbAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeleccionPersona).BeginInit();
            gbEdicionOEliminacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeleccionUsuario).BeginInit();
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
            lblTitulo.Size = new Size(1505, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ADMINISTRACIÓN DE USUARIOS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scUsuarios
            // 
            scUsuarios.Dock = DockStyle.Fill;
            scUsuarios.Location = new Point(0, 33);
            scUsuarios.Margin = new Padding(3, 2, 3, 2);
            scUsuarios.Name = "scUsuarios";
            // 
            // scUsuarios.Panel1
            // 
            scUsuarios.Panel1.Controls.Add(gbAlta);
            // 
            // scUsuarios.Panel2
            // 
            scUsuarios.Panel2.Controls.Add(gbEdicionOEliminacion);
            scUsuarios.Size = new Size(1505, 698);
            scUsuarios.SplitterDistance = 723;
            scUsuarios.TabIndex = 1;
            // 
            // gbAlta
            // 
            gbAlta.BackColor = Color.FromArgb(230, 242, 248);
            gbAlta.Controls.Add(dgvSeleccionPersona);
            gbAlta.Controls.Add(btAlta);
            gbAlta.Controls.Add(btRegistroPersona);
            gbAlta.Controls.Add(lblPersona);
            gbAlta.Controls.Add(lblDatosObligatorios);
            gbAlta.Controls.Add(cbEstatus);
            gbAlta.Controls.Add(lblEstatus);
            gbAlta.Controls.Add(txtContraseña);
            gbAlta.Controls.Add(lblContraseña);
            gbAlta.Controls.Add(cbRol);
            gbAlta.Controls.Add(lblRol);
            gbAlta.Controls.Add(txtNickname);
            gbAlta.Controls.Add(lblNickname);
            gbAlta.Dock = DockStyle.Top;
            gbAlta.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbAlta.Location = new Point(0, 0);
            gbAlta.Margin = new Padding(3, 2, 3, 2);
            gbAlta.Name = "gbAlta";
            gbAlta.Padding = new Padding(3, 2, 3, 2);
            gbAlta.Size = new Size(723, 696);
            gbAlta.TabIndex = 0;
            gbAlta.TabStop = false;
            gbAlta.Text = "Alta de usuario";
            // 
            // dgvSeleccionPersona
            // 
            dgvSeleccionPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeleccionPersona.Columns.AddRange(new DataGridViewColumn[] { Nombre, Edad, Sexo, Nacionalidad });
            dgvSeleccionPersona.Location = new Point(12, 59);
            dgvSeleccionPersona.Name = "dgvSeleccionPersona";
            dgvSeleccionPersona.Size = new Size(705, 432);
            dgvSeleccionPersona.TabIndex = 27;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre completo";
            Nombre.MinimumWidth = 310;
            Nombre.Name = "Nombre";
            Nombre.Width = 310;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            // 
            // Nacionalidad
            // 
            Nacionalidad.HeaderText = "Nacionalidad";
            Nacionalidad.MinimumWidth = 150;
            Nacionalidad.Name = "Nacionalidad";
            Nacionalidad.Width = 150;
            // 
            // btAlta
            // 
            btAlta.AutoSize = true;
            btAlta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btAlta.Location = new Point(563, 650);
            btAlta.Margin = new Padding(3, 2, 3, 2);
            btAlta.Name = "btAlta";
            btAlta.Size = new Size(85, 30);
            btAlta.TabIndex = 13;
            btAlta.Text = "Guardar";
            btAlta.TextAlign = ContentAlignment.MiddleRight;
            btAlta.UseVisualStyleBackColor = true;
            btAlta.Click += btAlta_Click;
            // 
            // btRegistroPersona
            // 
            btRegistroPersona.AutoSize = true;
            btRegistroPersona.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btRegistroPersona.Location = new Point(556, 19);
            btRegistroPersona.Margin = new Padding(3, 2, 3, 2);
            btRegistroPersona.Name = "btRegistroPersona";
            btRegistroPersona.Size = new Size(161, 30);
            btRegistroPersona.TabIndex = 11;
            btRegistroPersona.Text = "Registrar persona";
            btRegistroPersona.UseVisualStyleBackColor = true;
            btRegistroPersona.Click += btRegistroPersona_Click;
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersona.Location = new Point(12, 30);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(133, 19);
            lblPersona.TabIndex = 9;
            lblPersona.Text = "Seleccionar persona ";
            // 
            // lblDatosObligatorios
            // 
            lblDatosObligatorios.AutoSize = true;
            lblDatosObligatorios.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatosObligatorios.Location = new Point(398, 656);
            lblDatosObligatorios.Name = "lblDatosObligatorios";
            lblDatosObligatorios.Size = new Size(131, 19);
            lblDatosObligatorios.TabIndex = 8;
            lblDatosObligatorios.Text = "* Datos obligatorios";
            // 
            // cbEstatus
            // 
            cbEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Location = new Point(386, 601);
            cbEstatus.Margin = new Padding(3, 2, 3, 2);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(262, 27);
            cbEstatus.TabIndex = 7;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstatus.Location = new Point(386, 581);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(63, 19);
            lblEstatus.TabIndex = 6;
            lblEstatus.Text = "Estatus *";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(386, 538);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.MaxLength = 20;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(262, 27);
            txtContraseña.TabIndex = 5;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.ForeColor = Color.MediumPurple;
            lblContraseña.Location = new Point(386, 518);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(89, 19);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña *";
            // 
            // cbRol
            // 
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(25, 601);
            cbRol.Margin = new Padding(3, 2, 3, 2);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(262, 27);
            cbRol.TabIndex = 3;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.MediumPurple;
            lblRol.Location = new Point(25, 581);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(38, 19);
            lblRol.TabIndex = 2;
            lblRol.Text = "Rol *";
            // 
            // txtNickname
            // 
            txtNickname.Location = new Point(25, 538);
            txtNickname.Margin = new Padding(3, 2, 3, 2);
            txtNickname.MaxLength = 20;
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(262, 27);
            txtNickname.TabIndex = 1;
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNickname.ForeColor = Color.MediumPurple;
            lblNickname.Location = new Point(25, 519);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(79, 19);
            lblNickname.TabIndex = 0;
            lblNickname.Text = "Nickname *";
            // 
            // gbEdicionOEliminacion
            // 
            gbEdicionOEliminacion.AutoSize = true;
            gbEdicionOEliminacion.BackColor = Color.FromArgb(230, 242, 248);
            gbEdicionOEliminacion.Controls.Add(dgvSeleccionUsuario);
            gbEdicionOEliminacion.Controls.Add(btEliminar);
            gbEdicionOEliminacion.Controls.Add(btGuardarCambios);
            gbEdicionOEliminacion.Controls.Add(lblCambioPersona);
            gbEdicionOEliminacion.Controls.Add(cbCambioEstatus);
            gbEdicionOEliminacion.Controls.Add(lblCambioEstatus);
            gbEdicionOEliminacion.Controls.Add(txtCambioContraseña);
            gbEdicionOEliminacion.Controls.Add(lblCambioContraseña);
            gbEdicionOEliminacion.Controls.Add(cbCambioRol);
            gbEdicionOEliminacion.Controls.Add(lblCambioRol);
            gbEdicionOEliminacion.Controls.Add(txtCambioNickname);
            gbEdicionOEliminacion.Controls.Add(lblCambioNickname);
            gbEdicionOEliminacion.Controls.Add(lblSelección);
            gbEdicionOEliminacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbEdicionOEliminacion.Location = new Point(3, 0);
            gbEdicionOEliminacion.Margin = new Padding(3, 2, 3, 2);
            gbEdicionOEliminacion.Name = "gbEdicionOEliminacion";
            gbEdicionOEliminacion.Padding = new Padding(3, 2, 3, 2);
            gbEdicionOEliminacion.Size = new Size(772, 698);
            gbEdicionOEliminacion.TabIndex = 0;
            gbEdicionOEliminacion.TabStop = false;
            gbEdicionOEliminacion.Text = "Edición o eliminación de usuario";
            // 
            // dgvSeleccionUsuario
            // 
            dgvSeleccionUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeleccionUsuario.Columns.AddRange(new DataGridViewColumn[] { Rol, Nickname, Contraseña, Estatus, Persona });
            dgvSeleccionUsuario.Location = new Point(6, 59);
            dgvSeleccionUsuario.Name = "dgvSeleccionUsuario";
            dgvSeleccionUsuario.Size = new Size(757, 397);
            dgvSeleccionUsuario.TabIndex = 25;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 150;
            Rol.Name = "Rol";
            Rol.Width = 150;
            // 
            // Nickname
            // 
            Nickname.HeaderText = "Nickname";
            Nickname.MinimumWidth = 150;
            Nickname.Name = "Nickname";
            Nickname.Width = 150;
            // 
            // Contraseña
            // 
            Contraseña.HeaderText = "Contraseña";
            Contraseña.Name = "Contraseña";
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            // 
            // Persona
            // 
            Persona.HeaderText = "Nombre de persona";
            Persona.MinimumWidth = 210;
            Persona.Name = "Persona";
            Persona.Width = 210;
            // 
            // btEliminar
            // 
            btEliminar.AutoSize = true;
            btEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEliminar.Location = new Point(613, 461);
            btEliminar.Margin = new Padding(3, 2, 3, 2);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(150, 30);
            btEliminar.TabIndex = 24;
            btEliminar.Text = "Eliminar usuario";
            btEliminar.TextAlign = ContentAlignment.MiddleRight;
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // btGuardarCambios
            // 
            btGuardarCambios.AutoSize = true;
            btGuardarCambios.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btGuardarCambios.Location = new Point(392, 640);
            btGuardarCambios.Margin = new Padding(3, 2, 3, 2);
            btGuardarCambios.Name = "btGuardarCambios";
            btGuardarCambios.Size = new Size(158, 30);
            btGuardarCambios.TabIndex = 23;
            btGuardarCambios.Text = "Guardar cambios";
            btGuardarCambios.TextAlign = ContentAlignment.MiddleRight;
            btGuardarCambios.UseVisualStyleBackColor = true;
            btGuardarCambios.Click += btGuardarCambios_Click;
            // 
            // lblCambioPersona
            // 
            lblCambioPersona.AutoSize = true;
            lblCambioPersona.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambioPersona.Location = new Point(392, 571);
            lblCambioPersona.Name = "lblCambioPersona";
            lblCambioPersona.Size = new Size(329, 57);
            lblCambioPersona.TabIndex = 14;
            lblCambioPersona.Text = "Cambio de persona no disponible mediante edición, \r\nelimine al usuario y vuelva a crearlo seleccionando\r\nla persona correcta";
            // 
            // cbCambioEstatus
            // 
            cbCambioEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCambioEstatus.FormattingEnabled = true;
            cbCambioEstatus.Location = new Point(392, 525);
            cbCambioEstatus.Margin = new Padding(3, 2, 3, 2);
            cbCambioEstatus.Name = "cbCambioEstatus";
            cbCambioEstatus.Size = new Size(262, 27);
            cbCambioEstatus.TabIndex = 22;
            // 
            // lblCambioEstatus
            // 
            lblCambioEstatus.AutoSize = true;
            lblCambioEstatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambioEstatus.Location = new Point(392, 505);
            lblCambioEstatus.Name = "lblCambioEstatus";
            lblCambioEstatus.Size = new Size(123, 19);
            lblCambioEstatus.TabIndex = 21;
            lblCambioEstatus.Text = "Cambio de estatus";
            // 
            // txtCambioContraseña
            // 
            txtCambioContraseña.Location = new Point(41, 648);
            txtCambioContraseña.Margin = new Padding(2, 1, 2, 1);
            txtCambioContraseña.MaxLength = 20;
            txtCambioContraseña.Name = "txtCambioContraseña";
            txtCambioContraseña.Size = new Size(262, 27);
            txtCambioContraseña.TabIndex = 20;
            // 
            // lblCambioContraseña
            // 
            lblCambioContraseña.AutoSize = true;
            lblCambioContraseña.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambioContraseña.Location = new Point(41, 629);
            lblCambioContraseña.Name = "lblCambioContraseña";
            lblCambioContraseña.Size = new Size(146, 19);
            lblCambioContraseña.TabIndex = 19;
            lblCambioContraseña.Text = "Cambio de contraseña";
            // 
            // cbCambioRol
            // 
            cbCambioRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCambioRol.FormattingEnabled = true;
            cbCambioRol.Location = new Point(41, 584);
            cbCambioRol.Margin = new Padding(3, 2, 3, 2);
            cbCambioRol.Name = "cbCambioRol";
            cbCambioRol.Size = new Size(262, 27);
            cbCambioRol.TabIndex = 18;
            // 
            // lblCambioRol
            // 
            lblCambioRol.AutoSize = true;
            lblCambioRol.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambioRol.Location = new Point(41, 564);
            lblCambioRol.Name = "lblCambioRol";
            lblCambioRol.Size = new Size(95, 19);
            lblCambioRol.TabIndex = 17;
            lblCambioRol.Text = "Cambio de rol";
            // 
            // txtCambioNickname
            // 
            txtCambioNickname.Location = new Point(41, 521);
            txtCambioNickname.Margin = new Padding(2, 1, 2, 1);
            txtCambioNickname.MaxLength = 20;
            txtCambioNickname.Name = "txtCambioNickname";
            txtCambioNickname.Size = new Size(262, 27);
            txtCambioNickname.TabIndex = 16;
            // 
            // lblCambioNickname
            // 
            lblCambioNickname.AutoSize = true;
            lblCambioNickname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambioNickname.Location = new Point(41, 502);
            lblCambioNickname.Name = "lblCambioNickname";
            lblCambioNickname.Size = new Size(137, 19);
            lblCambioNickname.TabIndex = 15;
            lblCambioNickname.Text = "Cambio de nickname";
            // 
            // lblSelección
            // 
            lblSelección.AutoSize = true;
            lblSelección.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelección.Location = new Point(18, 37);
            lblSelección.Name = "lblSelección";
            lblSelección.Size = new Size(142, 19);
            lblSelección.TabIndex = 14;
            lblSelección.Text = "Selección de usuario *";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 731);
            Controls.Add(scUsuarios);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.FromArgb(159, 122, 234);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            scUsuarios.Panel1.ResumeLayout(false);
            scUsuarios.Panel2.ResumeLayout(false);
            scUsuarios.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scUsuarios).EndInit();
            scUsuarios.ResumeLayout(false);
            gbAlta.ResumeLayout(false);
            gbAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeleccionPersona).EndInit();
            gbEdicionOEliminacion.ResumeLayout(false);
            gbEdicionOEliminacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeleccionUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private SplitContainer scUsuarios;
        private GroupBox gbAlta;
        private GroupBox gbEdicionOEliminacion;
        private Label lblNickname;
        private Label lblRol;
        private TextBox txtNickname;
        private ComboBox cbRol;
        private ComboBox cbEstatus;
        private Label lblEstatus;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private Label lblDatosObligatorios;
        private Button btRegistroPersona;
        private ComboBox cbPersonas;
        private Label lblPersona;
        private PictureBox pbPersona;
        private ToolTip toolTipPersona;
        private Button btAlta;
        private Label lblSelección;
        private ComboBox comboBox1;
        private ComboBox cbCambioEstatus;
        private Label lblCambioEstatus;
        private TextBox txtCambioContraseña;
        private Label lblCambioContraseña;
        private ComboBox cbCambioRol;
        private Label lblCambioRol;
        private TextBox txtCambioNickname;
        private Label lblCambioNickname;
        private Button btGuardarCambios;
        private Label lblCambioPersona;
        private Button btEliminar;
        private DataGridView dgvSeleccionPersona;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Nacionalidad;
        private DataGridView dgvSeleccionUsuario;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Nickname;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Estatus;
        private DataGridViewTextBoxColumn Persona;
    }
}