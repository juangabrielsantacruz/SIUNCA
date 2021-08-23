using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using Framework.D_2015.Persistencia;
using System.Windows.Forms;
using BIZ.DTOs;


namespace DAL
{
    public class DetMatPlanCorrPlanDAO
    {
        public void Insertar(DTODetallesCorrPlan unDTODMPCP, List<DTODetallesCorrPlan> DTODetallesMPCP)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaDeParametros = new List<Parametro>();
            listaDeParametros.Add(new Parametro("IdPlanDetalles", unDTODMPCP.IdPlanDetalles));
            listaDeParametros.Add(new Parametro("IdPlanDetalles2", unDTODMPCP.IdPlanDetalles2));
            

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();
                //unaConexion.EjecutarSinResultado("INSERT INTO DetallesDetMatPlanCorrPlan (IdPlanDetalles, IdPlanDetalles2) VALUES (@IdPlanDetalles, @IdPlanDetalles2)", listaDeParametros);

                //int IdDetallesDetMatPlanCorrPlan = unaConexion.EjecutarEscalar<int>("SELECT MAX(IdDetallesDetMatPlanCorrPlan) FROM DetallesDetMatPlanCorrPlan", new List<Parametro>());


                foreach (var item in DTODetallesMPCP)
                {
                    List<Parametro> listaParametrosCD = new List<Parametro>();

                    //listaParametrosCD.Add(new Parametro("IdDetallesDetMatPlanCorrPlan", IdDetallesDetMatPlanCorrPlan));
                    listaParametrosCD.Add(new Parametro("IdPlanDetalles", item.IdPlanDetalles));
                    listaParametrosCD.Add(new Parametro("IdPlanDetalles2", item.IdPlanDetalles2));

                    //item.IdDetallesDetMatPlanCorrPlan = IdDetallesDetMatPlanCorrPlan;

                    unaConexion.EjecutarSinResultado("INSERT INTO DetallesDetMatPlanCorrPlan (IdPlanDetalles, IdPlanDetalles2) VALUES (@IdPlanDetalles, @IdPlanDetalles2)", listaParametrosCD);
                }

                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                // EventViewer.RegistrarError("VB", "SQL", "ERROR AL PRODUCIR TRANSACCION", EventViewer.TipoEvento._Error)
                MessageBox.Show("error guardando MPCP");
                throw ;
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }

        public List<DTODetallesCorrPlan> TraerTodo(DTODetallesCorrPlan unDTO)
        {
            List<DTODetallesCorrPlan> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("IdPlanDetalles2", unDTO.IdPlanDetalles2));
                listaParametrosCD.Add(new Parametro("IdPlanDeEstudio", unDTO.IdPlanDeEstudio));
                resultado = unaConexion.EjecutarTupla<DTODetallesCorrPlan>("select mcc.Nombre, dmpcp.IdPlanDetalles, IdPlanDetalles2, pe.IdPlanDeEstudio, pe.Nombre as NombrePlan from MateriaConCorrelativas mcc inner join DetallesPlanDeEstudio dpe on mcc.IdMateriaCC = dpe.IdMateriaCC inner join PlanDeEstudio pe on dpe.IdPlanDeEstudio = pe.IdPlanDeEstudio inner join DetallesDetMatPlanCorrPlan dmpcp on dpe.IdPlanDetalles = dmpcp.IdPlanDetalles where dmpcp.IdPlanDetalles2 = (@IdPlanDetalles2) and dpe.IdPlanDeEstudio = (@IdPlanDeEstudio)", listaParametrosCD);
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
