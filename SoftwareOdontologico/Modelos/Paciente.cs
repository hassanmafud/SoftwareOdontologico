using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOdontologico.Modelos
{
    class Paciente
    {
        public long nroPaciente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string domicilio { get; set; }
        
        public long nroDocumento { get; set; }
        public DateTime fechaNacimiento { get; set; }

    }
}
