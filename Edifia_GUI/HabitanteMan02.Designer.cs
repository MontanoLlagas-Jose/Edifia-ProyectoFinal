using System.Windows.Forms;

namespace Edifia_GUI
{
    partial class HabitanteMan02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HabitanteMan02));
            btnCancelar = new Button();
            btnGrabar = new Button();
            mtboxDoc = new MaskedTextBox();
            txtNom = new TextBox();
            label4 = new Label();
            txtApe = new TextBox();
            lblNom = new Label();
            lbldoc = new Label();
            lblApe = new Label();
            lblPro = new Label();
            pbFoto = new PictureBox();
            btnCargarFoto = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblFechaIn = new Label();
            mcCalendarioIngreso = new MonthCalendar();
            chkPropietario = new CheckBox();
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
            btnCancelar.Location = new Point(663, 334);
            btnCancelar.Margin = new Padding(4, 2, 4, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 28);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGrabar.BackColor = Color.FromArgb(10, 132, 255);
            btnGrabar.FlatStyle = FlatStyle.Popup;
            btnGrabar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrabar.Location = new Point(550, 334);
            btnGrabar.Margin = new Padding(4, 2, 4, 2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(91, 28);
            btnGrabar.TabIndex = 13;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // mtboxDoc
            // 
            mtboxDoc.Location = new Point(157, 106);
            mtboxDoc.Margin = new Padding(4, 2, 4, 2);
            mtboxDoc.Mask = "99999999";
            mtboxDoc.Name = "mtboxDoc";
            mtboxDoc.Size = new Size(177, 23);
            mtboxDoc.TabIndex = 5;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(157, 30);
            txtNom.Margin = new Padding(4, 2, 4, 2);
            txtNom.Name = "txtNom";
            txtNom.PlaceholderText = "Ingrese nombre";
            txtNom.Size = new Size(177, 23);
            txtNom.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(22, 142);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 19);
            label4.TabIndex = 6;
            label4.Text = "Número Dpto:";
            // 
            // txtApe
            // 
            txtApe.Location = new Point(157, 68);
            txtApe.Margin = new Padding(4, 2, 4, 2);
            txtApe.Name = "txtApe";
            txtApe.PlaceholderText = "Ingrese apellido";
            txtApe.Size = new Size(177, 23);
            txtApe.TabIndex = 3;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNom.ForeColor = SystemColors.Control;
            lblNom.Location = new Point(22, 34);
            lblNom.Margin = new Padding(4, 0, 4, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(77, 19);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nombre:";
            // 
            // lbldoc
            // 
            lbldoc.AutoSize = true;
            lbldoc.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldoc.ForeColor = SystemColors.Control;
            lbldoc.Location = new Point(22, 109);
            lbldoc.Margin = new Padding(4, 0, 4, 0);
            lbldoc.Name = "lbldoc";
            lbldoc.Size = new Size(40, 19);
            lbldoc.TabIndex = 4;
            lbldoc.Text = "DNI:";
            // 
            // lblApe
            // 
            lblApe.AutoSize = true;
            lblApe.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApe.ForeColor = SystemColors.Control;
            lblApe.Location = new Point(22, 71);
            lblApe.Margin = new Padding(4, 0, 4, 0);
            lblApe.Name = "lblApe";
            lblApe.Size = new Size(79, 19);
            lblApe.TabIndex = 2;
            lblApe.Text = "Apellido:";
            // 
            // lblPro
            // 
            lblPro.AutoSize = true;
            lblPro.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPro.ForeColor = SystemColors.Control;
            lblPro.Location = new Point(593, 31);
            lblPro.Margin = new Padding(4, 0, 4, 0);
            lblPro.Name = "lblPro";
            lblPro.Size = new Size(92, 19);
            lblPro.TabIndex = 11;
            lblPro.Text = "Propietario";
            // 
            // pbFoto
            // 
            pbFoto.BackgroundImage = (Image)resources.GetObject("pbFoto.BackgroundImage");
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(549, 79);
            pbFoto.Margin = new Padding(3, 2, 3, 2);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(205, 160);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 66;
            pbFoto.TabStop = false;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCargarFoto.BackColor = Color.FromArgb(10, 132, 255);
            btnCargarFoto.FlatStyle = FlatStyle.Popup;
            btnCargarFoto.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarFoto.ForeColor = SystemColors.ButtonFace;
            btnCargarFoto.Location = new Point(446, 105);
            btnCargarFoto.Margin = new Padding(4, 2, 4, 2);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(91, 24);
            btnCargarFoto.TabIndex = 12;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = false;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFechaIn
            // 
            lblFechaIn.AutoSize = true;
            lblFechaIn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaIn.ForeColor = SystemColors.Control;
            lblFechaIn.Location = new Point(22, 200);
            lblFechaIn.Margin = new Padding(4, 0, 4, 0);
            lblFechaIn.Name = "lblFechaIn";
            lblFechaIn.Size = new Size(122, 19);
            lblFechaIn.TabIndex = 8;
            lblFechaIn.Text = "Fecha Ingreso:";
            // 
            // mcCalendarioIngreso
            // 
            mcCalendarioIngreso.Location = new Point(169, 200);
            mcCalendarioIngreso.Margin = new Padding(8, 7, 8, 7);
            mcCalendarioIngreso.MaxSelectionCount = 1;
            mcCalendarioIngreso.Name = "mcCalendarioIngreso";
            mcCalendarioIngreso.TabIndex = 9;
            // 
            // chkPropietario
            // 
            chkPropietario.AutoSize = true;
            chkPropietario.BackColor = Color.Black;
            chkPropietario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkPropietario.ForeColor = SystemColors.Control;
            chkPropietario.Location = new Point(552, 35);
            chkPropietario.Margin = new Padding(3, 2, 3, 2);
            chkPropietario.Name = "chkPropietario";
            chkPropietario.Size = new Size(15, 14);
            chkPropietario.TabIndex = 10;
            chkPropietario.UseVisualStyleBackColor = false;
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(157, 142);
            cboDepartamento.Margin = new Padding(4, 2, 4, 2);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(177, 23);
            cboDepartamento.TabIndex = 7;
            // 
            // HabitanteMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(770, 385);
            Controls.Add(cboDepartamento);
            Controls.Add(chkPropietario);
            Controls.Add(mcCalendarioIngreso);
            Controls.Add(pbFoto);
            Controls.Add(btnCargarFoto);
            Controls.Add(lblFechaIn);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HabitanteMan02";
            Text = "Nuevo Habitante";
            Load += HabitanteMan02_Load;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnGrabar;
        private MaskedTextBox mtboxDoc;
        private TextBox txtNom;
        private Label label4;
        private TextBox txtApe;
        private Label lblNom;
        private Label lbldoc;
        private Label lblApe;
        private Label lblPro;
        private PictureBox pbFoto;
        private Button btnCargarFoto;
        private Label lblFechaIn;
        private OpenFileDialog openFileDialog1;
        private MonthCalendar mcCalendarioIngreso;
        private CheckBox chkPropietario;
        private ComboBox cboDepartamento;
    }
}