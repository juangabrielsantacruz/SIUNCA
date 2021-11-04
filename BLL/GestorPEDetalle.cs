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
    public class GestorPEDetalle
    {
        public List<DTODetallesCorrPlan> TraerListaPEDetalles(DTODetallesCorrPlan unPE)
        {
            List<DTODetallesCorrPlan> ListaPEdet = new List<DTODetallesCorrPlan>();
            DetPEDAO unDETPEDAO = new DetPEDAO();
            ListaPEdet = unDETPEDAO.TraerTodo(unPE);

            //comentando
            return ListaPEdet;
        }
        public List<DetallesPlan> TraerListaPEDetallesBien(PlanDeEstudio unPE)
        {
            List<DetallesPlan> ListaPEdet = new List<DetallesPlan>();
            DetPEDAO unDETPEDAO = new DetPEDAO();
            ListaPEdet = unDETPEDAO.TraerTodoBien(unPE);

            //comentando
            return ListaPEdet;
        }
    }
     
}
