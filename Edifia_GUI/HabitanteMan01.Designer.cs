namespace Edifia_GUI
{
    partial class HabitanteMan01
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HabitanteMan01));
            label2 = new Label();
            txtFiltro = new TextBox();
            dtgDatos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            Edificio = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fecha_Ing = new DataGridViewTextBoxColumn();
            FechaEgreso = new DataGridViewTextBoxColumn();
            Fec_reg = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            lblRegistros = new Label();
            label1 = new Label();
            btnCerrar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(941, 370);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 39;
            label2.Text = "Registros:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(231, 31);
            txtFiltro.Margin = new Padding(4, 2, 4, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(444, 23);
            txtFiltro.TabIndex = 31;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgDatos.BackgroundColor = Color.FromArgb(34, 34, 36);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Apellido, DNI, Departamento, Edificio, Estado, Fecha_Ing, FechaEgreso, Fec_reg, Foto });
            dtgDatos.Location = new Point(28, 71);
            dtgDatos.Margin = new Padding(4, 2, 4, 2);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1104, 271);
            dtgDatos.TabIndex = 38;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.DataPropertyName = "id";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 130;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Nombre.DataPropertyName = "nombre";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Nombre.DefaultCellStyle = dataGridViewCellStyle2;
            Nombre.FillWeight = 534.7593F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 90;
            // 
            // Apellido
            // 
            Apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Apellido.DataPropertyName = "apellido";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Apellido.DefaultCellStyle = dataGridViewCellStyle3;
            Apellido.FillWeight = 310.991425F;
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 91;
            // 
            // DNI
            // 
            DNI.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DNI.DataPropertyName = "documento";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DNI.DefaultCellStyle = dataGridViewCellStyle4;
            DNI.FillWeight = 103.111229F;
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            DNI.Width = 59;
            // 
            // Departamento
            // 
            Departamento.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Departamento.DataPropertyName = "numero";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Departamento.DefaultCellStyle = dataGridViewCellStyle5;
            Departamento.FillWeight = 34.1883774F;
            Departamento.HeaderText = "Departamento";
            Departamento.MinimumWidth = 6;
            Departamento.Name = "Departamento";
            Departamento.ReadOnly = true;
            Departamento.Width = 131;
            // 
            // Edificio
            // 
            Edificio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edificio.DataPropertyName = "edificio";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Edificio.DefaultCellStyle = dataGridViewCellStyle6;
            Edificio.FillWeight = 11.336957F;
            Edificio.HeaderText = "Edificio";
            Edificio.MinimumWidth = 6;
            Edificio.Name = "Edificio";
            Edificio.ReadOnly = true;
            Edificio.Width = 83;
            // 
            // Estado
            // 
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Estado.DataPropertyName = "estado";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Estado.DefaultCellStyle = dataGridViewCellStyle7;
            Estado.FillWeight = 3.76054764F;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 78;
            // 
            // Fecha_Ing
            // 
            Fecha_Ing.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Fecha_Ing.DataPropertyName = "fecha_ingreso";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Fecha_Ing.DefaultCellStyle = dataGridViewCellStyle8;
            Fecha_Ing.FillWeight = 1.2485832F;
            Fecha_Ing.HeaderText = "Fecha Ingreso";
            Fecha_Ing.MinimumWidth = 100;
            Fecha_Ing.Name = "Fecha_Ing";
            Fecha_Ing.ReadOnly = true;
            Fecha_Ing.Width = 115;
            // 
            // FechaEgreso
            // 
            FechaEgreso.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FechaEgreso.DataPropertyName = "fecha_egreso";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            FechaEgreso.DefaultCellStyle = dataGridViewCellStyle9;
            FechaEgreso.FillWeight = 0.4157391F;
            FechaEgreso.HeaderText = "Fecha Egreso";
            FechaEgreso.MinimumWidth = 6;
            FechaEgreso.Name = "FechaEgreso";
            FechaEgreso.ReadOnly = true;
            FechaEgreso.Width = 111;
            // 
            // Fec_reg
            // 
            Fec_reg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Fec_reg.DataPropertyName = "Fec_reg";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Fec_reg.DefaultCellStyle = dataGridViewCellStyle10;
            Fec_reg.FillWeight = 0.139609009F;
            Fec_reg.HeaderText = "F. Registro";
            Fec_reg.MinimumWidth = 6;
            Fec_reg.Name = "Fec_reg";
            Fec_reg.ReadOnly = true;
            Fec_reg.Width = 96;
            // 
            // Foto
            // 
            Foto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Foto.DataPropertyName = "foto";
            Foto.FillWeight = 0.048057884F;
            Foto.HeaderText = "Foto";
            Foto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Foto.MinimumWidth = 6;
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            Foto.Resizable = DataGridViewTriState.True;
            Foto.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // lblRegistros
            // 
            lblRegistros.BackColor = Color.FromArgb(44, 44, 46);
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.ForeColor = Color.White;
            lblRegistros.Location = new Point(1027, 364);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(105, 27);
            lblRegistros.TabIndex = 37;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(242, 242, 247);
            label1.Location = new Point(52, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 19);
            label1.TabIndex = 36;
            label1.Text = "Busqueda Habitante:";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.FromArgb(242, 242, 247);
            btnCerrar.Location = new Point(1027, 411);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(105, 28);
            btnCerrar.TabIndex = 35;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(10, 132, 255);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(242, 242, 247);
            btnEliminar.Location = new Point(849, 411);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 28);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(10, 132, 255);
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.FromArgb(242, 242, 247);
            btnActualizar.Location = new Point(736, 411);
            btnActualizar.Margin = new Padding(4, 3, 4, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(105, 28);
            btnActualizar.TabIndex = 33;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(10, 132, 255);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.FromArgb(242, 242, 247);
            btnAgregar.Location = new Point(623, 411);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 28);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // HabitanteMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(1164, 474);
            Controls.Add(label2);
            Controls.Add(txtFiltro);
            Controls.Add(dtgDatos);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HabitanteMan01";
            Text = "Mantenimiento Habitante";
            Load += HabitanteMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtFiltro;
        private DataGridView dtgDatos;
        private Label lblRegistros;
        private Label label1;
        private Button btnCerrar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Edificio;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fecha_Ing;
        private DataGridViewTextBoxColumn FechaEgreso;
        private DataGridViewTextBoxColumn Fec_reg;
        private DataGridViewImageColumn Foto;
    }
}