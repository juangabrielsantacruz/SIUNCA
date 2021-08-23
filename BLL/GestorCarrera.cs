using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;

namespace BLL
{
    
        public class GestorCarrera
        {
            public List<Carrera> TraerListaCarreras()
            {
                List<Carrera> ListaCarrera = new List<Carrera>();
                CarreraDAO unaCarreraDAO = new CarreraDAO();
                ListaCarrera = unaCarreraDAO.TraerTodo();
            
                return ListaCarrera;
            }

            public List<Carrera> TraerCarrera(Alumno UnAlumno)
            {
                List<Carrera> unaCarrera = new List<Carrera>();
                CarreraDAO unaCarreraDAO = new CarreraDAO();
                unaCarrera = unaCarreraDAO.TraerTodo(UnAlumno);
                return unaCarrera;
            }
        }
    
}
