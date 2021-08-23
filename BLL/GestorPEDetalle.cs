using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;
using BIZ.DTOs;

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
    }
     
}
