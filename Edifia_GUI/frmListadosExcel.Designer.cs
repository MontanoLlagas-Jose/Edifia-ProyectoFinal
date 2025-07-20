namespace Edifia_GUI
{
    partial class frmListadosExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadosExcel));
            textBox1 = new TextBox();
            btnHabitantes = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnEmpleados = new Button();
            btnVisitas = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(44, 44, 46);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(22, 30);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 0;
            textBox1.Text = "Habitantes:";
            // 
            // btnHabitantes
            // 
            btnHabitantes.BackgroundImage = (Image)resources.GetObject("btnHabitantes.BackgroundImage");
            btnHabitantes.BackgroundImageLayout = ImageLayout.Stretch;
            btnHabitantes.Location = new Point(128, 17);
            btnHabitantes.Name = "btnHabitantes";
            btnHabitantes.Size = new Size(41, 41);
            btnHabitantes.TabIndex = 1;
            btnHabitantes.UseVisualStyleBackColor = true;
            btnHabitantes.Click += btnHabitantes_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(44, 44, 46);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(22, 91);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 16);
            textBox2.TabIndex = 0;
            textBox2.Text = "Empleados:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(44, 44, 46);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(22, 151);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 16);
            textBox3.TabIndex = 0;
            textBox3.Text = "Visitas:";
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackgroundImage = (Image)resources.GetObject("btnEmpleados.BackgroundImage");
            btnEmpleados.BackgroundImageLayout = ImageLayout.Stretch;
            btnEmpleados.Location = new Point(128, 78);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(41, 41);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnVisitas
            // 
            btnVisitas.BackgroundImage = (Image)resources.GetObject("btnVisitas.BackgroundImage");
            btnVisitas.BackgroundImageLayout = ImageLayout.Stretch;
            btnVisitas.Location = new Point(128, 138);
            btnVisitas.Name = "btnVisitas";
            btnVisitas.Size = new Size(41, 41);
            btnVisitas.TabIndex = 1;
            btnVisitas.UseVisualStyleBackColor = true;
            btnVisitas.Click += btnVisitas_Click;
            // 
            // frmListadosExcel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(205, 206);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(btnVisitas);
            Controls.Add(btnEmpleados);
            Controls.Add(btnHabitantes);
            Controls.Add(textBox1);
            Name = "frmListadosExcel";
            Text = "Listados";
            Load += frmListadosExcel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnHabitantes;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnEmpleados;
        private Button btnVisitas;
    }
}