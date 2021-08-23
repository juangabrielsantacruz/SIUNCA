using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using Framework.D_2015.Persistencia;
using System.Windows.Forms;
using System.Collections;
using BIZ.DTOs;

namespace DAL
{
    public class DetPEDAO
    {
        public List<DTODetallesCorrPlan> TraerTodo(DTODetallesCorrPlan unPE)
        {
            List<DTODetallesCorrPlan> resultado = new List<DTODetallesCorrPlan>();
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("IdPlanDeEstudio", unPE.IdPlanDeEstudio));
                //resultado = unaConexion.EjecutarTupla<DetallesPlanDeEstudio>("SELECT MateriaConCorrelativas.Nombre, MateriaConCorrelativas.IdMateriaCC FROM MateriaConCorrelativas INNER JOIN DetallesPlanDeEstudio on DetallesPlanDeEstudio.IdMateriaCC = MateriaConCorrelativas.IdMateriaCC AND DetallesPlanDeEstudio.IdPlanDeEstudio = (@IdPlanDeEstudio)", listaParametrosCD);
                resultado = unaConexion.EjecutarTupla<DTODetallesCorrPlan>("SELECT MCC.Nombre, MCC.IdMateriaCC, IdPlanDetalles FROM MateriaConCorrelativas as MCC INNER JOIN DetallesPlanDeEstudio as DPE ON DPE.IdMateriaCC = MCC.IdMateriaCC INNER JOIN PlanDeEstudio as PE ON PE.IdPlanDeEstudio = DPE.IdPlanDeEstudio WHERE PE.IdPlanDeEstudio = (@IdPlanDeEstudio)", listaParametrosCD);
            }
            catch (Exception ex)
            {
                //MsgBox("error al traer correlativas");
                MessageBox.Show("error al traer Detalles PE", ex.ToString());
                //return null;
                //throw;
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
            return resultado;
        }
    }
}
