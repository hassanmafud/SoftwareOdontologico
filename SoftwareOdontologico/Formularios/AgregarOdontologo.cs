using SoftwareOdontologico.Modelos;
using SoftwareOdontologico.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareOdontologico.Formularios
{
    public partial class AgregarOdontologo : Form
    {
        OdontologosRepo odontologosRepo;
        public AgregarOdontologo()
        {
            InitializeComponent();
            odontologosRepo = new OdontologosRepo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtApellido.Clear();
            txtDomicilio.Clear();
            txtNombre.Clear();
            txtDocumento.Clear();
            txtMatricula.Clear();
            dtpFechaNacimiento.ResetText();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var odontologo = new Odontologo();

            odontologo.nombre = txtNombre.Text;
            odontologo.apellido = txtApellido.Text;
            odontologo.domicilio = txtDomicilio.Text;
            odontologo.fechaNacimiento = dtpFechaNacimiento.Value;

            if (!odontologo.ValidarNumero(txtMatricula.Text.ToString()))
            {
                MessageBox.Show("Ingrese correctamente el numero de la Matricula");
                return;
            }
            else {odontologo.nroMatricula = long.Parse(txtMatricula.Text); }

           

            if (!odontologo.ValidarNumero(txtDocumento.Text.ToString()))
            {
                MessageBox.Show("Ingrese correctamente el numero de Documento");
                return;
            }
            odontologo.nroDocumento = long.Parse(txtDocumento.Text);
            
            if (!odontologo.NombreValido())
            {
                MessageBox.Show("El nombre Ingresado no valido");
                return;
            }
            if (!odontologo.ApellidoInvalido())
            {
                MessageBox.Show("El apellido Ingresado no valido");
                return;
            }

            if (odontologosRepo.Validar(odontologo.nroMatricula.ToString()))
            {
                if (odontologosRepo.Guardar(odontologo))
                {
                    MessageBox.Show("Odontologo Registrado con exito");
                    LimpiarCampos();
                }
            }
            else {
                //MessageBox requiere 4 parametros.
                string mensajePrincipal = "El Odontologo ya se encuentra registrado";
                string mensaje = "Desea Modificar los Datos";
                var result = MessageBox.Show(mensaje, mensajePrincipal, MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    if (odontologosRepo.Actualizar(odontologo , odontologo.nroMatricula.ToString())) 
                    { MessageBox.Show("Datos Actualizados con Exito"); }
                }

                LimpiarCampos();
            }

        }
    }
}
