namespace Edifia_GUI
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            label1 = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            lblRegistros = new Label();
            dtgDatos = new DataGridView();
            DNI = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            labor = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            fecha_de_nacimiento = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            fechainicio = new DataGridViewTextBoxColumn();
            Fecha_Fin = new DataGridViewTextBoxColumn();
            txtFiltro = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(242, 242, 247);
            label1.Location = new Point(77, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(277, 19);
            label1.TabIndex = 22;
            label1.Text = "Busqueda empleado por apellido:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(10, 132, 255);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.FromArgb(242, 242, 247);
            btnAgregar.Location = new Point(493, 519);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(104, 33);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(10, 132, 255);
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.FromArgb(242, 242, 247);
            btnActualizar.Location = new Point(610, 519);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(104, 33);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(10, 132, 255);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(242, 242, 247);
            btnEliminar.Location = new Point(727, 519);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 33);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.FromArgb(242, 242, 247);
            btnCerrar.Location = new Point(905, 519);
            btnCerrar.Margin = new Padding(4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(111, 33);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BackColor = Color.FromArgb(44, 44, 46);
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.ForeColor = Color.White;
            lblRegistros.Location = new Point(915, 465);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(101, 27);
            lblRegistros.TabIndex = 27;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dtgDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dtgDatos.BackgroundColor = Color.FromArgb(34, 34, 36);
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { DNI, Nombre, Apellido, labor, Sexo, fecha_de_nacimiento, telefono, correo, Horario, Foto, fechainicio, Fecha_Fin });
            dtgDatos.Location = new Point(13, 79);
            dtgDatos.Margin = new Padding(4, 3, 4, 3);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.RowTemplate.Height = 100;
            dtgDatos.RowTemplate.Resizable = DataGridViewTriState.True;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1003, 361);
            dtgDatos.TabIndex = 28;
            // 
            // DNI
            // 
            DNI.DataPropertyName = "documento";
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            DNI.Width = 61;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 98;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // labor
            // 
            labor.DataPropertyName = "labor";
            labor.HeaderText = "Cargo";
            labor.MinimumWidth = 6;
            labor.Name = "labor";
            labor.ReadOnly = true;
            labor.Width = 83;
            // 
            // Sexo
            // 
            Sexo.DataPropertyName = "sexo";
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 6;
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            Sexo.Visible = false;
            Sexo.Width = 71;
            // 
            // fecha_de_nacimiento
            // 
            fecha_de_nacimiento.DataPropertyName = "Fecha de nacimiento";
            fecha_de_nacimiento.HeaderText = "Fecha de nacimiento";
            fecha_de_nacimiento.MinimumWidth = 6;
            fecha_de_nacimiento.Name = "fecha_de_nacimiento";
            fecha_de_nacimiento.ReadOnly = true;
            fecha_de_nacimiento.Width = 183;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 99;
            // 
            // correo
            // 
            correo.DataPropertyName = "correo";
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            correo.ReadOnly = true;
            correo.Width = 86;
            // 
            // Horario
            // 
            Horario.DataPropertyName = "horario";
            Horario.HeaderText = "Horario";
            Horario.MinimumWidth = 6;
            Horario.Name = "Horario";
            Horario.ReadOnly = true;
            Horario.Width = 90;
            // 
            // Foto
            // 
            Foto.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Foto.DataPropertyName = "foto";
            Foto.HeaderText = "Foto";
            Foto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Foto.MinimumWidth = 150;
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            Foto.Width = 150;
            // 
            // fechainicio
            // 
            fechainicio.DataPropertyName = "fecha_inicio";
            fechainicio.HeaderText = "Fecha de inicio";
            fechainicio.MinimumWidth = 6;
            fechainicio.Name = "fechainicio";
            fechainicio.ReadOnly = true;
            fechainicio.Width = 103;
            // 
            // Fecha_Fin
            // 
            Fecha_Fin.DataPropertyName = "Fecha de fin";
            Fecha_Fin.HeaderText = "Fecha de fin";
            Fecha_Fin.MinimumWidth = 6;
            Fecha_Fin.Name = "Fecha_Fin";
            Fecha_Fin.ReadOnly = true;
            Fecha_Fin.Width = 103;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(490, 15);
            txtFiltro.Margin = new Padding(4, 3, 4, 3);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(309, 27);
            txtFiltro.TabIndex = 0;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(827, 468);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 30;
            label2.Text = "Registros:";
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(1029, 570);
            Controls.Add(label2);
            Controls.Add(txtFiltro);
            Controls.Add(dtgDatos);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmpleado";
            Text = "Mantenimiento empleado";
            Load += frmEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label lblRegistros;
        private DataGridView dtgDatos;
        private TextBox txtFiltro;
        private Label label2;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn labor;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn fecha_de_nacimiento;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn Horario;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn fechainicio;
        private DataGridViewTextBoxColumn Fecha_Fin;
    }
}