using BIZ.Seguridad;
using Framework.D_2015.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAOSeguridad
{
    public class TipoBitacoraDAO
    {
        public List<TipoBitacora> TraerTodo()
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<TipoBitacora> resultado = new List<TipoBitacora>();

            try
            {
                unaConexion.ConexionIniciar();
                resultado = unaConexion.EjecutarTupla<TipoBitacora>("select IdTipoBitacora, Descripcion from TipoBitacora", new List<Parametro>());
            }
            catch (Exception ex)
            {
                //Interaction.MsgBox(ex.Message.ToString());
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
            return resultado;
        }

    }
}
