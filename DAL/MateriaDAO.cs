using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using Framework.D_2015.Persistencia;
using System.Windows.Forms;
using System.Collections;

namespace DAL
{
    public class MateriaDAO
    {
        public List<Materia> TraerTodo()
        {
            List<Materia> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            //var unaConexion = new ProveedorSql();
            unaConexion.ConexionIniciar();
            try
            {
                resultado = unaConexion.EjecutarTupla<Materia>("SELECT IdMateria, Nombre FROM Materia", new List<Parametro>());
                return resultado;
            }
            catch (Exception ex)
            {
                // Dim log As New EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error)
                // Interaction.MsgBox(" error traer materias.");
                MessageBox.Show("error al traer materias");
                return null;
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }
        public void Eliminar(object Materia)
        {
        }
        public void Modificar(object Materia)
        {
        }
    }

}
