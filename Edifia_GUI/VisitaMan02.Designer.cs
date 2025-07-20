namespace Edifia_GUI
{
    partial class VisitaMan02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitaMan02));
            cbbox2 = new ComboBox();
            label1 = new Label();
            lblA = new Label();
            cbbox1 = new ComboBox();
            lblPro = new Label();
            txtApe = new TextBox();
            lblApe = new Label();
            lblNom = new Label();
            txtNom = new TextBox();
            lbldoc = new Label();
            mtboxDoc = new MaskedTextBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            mcCalendarioEntrada = new MonthCalendar();
            cboHoraEntrada = new ComboBox();
            label2 = new Label();
            cboMinutoEntrada = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cboDerpartamento = new ComboBox();
            SuspendLayout();
            // 
            // cbbox2
            // 
            cbbox2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox2.FormattingEnabled = true;
            cbbox2.Items.AddRange(new object[] { "Area de Mascotas", "Biblioteca", "Cafeteria", "Cancha de futbolGimnasio", "Jardín", "Parque", "Piscina", "Sala de cine", "Sala de estudio", "Sala de eventos", "Sala de juegos", "Sauna", "Terraza" });
            cbbox2.Location = new Point(179, 285);
            cbbox2.Margin = new Padding(4, 3, 4, 3);
            cbbox2.Name = "cbbox2";
            cbbox2.Size = new Size(202, 27);
            cbbox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(438, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 8;
            label1.Text = "Fecha:";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.ForeColor = SystemColors.Control;
            lblA.Location = new Point(37, 285);
            lblA.Margin = new Padding(4, 0, 4, 0);
            lblA.Name = "lblA";
            lblA.Size = new Size(51, 19);
            lblA.TabIndex = 6;
            lblA.Text = "Area:";
            // 
            // cbbox1
            // 
            cbbox1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox1.FormattingEnabled = true;
            cbbox1.Items.AddRange(new object[] { "Actividad", "Celebración", "Cine", "Convivio", "Cultura", "Deporte", "Descanso", "Diversión", "Ejercicio", "Estudio", "Evento", "Fiesta", "Lectura", "Relajación", "Reunión", "Trabajo" });
            cbbox1.Location = new Point(179, 234);
            cbbox1.Margin = new Padding(4, 3, 4, 3);
            cbbox1.Name = "cbbox1";
            cbbox1.Size = new Size(202, 27);
            cbbox1.TabIndex = 4;
            // 
            // lblPro
            // 
            lblPro.AutoSize = true;
            lblPro.ForeColor = SystemColors.Control;
            lblPro.Location = new Point(37, 236);
            lblPro.Margin = new Padding(4, 0, 4, 0);
            lblPro.Name = "lblPro";
            lblPro.Size = new Size(82, 19);
            lblPro.TabIndex = 4;
            lblPro.Text = "Propósito:";
            // 
            // txtApe
            // 
            txtApe.Location = new Point(179, 82);
            txtApe.Margin = new Padding(4, 3, 4, 3);
            txtApe.Name = "txtApe";
            txtApe.PlaceholderText = "Ingrese apellido";
            txtApe.Size = new Size(202, 27);
            txtApe.TabIndex = 1;
            // 
            // lblApe
            // 
            lblApe.AutoSize = true;
            lblApe.ForeColor = SystemColors.Control;
            lblApe.Location = new Point(37, 87);
            lblApe.Margin = new Padding(4, 0, 4, 0);
            lblApe.Name = "lblApe";
            lblApe.Size = new Size(79, 19);
            lblApe.TabIndex = 2;
            lblApe.Text = "Apellido:";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.ForeColor = SystemColors.Control;
            lblNom.Location = new Point(37, 38);
            lblNom.Margin = new Padding(4, 0, 4, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(77, 19);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nombre:";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(179, 32);
            txtNom.Margin = new Padding(4, 3, 4, 3);
            txtNom.Name = "txtNom";
            txtNom.PlaceholderText = "Ingrese nombre";
            txtNom.Size = new Size(202, 27);
            txtNom.TabIndex = 0;
            // 
            // lbldoc
            // 
            lbldoc.AutoSize = true;
            lbldoc.ForeColor = SystemColors.Control;
            lbldoc.Location = new Point(37, 137);
            lbldoc.Margin = new Padding(4, 0, 4, 0);
            lbldoc.Name = "lbldoc";
            lbldoc.Size = new Size(104, 19);
            lbldoc.TabIndex = 2;
            lbldoc.Text = "Documento:";
            // 
            // mtboxDoc
            // 
            mtboxDoc.Location = new Point(179, 133);
            mtboxDoc.Margin = new Padding(4, 3, 4, 3);
            mtboxDoc.Mask = "99999999";
            mtboxDoc.Name = "mtboxDoc";
            mtboxDoc.Size = new Size(202, 27);
            mtboxDoc.TabIndex = 2;
            // 
            // btnGrabar
            // 
            btnGrabar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGrabar.BackColor = Color.FromArgb(10, 132, 255);
            btnGrabar.FlatStyle = FlatStyle.Popup;
            btnGrabar.Location = new Point(544, 331);
            btnGrabar.Margin = new Padding(4, 3, 4, 3);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(104, 28);
            btnGrabar.TabIndex = 8;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(687, 331);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 28);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mcCalendarioEntrada
            // 
            mcCalendarioEntrada.Location = new Point(505, 32);
            mcCalendarioEntrada.Margin = new Padding(12, 11, 12, 11);
            mcCalendarioEntrada.Name = "mcCalendarioEntrada";
            mcCalendarioEntrada.TabIndex = 17;
            // 
            // cboHoraEntrada
            // 
            cboHoraEntrada.FormattingEnabled = true;
            cboHoraEntrada.Location = new Point(563, 262);
            cboHoraEntrada.Margin = new Padding(4);
            cboHoraEntrada.Name = "cboHoraEntrada";
            cboHoraEntrada.Size = new Size(66, 27);
            cboHoraEntrada.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(501, 272);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 8;
            label2.Text = "Hora:";
            // 
            // cboMinutoEntrada
            // 
            cboMinutoEntrada.FormattingEnabled = true;
            cboMinutoEntrada.Location = new Point(741, 262);
            cboMinutoEntrada.Margin = new Padding(4);
            cboMinutoEntrada.Name = "cboMinutoEntrada";
            cboMinutoEntrada.Size = new Size(66, 27);
            cboMinutoEntrada.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(667, 272);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 8;
            label3.Text = "Minuto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(37, 186);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 19);
            label4.TabIndex = 0;
            label4.Text = "Departamento:";
            // 
            // cboDerpartamento
            // 
            cboDerpartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDerpartamento.FormattingEnabled = true;
            cboDerpartamento.Items.AddRange(new object[] { "Actividad", "Celebración", "Cine", "Convivio", "Cultura", "Deporte", "Descanso", "Diversión", "Ejercicio", "Estudio", "Evento", "Fiesta", "Lectura", "Relajación", "Reunión", "Trabajo" });
            cboDerpartamento.Location = new Point(179, 182);
            cboDerpartamento.Margin = new Padding(4, 3, 4, 3);
            cboDerpartamento.Name = "cboDerpartamento";
            cboDerpartamento.Size = new Size(202, 27);
            cboDerpartamento.TabIndex = 3;
            // 
            // VisitaMan02
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(882, 385);
            Controls.Add(cboMinutoEntrada);
            Controls.Add(cboHoraEntrada);
            Controls.Add(mcCalendarioEntrada);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(mtboxDoc);
            Controls.Add(txtNom);
            Controls.Add(label4);
            Controls.Add(txtApe);
            Controls.Add(lblNom);
            Controls.Add(lbldoc);
            Controls.Add(lblApe);
            Controls.Add(lblPro);
            Controls.Add(lblA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboDerpartamento);
            Controls.Add(cbbox1);
            Controls.Add(cbbox2);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1281, 623);
            MinimizeBox = false;
            MinimumSize = new Size(898, 380);
            Name = "VisitaMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Visita";
            Load += VisitaMan02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbox2;
        private Label label1;
        private Label lblA;
        private ComboBox cbbox1;
        private Label lblPro;
        private TextBox txtApe;
        private Label lblApe;
        private Label lblNom;
        private TextBox txtNom;
        private Label lbldoc;
        private MaskedTextBox mtboxDoc;
        private Button btnGrabar;
        private Button btnCancelar;
        private MonthCalendar mcCalendarioEntrada;
        private ComboBox cboHoraEntrada;
        private Label label2;
        private ComboBox cboMinutoEntrada;
        private Label label3;
        private Label label4;
        private ComboBox cboDerpartamento;
    }
}