namespace Edifia_GUI
{
    partial class DepartamentoMan03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartamentoMan03));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumero = new TextBox();
            txtPiso = new TextBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            cboEdificio = new ComboBox();
            groupBox1 = new GroupBox();
            optDeshabitado = new RadioButton();
            optHabitado = new RadioButton();
            label4 = new Label();
            lblid = new Label();
            btnCargarFoto = new Button();
            pcbFoto = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(28, 86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 0;
            label1.Text = "Numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(28, 136);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 19);
            label2.TabIndex = 0;
            label2.Text = "Piso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(28, 185);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 0;
            label3.Text = "Edificio:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(112, 86);
            txtNumero.Margin = new Padding(4);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Ingrese numero";
            txtNumero.Size = new Size(154, 27);
            txtNumero.TabIndex = 0;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // txtPiso
            // 
            txtPiso.Location = new Point(112, 130);
            txtPiso.Margin = new Padding(4);
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(154, 27);
            txtPiso.TabIndex = 1;
            txtPiso.KeyPress += txtPiso_KeyPress;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.FromArgb(10, 132, 255);
            btnGrabar.FlatStyle = FlatStyle.Popup;
            btnGrabar.ForeColor = SystemColors.Control;
            btnGrabar.Location = new Point(501, 312);
            btnGrabar.Margin = new Padding(4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(96, 29);
            btnGrabar.TabIndex = 3;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(501, 362);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboEdificio
            // 
            cboEdificio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEdificio.FormattingEnabled = true;
            cboEdificio.Location = new Point(112, 175);
            cboEdificio.Margin = new Padding(4);
            cboEdificio.Name = "cboEdificio";
            cboEdificio.Size = new Size(154, 27);
            cboEdificio.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optDeshabitado);
            groupBox1.Controls.Add(optHabitado);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(421, 86);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(176, 127);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado";
            // 
            // optDeshabitado
            // 
            optDeshabitado.AutoSize = true;
            optDeshabitado.Location = new Point(26, 79);
            optDeshabitado.Margin = new Padding(4);
            optDeshabitado.Name = "optDeshabitado";
            optDeshabitado.Size = new Size(126, 23);
            optDeshabitado.TabIndex = 1;
            optDeshabitado.TabStop = true;
            optDeshabitado.Text = "Deshabitado";
            optDeshabitado.UseVisualStyleBackColor = true;
            // 
            // optHabitado
            // 
            optHabitado.AutoSize = true;
            optHabitado.Location = new Point(26, 35);
            optHabitado.Margin = new Padding(4);
            optHabitado.Name = "optHabitado";
            optHabitado.Size = new Size(100, 23);
            optHabitado.TabIndex = 0;
            optHabitado.TabStop = true;
            optHabitado.Text = "Habitado";
            optHabitado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(28, 27);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 19);
            label4.TabIndex = 0;
            label4.Text = "Id:";
            // 
            // lblid
            // 
            lblid.BorderStyle = BorderStyle.FixedSingle;
            lblid.Location = new Point(112, 27);
            lblid.Margin = new Padding(4, 0, 4, 0);
            lblid.Name = "lblid";
            lblid.Size = new Size(155, 29);
            lblid.TabIndex = 7;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.BackColor = Color.FromArgb(10, 132, 255);
            btnCargarFoto.FlatStyle = FlatStyle.Popup;
            btnCargarFoto.ForeColor = SystemColors.Control;
            btnCargarFoto.Location = new Point(28, 312);
            btnCargarFoto.Margin = new Padding(4);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(125, 29);
            btnCargarFoto.TabIndex = 3;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = false;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // pcbFoto
            // 
            pcbFoto.Location = new Point(167, 237);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(319, 268);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 8;
            pcbFoto.TabStop = false;
            // 
            // DepartamentoMan03
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(624, 531);
            Controls.Add(pcbFoto);
            Controls.Add(lblid);
            Controls.Add(groupBox1);
            Controls.Add(txtPiso);
            Controls.Add(cboEdificio);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(btnCargarFoto);
            Controls.Add(btnGrabar);
            Controls.Add(label3);
            Controls.Add(txtNumero);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "DepartamentoMan03";
            Text = "Actualizar Departamento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumero;
        private TextBox txtPiso;
        private Button btnGrabar;
        private Button btnCancelar;
        private ComboBox cboEdificio;
        private GroupBox groupBox1;
        private RadioButton optDeshabitado;
        private RadioButton optHabitado;
        private Label label4;
        private Label lblid;
        private Button btnCargarFoto;
        private PictureBox pcbFoto;
    }
}