using System;
using System.Collections.Generic;
using BIZ;
using Framework.D_2015.Persistencia;
using System.Windows.Forms;

namespace DAL
{
    public class DetalleCorrelativaDAO
    {
       public List<DetallesCorrelativa> TraerTodo(MateriaConCorrelativas unaMateriaCC)
        {
            List<DetallesCorrelativa> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("IdMateriaCC", unaMateriaCC.IdMateriaCC));
                resultado = unaConexion.EjecutarTupla<DetallesCorrelativa>("SELECT NombreMateria, NombreMateriaCC FROM DetallesCorrelativa where IdMateriaCC = (@IdMateriaCC)", listaParametrosCD);
                return resultado;
            }
            catch (Exception ex)
            {
                //MsgBox("error al traer correlativas");
                MessageBox.Show("error al traer correlativas de la materia seleccionada", ex.ToString());
                return null;
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }
    }
}