namespace Edifia_GUI
{
    partial class EmpleadoMan01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoMan01));
            btnCancelar = new Button();
            btnGrabar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cboHorario = new ComboBox();
            cboCargo = new ComboBox();
            txtDNI = new MaskedTextBox();
            pcbFoto = new PictureBox();
            btnCargar = new Button();
            dtpFnac = new DateTimePicker();
            label6 = new Label();
            txtTelefono = new MaskedTextBox();
            label7 = new Label();
            label8 = new Label();
            txtCorreo = new TextBox();
            grpSexo = new GroupBox();
            optFemenino = new RadioButton();
            optMasculino = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            grpSexo.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(242, 242, 247);
            btnCancelar.Location = new Point(306, 505);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(193, 38);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.FromArgb(10, 132, 255);
            btnGrabar.FlatStyle = FlatStyle.Popup;
            btnGrabar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrabar.ForeColor = Color.FromArgb(242, 242, 247);
            btnGrabar.Location = new Point(94, 505);
            btnGrabar.Margin = new Padding(4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(193, 38);
            btnGrabar.TabIndex = 10;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 19);
            label1.TabIndex = 20;
            label1.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 79);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 20;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(188, 76);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese nombre";
            txtNombre.Size = new Size(235, 27);
            txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 127);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 20;
            label3.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(188, 124);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese apellido";
            txtApellido.Size = new Size(235, 27);
            txtApellido.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 411);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 20;
            label4.Text = "Cargo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 124);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 20;
            label5.Text = "Horario:";
            // 
            // cboHorario
            // 
            cboHorario.FormattingEnabled = true;
            cboHorario.Location = new Point(577, 124);
            cboHorario.Margin = new Padding(4, 3, 4, 3);
            cboHorario.Name = "cboHorario";
            cboHorario.Size = new Size(170, 27);
            cboHorario.TabIndex = 8;
            // 
            // cboCargo
            // 
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(267, 403);
            cboCargo.Margin = new Padding(4, 3, 4, 3);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(156, 27);
            cboCargo.TabIndex = 5;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(190, 29);
            txtDNI.Mask = "99999999";
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(233, 27);
            txtDNI.TabIndex = 0;
            // 
            // pcbFoto
            // 
            pcbFoto.Location = new Point(546, 291);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(264, 252);
            pcbFoto.TabIndex = 21;
            pcbFoto.TabStop = false;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.FromArgb(10, 132, 255);
            btnCargar.FlatStyle = FlatStyle.Popup;
            btnCargar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.ForeColor = Color.FromArgb(242, 242, 247);
            btnCargar.Location = new Point(582, 236);
            btnCargar.Margin = new Padding(4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(193, 38);
            btnCargar.TabIndex = 9;
            btnCargar.Text = "Cargar Foto";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // dtpFnac
            // 
            dtpFnac.Format = DateTimePickerFormat.Short;
            dtpFnac.Location = new Point(267, 345);
            dtpFnac.Margin = new Padding(4, 3, 4, 3);
            dtpFnac.Name = "dtpFnac";
            dtpFnac.Size = new Size(156, 27);
            dtpFnac.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 345);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(180, 19);
            label6.TabIndex = 42;
            label6.Text = "Fecha de nacimiento:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(577, 29);
            txtTelefono.Mask = "999999999";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(235, 27);
            txtTelefono.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(469, 32);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 20;
            label7.Text = "Telefono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(469, 76);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 19);
            label8.TabIndex = 20;
            label8.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(577, 73);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ingrese correo";
            txtCorreo.Size = new Size(235, 27);
            txtCorreo.TabIndex = 7;
            // 
            // grpSexo
            // 
            grpSexo.Controls.Add(optFemenino);
            grpSexo.Controls.Add(optMasculino);
            grpSexo.ForeColor = SystemColors.Control;
            grpSexo.Location = new Point(83, 183);
            grpSexo.Margin = new Padding(4);
            grpSexo.Name = "grpSexo";
            grpSexo.Padding = new Padding(4);
            grpSexo.Size = new Size(176, 127);
            grpSexo.TabIndex = 3;
            grpSexo.TabStop = false;
            grpSexo.Text = "Sexo";
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(27, 80);
            optFemenino.Margin = new Padding(4);
            optFemenino.Name = "optFemenino";
            optFemenino.Size = new Size(105, 23);
            optFemenino.TabIndex = 1;
            optFemenino.TabStop = true;
            optFemenino.Text = "Femenino";
            optFemenino.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            optMasculino.AutoSize = true;
            optMasculino.Location = new Point(27, 36);
            optMasculino.Margin = new Padding(4);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(106, 23);
            optMasculino.TabIndex = 0;
            optMasculino.TabStop = true;
            optMasculino.Text = "Masculino";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // EmpleadoMan01
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(908, 580);
            Controls.Add(grpSexo);
            Controls.Add(dtpFnac);
            Controls.Add(label6);
            Controls.Add(pcbFoto);
            Controls.Add(txtTelefono);
            Controls.Add(txtDNI);
            Controls.Add(cboCargo);
            Controls.Add(cboHorario);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCargar);
            Controls.Add(btnGrabar);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "EmpleadoMan01";
            Text = "Insertar Empleado";
            Load += EmpleadoMan01_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            grpSexo.ResumeLayout(false);
            grpSexo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGrabar;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private Label label5;
        private ComboBox cboHorario;
        private ComboBox cboCargo;
        private MaskedTextBox txtDNI;
        private PictureBox pcbFoto;
        private Button btnCargar;
        private DateTimePicker dtpFnac;
        private Label label6;
        private MaskedTextBox txtTelefono;
        private Label label7;
        private Label label8;
        private TextBox txtCorreo;
        private GroupBox grpSexo;
        private RadioButton optFemenino;
        private RadioButton optMasculino;
    }
}