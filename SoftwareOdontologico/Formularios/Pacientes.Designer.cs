namespace SoftwareOdontologico.Formularios
{
    partial class Pacientes
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
            this.lblPacientes = new System.Windows.Forms.Label();
            this.lblOdontologo = new System.Windows.Forms.Label();
            this.cmbOdontologo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gboxOdontologo = new System.Windows.Forms.GroupBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.nroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNaciemiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odontologo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gboxOdontologo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPacientes.Location = new System.Drawing.Point(36, 27);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(173, 24);
            this.lblPacientes.TabIndex = 2;
            this.lblPacientes.Text = "Listado Pacientes";
            // 
            // lblOdontologo
            // 
            this.lblOdontologo.AutoSize = true;
            this.lblOdontologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdontologo.Location = new System.Drawing.Point(16, 29);
            this.lblOdontologo.Name = "lblOdontologo";
            this.lblOdontologo.Size = new System.Drawing.Size(85, 15);
            this.lblOdontologo.TabIndex = 0;
            this.lblOdontologo.Text = "Odontologo:";
            // 
            // cmbOdontologo
            // 
            this.cmbOdontologo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdontologo.FormattingEnabled = true;
            this.cmbOdontologo.Location = new System.Drawing.Point(121, 27);
            this.cmbOdontologo.Name = "cmbOdontologo";
            this.cmbOdontologo.Size = new System.Drawing.Size(121, 21);
            this.cmbOdontologo.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(66, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gboxOdontologo
            // 
            this.gboxOdontologo.Controls.Add(this.btnBuscar);
            this.gboxOdontologo.Controls.Add(this.lblOdontologo);
            this.gboxOdontologo.Controls.Add(this.cmbOdontologo);
            this.gboxOdontologo.Location = new System.Drawing.Point(40, 68);
            this.gboxOdontologo.Name = "gboxOdontologo";
            this.gboxOdontologo.Size = new System.Drawing.Size(281, 84);
            this.gboxOdontologo.TabIndex = 5;
            this.gboxOdontologo.TabStop = false;
            this.gboxOdontologo.Text = "Seleccion Odontologo";
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroDocumento,
            this.nombre,
            this.apellido,
            this.domicilio,
            this.fechaNaciemiento,
            this.obraSocial,
            this.plan,
            this.odontologo});
            this.dgvPacientes.Location = new System.Drawing.Point(12, 158);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(673, 203);
            this.dgvPacientes.TabIndex = 6;
            // 
            // nroDocumento
            // 
            this.nroDocumento.HeaderText = "Documento";
            this.nroDocumento.Name = "nroDocumento";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            // 
            // fechaNaciemiento
            // 
            this.fechaNaciemiento.HeaderText = "Fecha de Naciemiento";
            this.fechaNaciemiento.Name = "fechaNaciemiento";
            // 
            // obraSocial
            // 
            this.obraSocial.HeaderText = "Obra Social";
            this.obraSocial.Name = "obraSocial";
            // 
            // plan
            // 
            this.plan.HeaderText = "Plan";
            this.plan.Name = "plan";
            // 
            // odontologo
            // 
            this.odontologo.HeaderText = "Odontologo";
            this.odontologo.Name = "odontologo";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(638, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(379, 393);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(501, 393);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.gboxOdontologo);
            this.Controls.Add(this.lblPacientes);
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            this.gboxOdontologo.ResumeLayout(false);
            this.gboxOdontologo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.Label lblOdontologo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbOdontologo;
        private System.Windows.Forms.GroupBox gboxOdontologo;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNaciemiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn obraSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn odontologo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}