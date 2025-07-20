namespace Edifia_GUI
{
    partial class MantenimientoMan01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoMan01));
            btnCerrar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            dtgDatos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            actividad_id = new DataGridViewTextBoxColumn();
            fecha_programada = new DataGridViewTextBoxColumn();
            fecha_realizacion = new DataGridViewTextBoxColumn();
            responsable = new DataGridViewTextBoxColumn();
            TIpoEmpleado = new DataGridViewTextBoxColumn();
            txtFiltro = new TextBox();
            label2 = new Label();
            lblRegistros = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.ForeColor = SystemColors.Control;
            btnCerrar.Location = new Point(910, 514);
            btnCerrar.Margin = new Padding(4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(103, 35);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(10, 132, 255);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(750, 514);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(103, 35);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(10, 132, 255);
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.ForeColor = SystemColors.Control;
            btnActualizar.Location = new Point(631, 514);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(103, 35);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(10, 132, 255);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(513, 514);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 35);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgDatos.BackgroundColor = Color.FromArgb(44, 44, 46);
            dtgDatos.BorderStyle = BorderStyle.None;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { id, actividad_id, fecha_programada, fecha_realizacion, responsable, TIpoEmpleado });
            dtgDatos.Location = new Point(15, 80);
            dtgDatos.Margin = new Padding(4);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(998, 375);
            dtgDatos.TabIndex = 4;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Codigo";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // actividad_id
            // 
            actividad_id.DataPropertyName = "actividad_id";
            actividad_id.HeaderText = "D.Actividad";
            actividad_id.Name = "actividad_id";
            actividad_id.ReadOnly = true;
            // 
            // fecha_programada
            // 
            fecha_programada.DataPropertyName = "fecha_programada";
            fecha_programada.HeaderText = "F.Programada";
            fecha_programada.Name = "fecha_programada";
            fecha_programada.ReadOnly = true;
            // 
            // fecha_realizacion
            // 
            fecha_realizacion.DataPropertyName = "fecha_realizacion";
            fecha_realizacion.HeaderText = "F.Realizacion";
            fecha_realizacion.Name = "fecha_realizacion";
            fecha_realizacion.ReadOnly = true;
            // 
            // responsable
            // 
            responsable.DataPropertyName = "responsable";
            responsable.HeaderText = "E.Responsable";
            responsable.Name = "responsable";
            responsable.ReadOnly = true;
            // 
            // TIpoEmpleado
            // 
            TIpoEmpleado.DataPropertyName = "TipoEmpleado";
            TIpoEmpleado.HeaderText = "T.Empleado";
            TIpoEmpleado.Name = "TIpoEmpleado";
            TIpoEmpleado.ReadOnly = true;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(273, 22);
            txtFiltro.Margin = new Padding(4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(175, 27);
            txtFiltro.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(831, 474);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 5;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.ForeColor = SystemColors.Control;
            lblRegistros.Location = new Point(917, 472);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(96, 25);
            lblRegistros.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(15, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 19);
            label1.TabIndex = 7;
            label1.Text = "Ingrese codigo Mantenimiento:";
            // 
            // MantenimientoMan01
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 36);
            ClientSize = new Size(1029, 570);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dtgDatos);
            Controls.Add(txtFiltro);
            Controls.Add(label2);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MantenimientoMan01";
            Text = "Mantenimiento de Mantenimiento";
            Load += MantenimientoMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridView dtgDatos;
        private TextBox txtFiltro;
        private Label label2;
        private Label lblRegistros;
        private Label label1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn actividad_id;
        private DataGridViewTextBoxColumn fecha_programada;
        private DataGridViewTextBoxColumn fecha_realizacion;
        private DataGridViewTextBoxColumn responsable;
        private DataGridViewTextBoxColumn TIpoEmpleado;
    }
}