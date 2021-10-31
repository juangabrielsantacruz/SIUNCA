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
    public class GestorPlanDeEstudio
    {
        public void CrearPlanDeEstudio(PlanDeEstudio2 unPlanDeEstudio, List<DetallesPlanDeEstudio> PEDetalles)
        {
            // If
            // End If

            GuardarPlanDeEstudio(unPlanDeEstudio, PEDetalles);
        }

        private void GuardarPlanDeEstudio(PlanDeEstudio2 unPlanDeEstudio, List<DetallesPlanDeEstudio> PEDetalles)
        {
            PlanDeEstudioDAO UnPEDAO = new PlanDeEstudioDAO();
            UnPEDAO.Insertar(unPlanDeEstudio, PEDetalles);
        }

        public List<DTODetallesCorrPlan> TraerListaPlanes()
        {
            List<DTODetallesCorrPlan> ListaPlanes = new List<DTODetallesCorrPlan>();
            PlanDeEstudioDAO unPlanDAO = new PlanDeEstudioDAO();
            ListaPlanes = unPlanDAO.TraerTodo();

            return ListaPlanes;
        }

        public List<DTODetallesCorrPlan> TraerListaPlanes(Alumno UnAlumno, Carrera unaCarrera)
        {
            List<DTODetallesCorrPlan> ListaCarrera = new List<DTODetallesCorrPlan>();
            PlanDeEstudioDAO unaCarreraDAO = new PlanDeEstudioDAO();
            ListaCarrera = unaCarreraDAO.TraerTodo(UnAlumno, unaCarrera);
            return ListaCarrera;
        }

        public void Modificar(DTODetallesCorrPlan unDTODMPCP)
        {
            PlanDeEstudioDAO unPEDAO = new PlanDeEstudioDAO();
            unPEDAO.Modificar(unDTODMPCP);
        }
    }
}
