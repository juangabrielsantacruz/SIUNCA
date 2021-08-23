using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.D_2015.Persistencia;
using BIZ;

namespace DAL
{
    public class AsistenciaDAO
    {
        public void guardarTodo(List<Asistencia> listadoAsistencia)
        {
            var conexion = new Conexion("config.xml");

            try
            {
                conexion.ConexionIniciar();
                conexion.TransaccionIniciar();

    
                foreach (var item in listadoAsistencia)
                {
                    var parametros = new List<Parametro>();

                    parametros.Add(new Parametro("Ausente", item.Ausente.ToString()));
                    parametros.Add(new Parametro("Presente", item.Presente.ToString()));
                    parametros.Add(new Parametro("Fecha", item.Fecha));
                    parametros.Add(new Parametro("IdMateriaCC", item.IdMateriaCC));
                    parametros.Add(new Parametro("LegajoAlumno", item.LegajoAlumno));

                    conexion.EjecutarSinResultado("INSERT INTO Asistencia (Ausente, Presente, Fecha, IdMateriaCC, LegajoAlumno) VALUES (@Ausente, @Presente, @Fecha, @IdMateriaCC, @LegajoAlumno)", parametros);
                }

                conexion.TransaccionAceptar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en AsistenciaDAO" + ex.Data);
                conexion.TransaccionCancelar();
            }
            finally
            {
                conexion.ConexionFinalizar();
            }

        }
    }
}
