namespace SoftwareOdontologico.Formularios
{
    partial class MenuSoftware
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSoftware));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.msMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.odontologosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarModificarOdontologoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOdontologoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarModificarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarModificarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // msMenuPrincipal
            // 
            this.msMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odontologosToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.agendaToolStripMenuItem});
            this.msMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msMenuPrincipal.Name = "msMenuPrincipal";
            this.msMenuPrincipal.Size = new System.Drawing.Size(813, 24);
            this.msMenuPrincipal.TabIndex = 1;
            this.msMenuPrincipal.Text = "MenuPrincipal";
            // 
            // odontologosToolStripMenuItem
            // 
            this.odontologosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarModificarOdontologoToolStripMenuItem,
            this.consultarOdontologoToolStripMenuItem});
            this.odontologosToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odontologosToolStripMenuItem.Name = "odontologosToolStripMenuItem";
            this.odontologosToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.odontologosToolStripMenuItem.Text = "Odontologos";
            // 
            // agregarModificarOdontologoToolStripMenuItem
            // 
            this.agregarModificarOdontologoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.agregarModificarOdontologoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarModificarOdontologoToolStripMenuItem.Image")));
            this.agregarModificarOdontologoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.agregarModificarOdontologoToolStripMenuItem.Name = "agregarModificarOdontologoToolStripMenuItem";
            this.agregarModificarOdontologoToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.agregarModificarOdontologoToolStripMenuItem.Text = "Agregar / Modificar Odontologo";
            this.agregarModificarOdontologoToolStripMenuItem.Click += new System.EventHandler(this.AgregarModificarOdont);
            // 
            // consultarOdontologoToolStripMenuItem
            // 
            this.consultarOdontologoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.consultarOdontologoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarOdontologoToolStripMenuItem.Image")));
            this.consultarOdontologoToolStripMenuItem.Name = "consultarOdontologoToolStripMenuItem";
            this.consultarOdontologoToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.consultarOdontologoToolStripMenuItem.Text = "Consultar Odontologos";
            this.consultarOdontologoToolStripMenuItem.Click += new System.EventHandler(this.ConsultarOdontologos);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarModificarPacienteToolStripMenuItem,
            this.consultarPacientesToolStripMenuItem});
            this.pacientesToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 9.75F);
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // agregarModificarPacienteToolStripMenuItem
            // 
            this.agregarModificarPacienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.agregarModificarPacienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarModificarPacienteToolStripMenuItem.Image")));
            this.agregarModificarPacienteToolStripMenuItem.Name = "agregarModificarPacienteToolStripMenuItem";
            this.agregarModificarPacienteToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.agregarModificarPacienteToolStripMenuItem.Text = "Agregar / Modificar Paciente";
            this.agregarModificarPacienteToolStripMenuItem.Click += new System.EventHandler(this.AgregarModificarPacientes);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarModificarTurnoToolStripMenuItem,
            this.consultarTurnosToolStripMenuItem});
            this.agendaToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 9.75F);
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // agregarModificarTurnoToolStripMenuItem
            // 
            this.agregarModificarTurnoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.agregarModificarTurnoToolStripMenuItem.Name = "agregarModificarTurnoToolStripMenuItem";
            this.agregarModificarTurnoToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.agregarModificarTurnoToolStripMenuItem.Text = "Agregar / Modificar Turno";
            this.agregarModificarTurnoToolStripMenuItem.Click += new System.EventHandler(this.AgregarModificarTurnos);
            // 
            // consultarTurnosToolStripMenuItem
            // 
            this.consultarTurnosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.consultarTurnosToolStripMenuItem.Name = "consultarTurnosToolStripMenuItem";
            this.consultarTurnosToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.consultarTurnosToolStripMenuItem.Text = "Consultar Turnos";
            // 
            // consultarPacientesToolStripMenuItem
            // 
            this.consultarPacientesToolStripMenuItem.Name = "consultarPacientesToolStripMenuItem";
            this.consultarPacientesToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.consultarPacientesToolStripMenuItem.Text = "Consultar Pacientes";
            this.consultarPacientesToolStripMenuItem.Click += new System.EventHandler(this.ConsultarPacientes);
            // 
            // MenuSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 505);
            this.Controls.Add(this.msMenuPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.msMenuPrincipal;
            this.Name = "MenuSoftware";
            this.Text = "Menu Software Odontologico";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.msMenuPrincipal.ResumeLayout(false);
            this.msMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip msMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem odontologosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarModificarOdontologoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarModificarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarModificarTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarOdontologoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPacientesToolStripMenuItem;
    }
}