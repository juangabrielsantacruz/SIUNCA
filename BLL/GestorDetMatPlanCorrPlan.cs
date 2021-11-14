using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;
using BIZ.DTOs;
using BIZ.GestionPlanes;

namespace BLL
{
    public class GestorDetMatPlanCorrPlan
    {
        
        static public void CrearDetMatPlanCorrPlan(DTODetallesCorrPlan unDTODMPCP, List<DTODetallesCorrPlan> DetallesMPCP)
        {
            // If CorrelativasDetalles.Exists Then
            // End If

            GuardarCorrelativas(unDTODMPCP, DetallesMPCP);
        }

        static private void GuardarCorrelativas(DTODetallesCorrPlan unDTODMPCP, List<DTODetallesCorrPlan> DetallesMPCP)
        {
            DetMatPlanCorrPlanDAO UnaMateriaCCDAO = new DetMatPlanCorrPlanDAO();
            UnaMateriaCCDAO.Insertar(unDTODMPCP, DetallesMPCP);
        }

        public void GuardarCorrelativas2(DetallesPlan unDetalle, List<DetallesDetallePlan> listaDetalles)
        {
            DetMatPlanCorrPlanDAO UnaMateriaCCDAO = new DetMatPlanCorrPlanDAO();
            UnaMateriaCCDAO.Insertar2(unDetalle, listaDetalles);
        }

        public List<DTODetallesCorrPlan> TraerListaCorrelativas(DTODetallesCorrPlan unDTO)
        {
            List<DTODetallesCorrPlan> ListaCorrelativas = new List<DTODetallesCorrPlan>();
            DetMatPlanCorrPlanDAO unDetalleCorrelativaDAO = new DetMatPlanCorrPlanDAO();
            ListaCorrelativas = unDetalleCorrelativaDAO.TraerTodo(unDTO);

            //comentando
            return ListaCorrelativas;
        }



    }
}
