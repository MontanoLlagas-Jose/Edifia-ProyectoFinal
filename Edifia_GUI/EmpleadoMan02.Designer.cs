namespace Edifia_GUI
{
    partial class EmpleadoMan02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoMan02));
            cboHorario = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnModificar = new Button();
            lblDNI = new Label();
            cboCargo = new ComboBox();
            label6 = new Label();
            dtpFini = new DateTimePicker();
            pcbFoto = new PictureBox();
            btnCargar = new Button();
            grpSexo = new GroupBox();
            optFemenino = new RadioButton();
            optMasculino = new RadioButton();
            label7 = new Label();
            dtpFnac = new DateTimePicker();
            txtTelefono = new MaskedTextBox();
            label8 = new Label();
            txtCorreo = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            grpSexo.SuspendLayout();
            SuspendLayout();
            // 
            // cboHorario
            // 
            cboHorario.FormattingEnabled = true;
            cboHorario.Location = new Point(641, 120);
            cboHorario.Margin = new Padding(4, 3, 4, 3);
            cboHorario.Name = "cboHorario";
            cboHorario.Size = new Size(235, 27);
            cboHorario.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(518, 123);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 27;
            label5.Text = "Horario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 404);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 28;
            label4.Text = "Cargo:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(175, 118);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(235, 27);
            txtApellido.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 123);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 29;
            label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(175, 70);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(235, 27);
            txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 30;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 19);
            label1.TabIndex = 31;
            label1.Text = "DNI:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(242, 242, 247);
            btnCancelar.Location = new Point(291, 480);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(193, 38);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(10, 132, 255);
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.FromArgb(242, 242, 247);
            btnModificar.Location = new Point(55, 480);
            btnModificar.Margin = new Padding(4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(193, 38);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblDNI
            // 
            lblDNI.Location = new Point(175, 24);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(177, 30);
            lblDNI.TabIndex = 38;
            // 
            // cboCargo
            // 
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(240, 404);
            cboCargo.Margin = new Padding(4, 3, 4, 3);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(170, 27);
            cboCargo.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(518, 176);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(108, 19);
            label6.TabIndex = 40;
            label6.Text = "Fecha Inicio:";
            // 
            // dtpFini
            // 
            dtpFini.Format = DateTimePickerFormat.Short;
            dtpFini.Location = new Point(641, 170);
            dtpFini.Margin = new Padding(4, 3, 4, 3);
            dtpFini.Name = "dtpFini";
            dtpFini.Size = new Size(235, 27);
            dtpFini.TabIndex = 8;
            // 
            // pcbFoto
            // 
            pcbFoto.Location = new Point(628, 300);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(248, 218);
            pcbFoto.TabIndex = 42;
            pcbFoto.TabStop = false;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.FromArgb(10, 132, 255);
            btnCargar.FlatStyle = FlatStyle.Popup;
            btnCargar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.ForeColor = Color.FromArgb(242, 242, 247);
            btnCargar.Location = new Point(656, 249);
            btnCargar.Margin = new Padding(4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(193, 38);
            btnCargar.TabIndex = 9;
            btnCargar.Text = "Cargar Foto";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // grpSexo
            // 
            grpSexo.Controls.Add(optFemenino);
            grpSexo.Controls.Add(optMasculino);
            grpSexo.ForeColor = SystemColors.Control;
            grpSexo.Location = new Point(55, 176);
            grpSexo.Margin = new Padding(4);
            grpSexo.Name = "grpSexo";
            grpSexo.Padding = new Padding(4);
            grpSexo.Size = new Size(176, 127);
            grpSexo.TabIndex = 2;
            grpSexo.TabStop = false;
            grpSexo.Text = "Sexo";
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(28, 81);
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
            optMasculino.Location = new Point(28, 37);
            optMasculino.Margin = new Padding(4);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(106, 23);
            optMasculino.TabIndex = 0;
            optMasculino.TabStop = true;
            optMasculino.Text = "Masculino";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 337);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(157, 19);
            label7.TabIndex = 40;
            label7.Text = "Fecha Nacimiento:";
            // 
            // dtpFnac
            // 
            dtpFnac.Format = DateTimePickerFormat.Short;
            dtpFnac.Location = new Point(247, 331);
            dtpFnac.Margin = new Padding(4, 3, 4, 3);
            dtpFnac.Name = "dtpFnac";
            dtpFnac.Size = new Size(163, 27);
            dtpFnac.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(641, 21);
            txtTelefono.Mask = "999999999";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(235, 27);
            txtTelefono.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(518, 27);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 19);
            label8.TabIndex = 47;
            label8.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(641, 70);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ingrese correo";
            txtCorreo.Size = new Size(235, 27);
            txtCorreo.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(518, 71);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 19);
            label9.TabIndex = 48;
            label9.Text = "Correo:";
            // 
            // EmpleadoMan02
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(955, 556);
            Controls.Add(txtTelefono);
            Controls.Add(label8);
            Controls.Add(txtCorreo);
            Controls.Add(label9);
            Controls.Add(grpSexo);
            Controls.Add(pcbFoto);
            Controls.Add(btnCargar);
            Controls.Add(dtpFnac);
            Controls.Add(dtpFini);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cboCargo);
            Controls.Add(lblDNI);
            Controls.Add(cboHorario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificar);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "EmpleadoMan02";
            Text = "Actualizar Empleado";
            Load += EmpleadoMan02_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            grpSexo.ResumeLayout(false);
            grpSexo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboHorario;
        private Label label5;
        private Label label4;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnModificar;
        private Label lblDNI;
        private ComboBox cboCargo;
        private Label label6;
        private DateTimePicker dtpFini;
        private PictureBox pcbFoto;
        private Button btnCargar;
        private GroupBox grpSexo;
        private RadioButton optFemenino;
        private RadioButton optMasculino;
        private Label label7;
        private DateTimePicker dtpFnac;
        private MaskedTextBox txtTelefono;
        private Label label8;
        private TextBox txtCorreo;
        private Label label9;
    }
}