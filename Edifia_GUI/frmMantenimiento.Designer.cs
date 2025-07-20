namespace Edifia_GUI
{
    partial class frmMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimiento));
            btnRegistrar = new Button();
            cboActividad = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            cboEdificio = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cboEmpleado = new ComboBox();
            label5 = new Label();
            cboTipoEmpleado = new ComboBox();
            dtpFecPro = new MonthCalendar();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(10, 132, 255);
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.FromArgb(242, 242, 247);
            btnRegistrar.Location = new Point(937, 355);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(193, 38);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cboActividad
            // 
            cboActividad.FormattingEnabled = true;
            cboActividad.Location = new Point(221, 79);
            cboActividad.Margin = new Padding(4);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(653, 27);
            cboActividad.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(242, 242, 247);
            label1.Location = new Point(30, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 19);
            label1.TabIndex = 13;
            label1.Text = "Tipo de actividad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(242, 242, 247);
            label2.Location = new Point(903, 49);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 19);
            label2.TabIndex = 14;
            label2.Text = "Fecha programada:";
            // 
            // cboEdificio
            // 
            cboEdificio.FormattingEnabled = true;
            cboEdificio.Location = new Point(221, 142);
            cboEdificio.Margin = new Padding(4);
            cboEdificio.Name = "cboEdificio";
            cboEdificio.Size = new Size(653, 27);
            cboEdificio.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(242, 242, 247);
            label3.Location = new Point(30, 143);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 16;
            label3.Text = "Edificio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(242, 242, 247);
            label4.Location = new Point(30, 214);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(188, 19);
            label4.TabIndex = 18;
            label4.Text = "Empleado responsable";
            // 
            // cboEmpleado
            // 
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(221, 213);
            cboEmpleado.Margin = new Padding(4);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(653, 27);
            cboEmpleado.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(242, 242, 247);
            label5.Location = new Point(30, 279);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 19);
            label5.TabIndex = 20;
            label5.Text = "Tipo empleado";
            // 
            // cboTipoEmpleado
            // 
            cboTipoEmpleado.FormattingEnabled = true;
            cboTipoEmpleado.Location = new Point(221, 279);
            cboTipoEmpleado.Margin = new Padding(4);
            cboTipoEmpleado.Name = "cboTipoEmpleado";
            cboTipoEmpleado.Size = new Size(653, 27);
            cboTipoEmpleado.TabIndex = 3;
            // 
            // dtpFecPro
            // 
            dtpFecPro.Location = new Point(903, 79);
            dtpFecPro.Margin = new Padding(12, 11, 12, 11);
            dtpFecPro.Name = "dtpFecPro";
            dtpFecPro.TabIndex = 4;
            // 
            // frmMantenimiento
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(1176, 464);
            Controls.Add(dtpFecPro);
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
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmMantenimiento";
            Text = "Nuevo Mantenimiento";
            Load += frmMantenimiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegistrar;
        private ComboBox cboActividad;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private ComboBox cboEdificio;
        private Label label3;
        private Label label4;
        private ComboBox cboEmpleado;
        private Label label5;
        private ComboBox cboTipoEmpleado;
        private MonthCalendar dtpFecPro;
    }
}