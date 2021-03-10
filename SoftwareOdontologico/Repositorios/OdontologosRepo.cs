using SoftwareOdontologico.Base_de_Datos;
using SoftwareOdontologico.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOdontologico.Repositorios
{
    class OdontologosRepo
    {
        private Consultorio_BD _BD;

        public OdontologosRepo()
        {
            _BD = new Consultorio_BD();
        }

        public bool Guardar(Odontologo odontologo)
        {
            string sqltxt = $" INSERT Odontologos ([nroDocumento]," +
                "[nombre],[apellido],[domicilio],[fechaNacimiento],[nroMatricula])" +
                $"VALUES ('{odontologo.nroDocumento}','{odontologo.nombre}','{odontologo.apellido}'," +
                $"'{odontologo.domicilio}','{odontologo.fechaNacimiento.ToString("yyyy-MM-dd")}','{odontologo.nroMatricula}')";

            return _BD.EjecutarSQL(sqltxt);
        }
        public bool Validar(string matricula)
        {
            string sqltxt = $"SELECT nroMatricula FROM Odontologos WHERE nroMatricula = {matricula}";
            var tabla = _BD.consulta(sqltxt);
            var resultado = tabla.Rows.Count;
            if (resultado > 0) return false;
            return true;
            
        }

         public bool Actualizar(Odontologo odontologo,  string matricula)
         {
            string sqltxt = $"UPDATE [dbo].[Odontologos] SET nroDocumento = '{odontologo.nroDocumento}' , nombre = '{odontologo.nombre}'," +
                $" apellido = '{odontologo.apellido}' , domicilio ='{odontologo.domicilio}'," +
                $" fechaNacimiento = '{odontologo.fechaNacimiento.ToString("yyyy-MM-dd")}' WHERE nroMatricula = {matricula} ";

            return _BD.EjecutarSQL(sqltxt);
         }

        public DataTable ObtenerOdontologosDT()
        {
            string sqltxt = "SELECT * FROM Odontologos";
            var dtablaOdontologos = _BD.consulta(sqltxt);
            return dtablaOdontologos;
        }
        
        public bool Eliminar(string matricula)
        {
            string sqltxt = $"DELETE FROM Odontologos where nroMatricula = {matricula}";
            return _BD.EjecutarSQL(sqltxt);
        }
       
    }
}
