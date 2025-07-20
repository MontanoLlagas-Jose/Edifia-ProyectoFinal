
namespace Edifia_GUI
{
    partial class frmMantenimiento02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimiento02));
            label5 = new Label();
            cboTipoEmpleado = new ComboBox();
            label4 = new Label();
            cboEmpleado = new ComboBox();
            label3 = new Label();
            cboEdificio = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cboActividad = new ComboBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            lblCodigo = new Label();
            label7 = new Label();
            label6 = new Label();
            dtpFecPro = new MonthCalendar();
            dtpFecRea = new MonthCalendar();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(242, 242, 247);
            label5.Location = new Point(12, 239);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 19);
            label5.TabIndex = 31;
            label5.Text = "Tipo empleado";
            // 
            // cboTipoEmpleado
            // 
            cboTipoEmpleado.FormattingEnabled = true;
            cboTipoEmpleado.Location = new Point(203, 239);
            cboTipoEmpleado.Margin = new Padding(4, 3, 4, 3);
            cboTipoEmpleado.Name = "cboTipoEmpleado";
            cboTipoEmpleado.Size = new Size(240, 23);
            cboTipoEmpleado.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(242, 242, 247);
            label4.Location = new Point(9, 187);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(188, 19);
            label4.TabIndex = 29;
            label4.Text = "Empleado responsable";
            // 
            // cboEmpleado
            // 
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(203, 187);
            cboEmpleado.Margin = new Padding(4, 3, 4, 3);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(240, 23);
            cboEmpleado.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(242, 242, 247);
            label3.Location = new Point(12, 135);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 27;
            label3.Text = "Edificio:";
            // 
            // cboEdificio
            // 
            cboEdificio.FormattingEnabled = true;
            cboEdificio.Location = new Point(203, 132);
            cboEdificio.Margin = new Padding(4, 3, 4, 3);
            cboEdificio.Name = "cboEdificio";
            cboEdificio.Size = new Size(240, 23);
            cboEdificio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(242, 242, 247);
            label2.Location = new Point(508, 39);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 19);
            label2.TabIndex = 25;
            label2.Text = "Fecha programada:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(242, 242, 247);
            label1.Location = new Point(12, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 19);
            label1.TabIndex = 24;
            label1.Text = "Tipo de actividad:";
            // 
            // cboActividad
            // 
            cboActividad.FormattingEnabled = true;
            cboActividad.Location = new Point(203, 78);
            cboActividad.Margin = new Padding(4, 3, 4, 3);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(240, 23);
            cboActividad.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(10, 132, 255);
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.FromArgb(242, 242, 247);
            btnRegistrar.Location = new Point(183, 419);
            btnRegistrar.Margin = new Padding(4, 3, 4, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(120, 30);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Grabar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(242, 242, 247);
            btnCancelar.Location = new Point(323, 419);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 30);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.ForeColor = SystemColors.Control;
            lblCodigo.Location = new Point(203, 32);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(70, 23);
            lblCodigo.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(12, 39);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 19);
            label7.TabIndex = 33;
            label7.Text = "Código:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(242, 242, 247);
            label6.Location = new Point(508, 258);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(156, 19);
            label6.TabIndex = 36;
            label6.Text = "Fecha Realizacion:";
            // 
            // dtpFecPro
            // 
            dtpFecPro.Location = new Point(508, 67);
            dtpFecPro.Name = "dtpFecPro";
            dtpFecPro.TabIndex = 7;
            // 
            // dtpFecRea
            // 
            dtpFecRea.Location = new Point(508, 287);
            dtpFecRea.Name = "dtpFecRea";
            dtpFecRea.TabIndex = 8;
            // 
            // frmMantenimiento02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(805, 481);
            Controls.Add(dtpFecRea);
            Controls.Add(dtpFecPro);
            Controls.Add(label6);
            Controls.Add(lblCodigo);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(cboTipoEmpleado);
            Controls.Add(label4);
            Controls.Add(cboEmpleado);
            Controls.Add(label3);
            Controls.Add(cboEdificio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboActividad);
            Controls.Add(btnRegistrar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMantenimiento02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar";
            Load += frmMantenimiento02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void brnCancelar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label5;
        private ComboBox cboTipoEmpleado;
        private Label label4;
        private ComboBox cboEmpleado;
        private Label label3;
        private ComboBox cboEdificio;
        private Label label2;
        private Label label1;
        private ComboBox cboActividad;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Label lblCodigo;
        private Label label7;
        private Label label6;
        private MonthCalendar dtpFecPro;
        private MonthCalendar dtpFecRea;
    }
}