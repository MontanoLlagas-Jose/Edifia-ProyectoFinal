namespace Edifia_GUI
{
    partial class DepartamentoMan01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartamentoMan01));
            label1 = new Label();
            txtFiltro = new TextBox();
            dtgDatos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            numero = new DataGridViewTextBoxColumn();
            piso = new DataGridViewTextBoxColumn();
            estado_habitado = new DataGridViewTextBoxColumn();
            Edificio = new DataGridViewTextBoxColumn();
            Plano = new DataGridViewImageColumn();
            label2 = new Label();
            btnAgregar = new Button();
            btnACtualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            lblRegistros = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(15, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingrese departamento:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(209, 27);
            txtFiltro.Margin = new Padding(4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(175, 27);
            txtFiltro.TabIndex = 0;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgDatos.BackgroundColor = Color.FromArgb(34, 34, 36);
            dtgDatos.BorderStyle = BorderStyle.None;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { id, numero, piso, estado_habitado, Edificio, Plano });
            dtgDatos.Location = new Point(15, 85);
            dtgDatos.Margin = new Padding(4);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(998, 375);
            dtgDatos.TabIndex = 0;
            dtgDatos.DoubleClick += dtgDepartamentoFoto_DoubleClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // numero
            // 
            numero.DataPropertyName = "numero";
            numero.HeaderText = "Numero";
            numero.Name = "numero";
            numero.ReadOnly = true;
            // 
            // piso
            // 
            piso.DataPropertyName = "piso";
            piso.HeaderText = "Piso";
            piso.Name = "piso";
            piso.ReadOnly = true;
            // 
            // estado_habitado
            // 
            estado_habitado.DataPropertyName = "estado_habitado";
            estado_habitado.HeaderText = "Estado";
            estado_habitado.Name = "estado_habitado";
            estado_habitado.ReadOnly = true;
            // 
            // Edificio
            // 
            Edificio.DataPropertyName = "edificio_nombre";
            Edificio.HeaderText = "Edificio";
            Edificio.Name = "Edificio";
            Edificio.ReadOnly = true;
            // 
            // Plano
            // 
            Plano.DataPropertyName = "plano";
            Plano.HeaderText = "Plano";
            Plano.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Plano.Name = "Plano";
            Plano.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(831, 479);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 0;
            label2.Text = "Registros:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(10, 132, 255);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(526, 519);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 35);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnACtualizar
            // 
            btnACtualizar.BackColor = Color.FromArgb(10, 132, 255);
            btnACtualizar.FlatStyle = FlatStyle.Popup;
            btnACtualizar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnACtualizar.ForeColor = SystemColors.Control;
            btnACtualizar.Location = new Point(639, 519);
            btnACtualizar.Margin = new Padding(4);
            btnACtualizar.Name = "btnACtualizar";
            btnACtualizar.Size = new Size(103, 35);
            btnACtualizar.TabIndex = 2;
            btnACtualizar.Text = "Actualizar";
            btnACtualizar.UseVisualStyleBackColor = false;
            btnACtualizar.Click += btnACtualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(10, 132, 255);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(751, 519);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(103, 35);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnCerrar.ForeColor = SystemColors.Control;
            btnCerrar.Location = new Point(910, 519);
            btnCerrar.Margin = new Padding(4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(103, 35);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblRegistros.ForeColor = SystemColors.Control;
            lblRegistros.Location = new Point(917, 478);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(96, 25);
            lblRegistros.TabIndex = 0;
            // 
            // DepartamentoMan01
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(1029, 570);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnACtualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dtgDatos);
            Controls.Add(txtFiltro);
            Controls.Add(label2);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DepartamentoMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Departamentos";
            Load += DepartamentoMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltro;
        private DataGridView dtgDatos;
        private Label label2;
        private Button btnAgregar;
        private Button btnACtualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn piso;
        private DataGridViewTextBoxColumn estado_habitado;
        private DataGridViewTextBoxColumn Edificio;
        private DataGridViewImageColumn Plano;
    }
}