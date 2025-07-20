namespace Edifia_GUI
{
    partial class VisitaMan01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitaMan01));
            dtgDatos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            visitante = new DataGridViewTextBoxColumn();
            documento = new DataGridViewTextBoxColumn();
            departamento = new DataGridViewTextBoxColumn();
            Edificio = new DataGridViewTextBoxColumn();
            propietario = new DataGridViewTextBoxColumn();
            Area = new DataGridViewTextBoxColumn();
            Proposito = new DataGridViewTextBoxColumn();
            Entrada = new DataGridViewTextBoxColumn();
            HoraEntrada = new DataGridViewTextBoxColumn();
            Salida = new DataGridViewTextBoxColumn();
            HoraSalida = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            txtFiltro = new TextBox();
            label2 = new Label();
            lblRegistros = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.BackgroundColor = Color.FromArgb(44, 44, 46);
            dtgDatos.BorderStyle = BorderStyle.None;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { id, visitante, documento, departamento, Edificio, propietario, Area, Proposito, Entrada, HoraEntrada, Salida, HoraSalida });
            dtgDatos.GridColor = Color.FromArgb(44, 44, 46);
            dtgDatos.Location = new Point(15, 87);
            dtgDatos.Margin = new Padding(4);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1248, 431);
            dtgDatos.TabIndex = 0;
            dtgDatos.CellFormatting += dtgDatos_CellFormatting;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // visitante
            // 
            visitante.DataPropertyName = "nombre_visita";
            visitante.HeaderText = "Nombre Visitante";
            visitante.Name = "visitante";
            visitante.ReadOnly = true;
            // 
            // documento
            // 
            documento.DataPropertyName = "documento";
            documento.HeaderText = "DNI";
            documento.Name = "documento";
            documento.ReadOnly = true;
            // 
            // departamento
            // 
            departamento.DataPropertyName = "departamento_numero";
            departamento.HeaderText = "Departamento";
            departamento.Name = "departamento";
            departamento.ReadOnly = true;
            // 
            // Edificio
            // 
            Edificio.DataPropertyName = "edificio";
            Edificio.HeaderText = "Edificio";
            Edificio.Name = "Edificio";
            Edificio.ReadOnly = true;
            // 
            // propietario
            // 
            propietario.DataPropertyName = "propietario_nombre";
            propietario.HeaderText = "Nombre Propietario";
            propietario.Name = "propietario";
            propietario.ReadOnly = true;
            // 
            // Area
            // 
            Area.DataPropertyName = "area_comun_nombre";
            Area.HeaderText = "Area";
            Area.Name = "Area";
            Area.ReadOnly = true;
            // 
            // Proposito
            // 
            Proposito.DataPropertyName = "proposito";
            Proposito.HeaderText = "Proposito";
            Proposito.Name = "Proposito";
            Proposito.ReadOnly = true;
            // 
            // Entrada
            // 
            Entrada.DataPropertyName = "fecha_entrada";
            Entrada.HeaderText = "Fecha Entrada";
            Entrada.Name = "Entrada";
            Entrada.ReadOnly = true;
            // 
            // HoraEntrada
            // 
            HoraEntrada.DataPropertyName = "hora_entrada";
            HoraEntrada.HeaderText = "Hora Entrada";
            HoraEntrada.Name = "HoraEntrada";
            HoraEntrada.ReadOnly = true;
            // 
            // Salida
            // 
            Salida.DataPropertyName = "fecha_salida";
            Salida.HeaderText = "Fecha Salida";
            Salida.Name = "Salida";
            Salida.ReadOnly = true;
            // 
            // HoraSalida
            // 
            HoraSalida.DataPropertyName = "hora_salida";
            HoraSalida.HeaderText = "HoraSalida";
            HoraSalida.Name = "HoraSalida";
            HoraSalida.ReadOnly = true;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(10, 132, 255);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(654, 590);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(125, 41);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(10, 132, 255);
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.ForeColor = SystemColors.Control;
            btnActualizar.Location = new Point(804, 590);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(125, 41);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(10, 132, 255);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(951, 590);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 41);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.ForeColor = SystemColors.Control;
            btnCerrar.Location = new Point(1139, 590);
            btnCerrar.Margin = new Padding(4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(125, 41);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(26, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 19);
            label1.TabIndex = 2;
            label1.Text = "Ingrese filtro por descripcion:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(276, 30);
            txtFiltro.Margin = new Padding(4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(403, 27);
            txtFiltro.TabIndex = 3;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(1054, 533);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 2;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.ForeColor = SystemColors.Control;
            lblRegistros.Location = new Point(1156, 533);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(107, 27);
            lblRegistros.TabIndex = 2;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // VisitaMan01
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(1279, 646);
            Controls.Add(txtFiltro);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dtgDatos);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VisitaMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Visitas";
            Load += VisitaMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label label1;
        private TextBox txtFiltro;
        private Label label2;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn visitante;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn departamento;
        private DataGridViewTextBoxColumn Edificio;
        private DataGridViewTextBoxColumn propietario;
        private DataGridViewTextBoxColumn Area;
        private DataGridViewTextBoxColumn Proposito;
        private DataGridViewTextBoxColumn Entrada;
        private DataGridViewTextBoxColumn HoraEntrada;
        private DataGridViewTextBoxColumn Salida;
        private DataGridViewTextBoxColumn HoraSalida;
    }
}