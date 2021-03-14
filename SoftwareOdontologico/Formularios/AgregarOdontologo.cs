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
        Odontologo odont;
        string nroMat;
        public AgregarOdontologo()
        {
            InitializeComponent();
            odontologosRepo = new OdontologosRepo();

        }
        // constructor que recibe la matricula para modificar dicho odontologo
        // con el numero de matricula consulto la base datos y obtengo el odontologo
        public AgregarOdontologo(string matricula)
        {
            InitializeComponent(); 
            odontologosRepo = new OdontologosRepo();
            odont = odontologosRepo.ObtenerOdontMatricula(matricula);
            nroMat = matricula;
            RellenarFormEditable();
        }

       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            
        }
        public void RellenarFormEditable()
        {
            txtMatricula.Text = odont.nroMatricula.ToString();
            txtDocumento.Text = odont.nroDocumento.ToString();
            txtNombre.Text = odont.nombre;
            txtApellido.Text = odont.apellido;
            txtDomicilio.Text = odont.domicilio;
            dtpFechaNacimiento.Text = odont.fechaNacimiento.ToString();
          
        }
        //Limpiar campos del formulario 
        private void LimpiarCampos()
        {
            txtApellido.Clear();
            txtDomicilio.Clear();
            txtNombre.Clear();
            txtDocumento.Clear();
            txtMatricula.Clear();
            dtpFechaNacimiento.ResetText();


        }
        //Agregar odontologo
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var odontologo = new Odontologo();

            odontologo.nombre = txtNombre.Text;
            odontologo.apellido = txtApellido.Text;
            odontologo.domicilio = txtDomicilio.Text;
            odontologo.fechaNacimiento = dtpFechaNacimiento.Value;

            if (!odontologo.ValidarNumero(txtMatricula.Text.ToString()))
            {
                
                MessageBox.Show("Ingrese correctamente el numero de la Matricula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {odontologo.nroMatricula = long.Parse(txtMatricula.Text); }
           

            if (!odontologo.ValidarNumero(txtDocumento.Text.ToString()))
            {
                MessageBox.Show("Ingrese correctamente el numero de la Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            odontologo.nroDocumento = long.Parse(txtDocumento.Text);
           
    

            if (!odontologo.NombreValido())
            {
                MessageBox.Show("El nombre ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!odontologo.ApellidoInvalido())
            {
                MessageBox.Show("El apellido ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!odontologo.DomicilioInvalido())
            {
                MessageBox.Show("El domicilio ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!odontologo.FechaInvalida(dtpFechaNacimiento.Value))
            {
                MessageBox.Show("La fecha Ingresada tiene que ser 24 años menor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (odontologosRepo.Validar(odontologo.nroMatricula.ToString()))
            {
                if (odontologosRepo.Guardar(odontologo))
                {
                  
                    MessageBox.Show("Odontologo Registrado con exito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            //verifico que a la hora de modificar un odontologo el numero de matricula
            //no es el mismo elimino el anterior odontologo registrado
            //if (nroMat != txtMatricula.Text)
            //{
            //     odontologosRepo.Eliminar(nroMat);
            //}
            else
            {
                
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
