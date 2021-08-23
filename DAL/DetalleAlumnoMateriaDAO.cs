using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using Framework.D_2015.Persistencia;
using System.Windows.Forms;

namespace DAL
{
    public class DetalleAlumnoMateriaDAO
    {
        public List<Alumno_MateriaCC> TraerTodo(Alumno unAlumno)
        {
            List<Alumno_MateriaCC> resultado = new List<Alumno_MateriaCC>();
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("LegajoAlumno", unAlumno.LegajoAlumno));
                resultado = unaConexion.EjecutarTupla<Alumno_MateriaCC>("SELECT MateriaConCorrelativas.Nombre, Estado FROM MateriaConCorrelativas INNER JOIN Alumno_MateriaCC on Alumno_MateriaCC.IdMateriaCC = MateriaConCorrelativas.IdMateriaCC INNER JOIN Alumno on Alumno.LegajoAlumno = Alumno_MateriaCC.LegajoAlumno WHERE Estado = 'Aprobado' or Estado = 'Cursando' AND Alumno.LegajoAlumno = (@LegajoAlumno)", listaParametrosCD);
                
            }
            catch (Exception ex)
            {
                //MsgBox("error al traer correlativas");
                MessageBox.Show("error al traer aprobadas", ex.ToString());
                //return null;
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
            return resultado;
        }
    }
}
