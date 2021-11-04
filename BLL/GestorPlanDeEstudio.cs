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
    public class GestorPlanDeEstudio
    {
        public void CrearPlanDeEstudio2(PlanDeEstudio2 unPlanDeEstudio, List<DetallesPlanDeEstudio> PEDetalles)
        {
            // If
            // End If

            GuardarPlanDeEstudio2(unPlanDeEstudio, PEDetalles);
        }
        public void CrearPlanDeEstudio(PlanDeEstudio unPlanDeEstudio, List<DetallesPlan> PEDetalles)
        {
            // If
            // End If

            GuardarPlanDeEstudio(unPlanDeEstudio, PEDetalles);
        }

        private void GuardarPlanDeEstudio2(PlanDeEstudio2 unPlanDeEstudio, List<DetallesPlanDeEstudio> PEDetalles)
        {
            PlanDeEstudioDAO UnPEDAO = new PlanDeEstudioDAO();
            UnPEDAO.Insertar2(unPlanDeEstudio, PEDetalles);
        }
        private void GuardarPlanDeEstudio(PlanDeEstudio unPlanDeEstudio, List<DetallesPlan> PEDetalles)
        {
            PlanDeEstudioDAO UnPEDAO = new PlanDeEstudioDAO();
            UnPEDAO.Insertar(unPlanDeEstudio, PEDetalles);
        }

        public List<DTODetallesCorrPlan> TraerListaPlanes2()
        {
            List<DTODetallesCorrPlan> ListaPlanes = new List<DTODetallesCorrPlan>();
            PlanDeEstudioDAO unPlanDAO = new PlanDeEstudioDAO();
            ListaPlanes = unPlanDAO.TraerTodo();

            return ListaPlanes;
        }
        public List<PlanDeEstudio> TraerListaPlanes()
        {
            List<PlanDeEstudio> ListaPlanes = new List<PlanDeEstudio>();
            PlanDeEstudioDAO unPlanDAO = new PlanDeEstudioDAO();
            ListaPlanes = unPlanDAO.TraerTodoBien();

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
