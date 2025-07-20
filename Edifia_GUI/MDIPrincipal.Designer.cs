namespace Edifia_GUI
{
    partial class MDIPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            menuStrip1 = new MenuStrip();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            departamentoToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem1 = new ToolStripMenuItem();
            visitaToolStripMenuItem = new ToolStripMenuItem();
            empleadoToolStripMenuItem = new ToolStripMenuItem();
            habitanteToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            descargarToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            lblUsuario = new ToolStripStatusLabel();
            lblTiempo = new ToolStripStatusLabel();
            listadosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientoToolStripMenuItem, descargarToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1029, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { departamentoToolStripMenuItem, mantenimientoToolStripMenuItem1, visitaToolStripMenuItem, empleadoToolStripMenuItem, habitanteToolStripMenuItem });
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(101, 19);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // departamentoToolStripMenuItem
            // 
            departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            departamentoToolStripMenuItem.Size = new Size(180, 22);
            departamentoToolStripMenuItem.Text = "Departamentos";
            departamentoToolStripMenuItem.Click += departamentoToolStripMenuItem_Click;
            // 
            // mantenimientoToolStripMenuItem1
            // 
            mantenimientoToolStripMenuItem1.Name = "mantenimientoToolStripMenuItem1";
            mantenimientoToolStripMenuItem1.Size = new Size(180, 22);
            mantenimientoToolStripMenuItem1.Text = "Mantenimiento";
            mantenimientoToolStripMenuItem1.Click += mantenimientoToolStripMenuItem1_Click;
            // 
            // visitaToolStripMenuItem
            // 
            visitaToolStripMenuItem.Name = "visitaToolStripMenuItem";
            visitaToolStripMenuItem.Size = new Size(180, 22);
            visitaToolStripMenuItem.Text = "Visita";
            visitaToolStripMenuItem.Click += visitaToolStripMenuItem_Click;
            // 
            // empleadoToolStripMenuItem
            // 
            empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            empleadoToolStripMenuItem.Size = new Size(180, 22);
            empleadoToolStripMenuItem.Text = "Empleado";
            empleadoToolStripMenuItem.Click += empleadoToolStripMenuItem_Click;
            // 
            // habitanteToolStripMenuItem
            // 
            habitanteToolStripMenuItem.Name = "habitanteToolStripMenuItem";
            habitanteToolStripMenuItem.Size = new Size(180, 22);
            habitanteToolStripMenuItem.Text = "Habitante";
            habitanteToolStripMenuItem.Click += habitanteToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 19);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // descargarToolStripMenuItem
            // 
            descargarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadosToolStripMenuItem });
            descargarToolStripMenuItem.Name = "descargarToolStripMenuItem";
            descargarToolStripMenuItem.Size = new Size(71, 19);
            descargarToolStripMenuItem.Text = "Descargar";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUsuario, lblTiempo });
            statusStrip1.Location = new Point(0, 548);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1029, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.Black;
            lblUsuario.ForeColor = SystemColors.Window;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 17);
            lblUsuario.Text = "Usuario:";
            // 
            // lblTiempo
            // 
            lblTiempo.ForeColor = SystemColors.Window;
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(47, 17);
            lblTiempo.Text = "Tiempo";
            // 
            // listadosToolStripMenuItem
            // 
            listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            listadosToolStripMenuItem.Size = new Size(180, 22);
            listadosToolStripMenuItem.Text = "Listados";
            listadosToolStripMenuItem.Click += listadosToolStripMenuItem_Click;
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1029, 570);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "MDIPrincipal";
            Text = "Edifia - Simplifica tu gestión";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIPrincipal_FormClosing;
            FormClosed += MDIPrincipal_FormClosed;
            Load += MDIPrincipal_Load;
            Resize += MDIPrincipal_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUsuario;
        private ToolStripStatusLabel lblTiempo;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem departamentoToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem1;
        private ToolStripMenuItem visitaToolStripMenuItem;
        private ToolStripMenuItem empleadoToolStripMenuItem;
        private ToolStripMenuItem habitanteToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem descargarToolStripMenuItem;
        private ToolStripMenuItem listadosToolStripMenuItem;
    }
}