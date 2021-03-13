using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOdontologico.Modelos
{
    class Paciente
    {
        public long nroDocumento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string domicilio { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string obraSocial { get; set; }
        public string plan { get; set; }
        public long odontologo { get; set; }

        public bool NombreValido()
        {
            if (!string.IsNullOrEmpty(nombre) && nombre.Length < 40)
                return true;
            return false;

        }
        public bool ApellidoInvalido()
        {
            if (!string.IsNullOrEmpty(apellido) && apellido.Length < 40)
                return true;
            return false;

        }
        public bool DomicilioInvalido()
        {
            if (!string.IsNullOrEmpty(domicilio) && domicilio.Length < 40)
                return true;
            return false;

        }

        public bool ObraSocialInvalida()
        {
            if (!string.IsNullOrEmpty(obraSocial) && obraSocial.Length < 45)
                return true;
            return false;

        }
        public bool PlanInvalido()
        {
            if (!string.IsNullOrEmpty(plan) && plan.Length < 20)
                return true;
            return false;

        }
        public bool FechaInvalida(DateTime fecha)
        {
            if (fecha <= DateTime.Today)
            {
                return true;
            }
            return false;
        }

        public bool ValidarNumero(string documento)
        {
            //Controlamos que el numero ingresado sea long y no contenga letras, ni caracteres.
            if (long.TryParse(documento, out long resultado)) { return true; }
            return false;

        }
    }
}
