namespace SoftwareOdontologico.Formularios
{
    partial class Odontologos
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
            this.dgvOdontologos = new System.Windows.Forms.DataGridView();
            this.lblOdontologos = new System.Windows.Forms.Label();
            this.nroMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNaciemiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdontologos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdontologos
            // 
            this.dgvOdontologos.AllowUserToAddRows = false;
            this.dgvOdontologos.AllowUserToDeleteRows = false;
            this.dgvOdontologos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdontologos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroMatricula,
            this.nroDocumento,
            this.nombre,
            this.apellido,
            this.domicilio,
            this.fechaNaciemiento});
            this.dgvOdontologos.Location = new System.Drawing.Point(25, 71);
            this.dgvOdontologos.Name = "dgvOdontologos";
            this.dgvOdontologos.ReadOnly = true;
            this.dgvOdontologos.Size = new System.Drawing.Size(744, 238);
            this.dgvOdontologos.TabIndex = 0;
            // 
            // lblOdontologos
            // 
            this.lblOdontologos.AutoSize = true;
            this.lblOdontologos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblOdontologos.Location = new System.Drawing.Point(45, 32);
            this.lblOdontologos.Name = "lblOdontologos";
            this.lblOdontologos.Size = new System.Drawing.Size(130, 24);
            this.lblOdontologos.TabIndex = 1;
            this.lblOdontologos.Text = "Odontologos";
            // 
            // nroMatricula
            // 
            this.nroMatricula.HeaderText = "Matricula";
            this.nroMatricula.Name = "nroMatricula";
            this.nroMatricula.ReadOnly = true;
            // 
            // nroDocumento
            // 
            this.nroDocumento.HeaderText = "Documento";
            this.nroDocumento.Name = "nroDocumento";
            this.nroDocumento.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            this.domicilio.Width = 150;
            // 
            // fechaNaciemiento
            // 
            this.fechaNaciemiento.HeaderText = "Fecha Nacimiento";
            this.fechaNaciemiento.Name = "fechaNaciemiento";
            this.fechaNaciemiento.ReadOnly = true;
            this.fechaNaciemiento.Width = 150;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(417, 345);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(553, 345);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(679, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Odontologos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblOdontologos);
            this.Controls.Add(this.dgvOdontologos);
            this.Name = "Odontologos";
            this.Text = "Odontologos";
            this.Load += new System.EventHandler(this.Odontologos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdontologos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdontologos;
        private System.Windows.Forms.Label lblOdontologos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNaciemiento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
    }
}