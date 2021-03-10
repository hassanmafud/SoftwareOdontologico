namespace SoftwareOdontologico
{
    partial class Agenda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOdontologo = new System.Windows.Forms.Label();
            this.cmbOdontologos = new System.Windows.Forms.ComboBox();
            this.lbldefinicion = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mañanaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mañanaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tardeInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tardeFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblseleccione = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.btnGenerarAgenda = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOdontologo
            // 
            this.lblOdontologo.AutoSize = true;
            this.lblOdontologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdontologo.Location = new System.Drawing.Point(12, 28);
            this.lblOdontologo.Name = "lblOdontologo";
            this.lblOdontologo.Size = new System.Drawing.Size(92, 20);
            this.lblOdontologo.TabIndex = 0;
            this.lblOdontologo.Text = "Odontologo";
            // 
            // cmbOdontologos
            // 
            this.cmbOdontologos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdontologos.FormattingEnabled = true;
            this.cmbOdontologos.Location = new System.Drawing.Point(133, 27);
            this.cmbOdontologos.Name = "cmbOdontologos";
            this.cmbOdontologos.Size = new System.Drawing.Size(189, 21);
            this.cmbOdontologos.TabIndex = 1;
            // 
            // lbldefinicion
            // 
            this.lbldefinicion.AutoSize = true;
            this.lbldefinicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldefinicion.Location = new System.Drawing.Point(12, 75);
            this.lbldefinicion.Name = "lbldefinicion";
            this.lbldefinicion.Size = new System.Drawing.Size(367, 20);
            this.lbldefinicion.TabIndex = 2;
            this.lbldefinicion.Text = "Definicion de Horarios para Agenda Mensual";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(12, 117);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(229, 20);
            this.lblDuracion.TabIndex = 3;
            this.lblDuracion.Text = "Duracion del Turno: 30 minutos";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.mañanaInicio,
            this.mañanaFin,
            this.tardeInicio,
            this.tardeFin});
            this.dataGridView2.Location = new System.Drawing.Point(16, 159);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(543, 146);
            this.dataGridView2.TabIndex = 5;
            // 
            // dia
            // 
            this.dia.HeaderText = "Dia de la Semana";
            this.dia.Name = "dia";
            // 
            // mañanaInicio
            // 
            this.mañanaInicio.HeaderText = "Mañana Inicio";
            this.mañanaInicio.Name = "mañanaInicio";
            // 
            // mañanaFin
            // 
            this.mañanaFin.HeaderText = "Mañana Fin";
            this.mañanaFin.Name = "mañanaFin";
            // 
            // tardeInicio
            // 
            this.tardeInicio.HeaderText = "Tarde Inicio";
            this.tardeInicio.Name = "tardeInicio";
            // 
            // tardeFin
            // 
            this.tardeFin.HeaderText = "Tarde Fin";
            this.tardeFin.Name = "tardeFin";
            // 
            // lblseleccione
            // 
            this.lblseleccione.AutoSize = true;
            this.lblseleccione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseleccione.Location = new System.Drawing.Point(12, 335);
            this.lblseleccione.Name = "lblseleccione";
            this.lblseleccione.Size = new System.Drawing.Size(405, 20);
            this.lblseleccione.TabIndex = 6;
            this.lblseleccione.Text = "Seleccione el mes para el que desea generar la  agenda";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(12, 373);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(43, 20);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mes:";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(61, 372);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(119, 21);
            this.cmbMes.TabIndex = 8;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(242, 373);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(42, 20);
            this.lblAño.TabIndex = 9;
            this.lblAño.Text = "Año:";
            // 
            // cmbAño
            // 
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(290, 372);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(89, 21);
            this.cmbAño.TabIndex = 10;
            // 
            // btnGenerarAgenda
            // 
            this.btnGenerarAgenda.Location = new System.Drawing.Point(485, 426);
            this.btnGenerarAgenda.Name = "btnGenerarAgenda";
            this.btnGenerarAgenda.Size = new System.Drawing.Size(126, 22);
            this.btnGenerarAgenda.TabIndex = 11;
            this.btnGenerarAgenda.Text = "Generar Agenda";
            this.btnGenerarAgenda.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(634, 426);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 22);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(610, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(684, 9);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(73, 20);
            this.txtUsuario.TabIndex = 14;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(610, 40);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 20);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(674, 40);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 16;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerarAgenda);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblseleccione);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lbldefinicion);
            this.Controls.Add(this.cmbOdontologos);
            this.Controls.Add(this.lblOdontologo);
            this.Name = "Agenda";
            this.Text = "Software Odontologico";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdontologo;
        private System.Windows.Forms.ComboBox cmbOdontologos;
        private System.Windows.Forms.Label lbldefinicion;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblseleccione;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn mañanaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mañanaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tardeInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tardeFin;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.Button btnGenerarAgenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
    }
}

