using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Framework.D_2015;
using BIZ;
using BIZ.DTOs;

namespace BLL
{
    public class GestorAlumno
    {
        public List<DTOAlumno> traerAlumnos(int IdMateriaCC)
        {
            var listaAlumnos = new List<DTOAlumno>();
            var unAlumnoDAO = new AlumnoDAO();
            listaAlumnos = unAlumnoDAO.traerTodo(IdMateriaCC);

            return listaAlumnos;
        }
        public List<Alumno> traerAlumnos()
        {
            var listaAlumnos = new List<Alumno>();
            var unAlumnoDAO = new AlumnoDAO();
            listaAlumnos = unAlumnoDAO.traerTodo();

            return listaAlumnos;
        }


        public List<Alumno> TraerAlumno(Alumno UnAlumno)
        {
            List<Alumno> ListaAlumno = new List<Alumno>();
            AlumnoDAO UnAlumnoDAO = new AlumnoDAO();
            ListaAlumno = UnAlumnoDAO.TraerTodo(UnAlumno);
            return ListaAlumno;
        }

        public void AsignarAlumnoAMaterias(Alumno unAlumno, List<Alumno_MateriaCC> AlumnoMateriaDetalles)
        {
            AlumnoDAO unAlumnoDAO = new AlumnoDAO();

            unAlumnoDAO.GuardarAsignacionAlumnoAMaterias(unAlumno, AlumnoMateriaDetalles);
        }

        public void Crear(object unAlumno)
        {
        }
        public void Modificar(Alumno unAlumno)
        {
            AlumnoDAO unAlumnoDAO = new AlumnoDAO();
            unAlumnoDAO.Modificar(unAlumno);
        }
        public void Eliminar(object unAlumno)
        {
        }



    }
}


