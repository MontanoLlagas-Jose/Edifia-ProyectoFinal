namespace Edifia_GUI
{
    partial class HabitanteMan03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HabitanteMan03));
            btnCancelar = new Button();
            btnActualizar = new Button();
            mtboxDoc = new MaskedTextBox();
            txtNom = new TextBox();
            label4 = new Label();
            txtApe = new TextBox();
            lblNom = new Label();
            lbldoc = new Label();
            lblApe = new Label();
            label1 = new Label();
            pbFoto = new PictureBox();
            btnCargarFoto = new Button();
            label5 = new Label();
            chkbPropietario = new CheckBox();
            lblPro = new Label();
            mcCalendarioIngreso = new MonthCalendar();
            mcCalendarioEgreso = new MonthCalendar();
            openFileDialog1 = new OpenFileDialog();
            cboDepartamento = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(683, 405);
            btnCancelar.Margin = new Padding(4, 2, 4, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 28);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.BackColor = Color.FromArgb(10, 132, 255);
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(573, 405);
            btnActualizar.Margin = new Padding(4, 2, 4, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(98, 28);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // mtboxDoc
            // 
            mtboxDoc.Location = new Point(153, 27);
            mtboxDoc.Margin = new Padding(4, 2, 4, 2);
            mtboxDoc.Mask = "99999999";
            mtboxDoc.Name = "mtboxDoc";
            mtboxDoc.Size = new Size(177, 23);
            mtboxDoc.TabIndex = 1;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(153, 62);
            txtNom.Margin = new Padding(4, 2, 4, 2);
            txtNom.Name = "txtNom";
            txtNom.PlaceholderText = "Ingrese nombre";
            txtNom.Size = new Size(177, 23);
            txtNom.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(18, 155);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 19);
            label4.TabIndex = 6;
            label4.Text = "Número Dpto:";
            // 
            // txtApe
            // 
            txtApe.Location = new Point(153, 111);
            txtApe.Margin = new Padding(4, 2, 4, 2);
            txtApe.Name = "txtApe";
            txtApe.PlaceholderText = "Ingrese apellido";
            txtApe.Size = new Size(177, 23);
            txtApe.TabIndex = 5;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNom.ForeColor = SystemColors.Control;
            lblNom.Location = new Point(18, 67);
            lblNom.Margin = new Padding(4, 0, 4, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(77, 19);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nombre:";
            // 
            // lbldoc
            // 
            lbldoc.AutoSize = true;
            lbldoc.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldoc.ForeColor = SystemColors.Control;
            lbldoc.Location = new Point(18, 30);
            lbldoc.Margin = new Padding(4, 0, 4, 0);
            lbldoc.Name = "lbldoc";
            lbldoc.Size = new Size(104, 19);
            lbldoc.TabIndex = 0;
            lbldoc.Text = "Documento:";
            // 
            // lblApe
            // 
            lblApe.AutoSize = true;
            lblApe.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApe.ForeColor = SystemColors.Control;
            lblApe.Location = new Point(18, 115);
            lblApe.Margin = new Padding(4, 0, 4, 0);
            lblApe.Name = "lblApe";
            lblApe.Size = new Size(79, 19);
            lblApe.TabIndex = 4;
            lblApe.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(378, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 19);
            label1.TabIndex = 10;
            label1.Text = "Fecha Ingreso:";
            // 
            // pbFoto
            // 
            pbFoto.BackgroundImage = (Image)resources.GetObject("pbFoto.BackgroundImage");
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.InitialImage = (Image)resources.GetObject("pbFoto.InitialImage");
            pbFoto.Location = new Point(77, 253);
            pbFoto.Margin = new Padding(3, 2, 3, 2);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(205, 160);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 60;
            pbFoto.TabStop = false;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCargarFoto.BackColor = Color.FromArgb(10, 132, 255);
            btnCargarFoto.FlatStyle = FlatStyle.Popup;
            btnCargarFoto.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarFoto.ForeColor = SystemColors.ButtonFace;
            btnCargarFoto.Location = new Point(297, 323);
            btnCargarFoto.Margin = new Padding(4, 2, 4, 2);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(91, 24);
            btnCargarFoto.TabIndex = 14;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = false;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(378, 220);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 19);
            label5.TabIndex = 12;
            label5.Text = "Fecha Egreso:";
            // 
            // chkbPropietario
            // 
            chkbPropietario.AutoSize = true;
            chkbPropietario.BackColor = Color.Black;
            chkbPropietario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkbPropietario.ForeColor = SystemColors.Control;
            chkbPropietario.Location = new Point(79, 216);
            chkbPropietario.Margin = new Padding(3, 2, 3, 2);
            chkbPropietario.Name = "chkbPropietario";
            chkbPropietario.Size = new Size(15, 14);
            chkbPropietario.TabIndex = 8;
            chkbPropietario.UseVisualStyleBackColor = false;
            // 
            // lblPro
            // 
            lblPro.AutoSize = true;
            lblPro.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPro.ForeColor = SystemColors.Control;
            lblPro.Location = new Point(115, 212);
            lblPro.Margin = new Padding(4, 0, 4, 0);
            lblPro.Name = "lblPro";
            lblPro.Size = new Size(92, 19);
            lblPro.TabIndex = 9;
            lblPro.Text = "Propietario";
            // 
            // mcCalendarioIngreso
            // 
            mcCalendarioIngreso.Location = new Point(526, 30);
            mcCalendarioIngreso.Margin = new Padding(8, 7, 8, 7);
            mcCalendarioIngreso.Name = "mcCalendarioIngreso";
            mcCalendarioIngreso.TabIndex = 11;
            // 
            // mcCalendarioEgreso
            // 
            mcCalendarioEgreso.Location = new Point(526, 212);
            mcCalendarioEgreso.Margin = new Padding(8, 7, 8, 7);
            mcCalendarioEgreso.Name = "mcCalendarioEgreso";
            mcCalendarioEgreso.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(154, 152);
            cboDepartamento.Margin = new Padding(4, 2, 4, 2);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(177, 23);
            cboDepartamento.TabIndex = 7;
            // 
            // HabitanteMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(806, 461);
            Controls.Add(cboDepartamento);
            Controls.Add(mcCalendarioEgreso);
            Controls.Add(mcCalendarioIngreso);
            Controls.Add(chkbPropietario);
            Controls.Add(lblPro);
            Controls.Add(label5);
            Controls.Add(pbFoto);
            Controls.Add(btnCancelar);
            Controls.Add(btnCargarFoto);
            Controls.Add(btnActualizar);
            Controls.Add(mtboxDoc);
            Controls.Add(txtNom);
            Controls.Add(label4);
            Controls.Add(txtApe);
            Controls.Add(lblNom);
            Controls.Add(lbldoc);
            Controls.Add(lblApe);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HabitanteMan03";
            Text = "Actualizar Habitante";
            Load += HabitanteMan03_Load;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnActualizar;
        private MaskedTextBox mtboxDoc;
        private TextBox txtNom;
        private Label label4;
        private TextBox txtApe;
        private Label lblNom;
        private Label lbldoc;
        private Label lblApe;
        private Label label1;
        private PictureBox pbFoto;
        private Button btnCargarFoto;
        private Label label5;
        private CheckBox chkbPropietario;
        private Label lblPro;
        private MonthCalendar mcCalendarioIngreso;
        private MonthCalendar mcCalendarioEgreso;
        private OpenFileDialog openFileDialog1;
        private ComboBox cboDepartamento;
    }
}