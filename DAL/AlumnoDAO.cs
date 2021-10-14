using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using BIZ.DTOs;
using Framework.D_2015.Persistencia;
using System.Windows.Forms;

namespace DAL
{
    public class AlumnoDAO
    {
        //public List<Alumno> traerTodo()
        //{
        //    throw new NotImplementedException();
        //}

        public List<DTOAlumno> traerTodo(int IdMateriaCC)
        {
            List<DTOAlumno> resultado = new List<DTOAlumno>();
            var con = new Conexion("config.xml");
            con.ConexionIniciar();

           
            List<Parametro> listaParametrosCD = new List<Parametro>();
            listaParametrosCD.Add(new Parametro("IdMateriaCC", IdMateriaCC));

            try
            {
                resultado = con.EjecutarTupla<DTOAlumno>(@"SELECT alu.LegajoAlumno, alu.Nombre, alu.Apellido, CAST(SUM(CAST(asist.Ausente AS int))                                          AS varchar) Ausente, CAST(SUM(CAST(asist.Presente AS int)) AS varchar) Presente,                                                 asist.IdMateriaCC, es.Nombre AS Estado
                                                           FROM Alumno AS alu INNER JOIN Asistencia AS asist
                                                           ON alu.LegajoAlumno = asist.LegajoAlumno INNER JOIN MateriaConCorrelativas as matcor
                                                           ON asist.IdMAteriaCC = matcor.IdMateriaCC INNER JOIN Estado AS es
                                                           ON es.IdEstado = alu.IdEstado
                                                           WHERE matcor.IdMateriaCC = @IdMateriaCC
                                                           GROUP BY alu.LegajoAlumno, alu.Nombre, alu.Apellido, asist.IdMateriaCC, matcor.IdMateriaCC, es.Nombre", listaParametrosCD);
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al traer alumnos" + ex);
                return null;
            }
            finally
            {
                con.ConexionFinalizar();
            }

        }
        public List<Alumno> traerTodo()
        {
            List<Alumno> resultado = new List<Alumno>();
            var con = new Conexion("config.xml");
            con.ConexionIniciar();

            List<Parametro> listaParametrosCD = new List<Parametro>();           

            try
            {
                resultado = con.EjecutarTupla<Alumno>(@"SELECT LegajoAlumno, Nombre, Apellido, Email, Sexo FROM Alumno", listaParametrosCD);
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al traer alumnos" + ex);
                return null;
            }
            finally
            {
                con.ConexionFinalizar();
            }

        }
        public List<Alumno> TraerTodo(Alumno UnAlumno)
        {
            List<Alumno> resultado = new List<Alumno>();
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("LegajoAlumno", UnAlumno.LegajoAlumno));
                resultado = unaConexion.EjecutarTupla<Alumno>("SELECT Nombre, Apellido FROM Alumno WHERE LegajoAlumno = (@LegajoAlumno)", listaParametrosCD);


            }
            catch (Exception ex)
            {
                // EventViewer log = new EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error);

                MessageBox.Show("error traer alumno", ex.ToString());

            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
            return resultado;
        }
        public void GuardarAsignacionAlumnoAMaterias(Alumno unAlumno, List<Alumno_MateriaCC> AlumnoMateriaDetalles)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaDeParametros = new List<Parametro>();
            listaDeParametros.Add(new Parametro("LegajoAlumno", unAlumno.LegajoAlumno));

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();


                foreach (var item in AlumnoMateriaDetalles)
                {
                    List<Parametro> listaParametrosCD = new List<Parametro>();

                    //listaParametrosCD.Add(new Parametro("IdDetallesDetMatPlanCorrPlan", IdDetallesDetMatPlanCorrPlan));
                    listaParametrosCD.Add(new Parametro("IdMateriaCC", item.IdMateriaCC));
                    listaParametrosCD.Add(new Parametro("LegajoAlumno", item.LegajoAlumno));
                    listaParametrosCD.Add(new Parametro("Estado", item.Estado));


                    //item.IdDetallesDetMatPlanCorrPlan = IdDetallesDetMatPlanCorrPlan;

                    unaConexion.EjecutarSinResultado("INSERT INTO Alumno_MateriaCC (IdMateriaCC, LegajoAlumno, Estado) VALUES (@IdMateriaCC, @LegajoAlumno, @Estado)", listaParametrosCD);
                }
                unaConexion.TransaccionAceptar();
            }
            catch (Exception x)
            {
                unaConexion.TransaccionCancelar();
                // EventViewer.RegistrarError("VB", "SQL", "ERROR AL PRODUCIR TRANSACCION", EventViewer.TipoEvento._Error)
                //Interaction.MsgBox("error al insertar plan de estudio detalles");
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }

        }
        public void Crear(object unAlumno)
        {
        }
        public void Modificar(Alumno unAlumno)
        {

            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaParametros = new List<Parametro>();

            listaParametros.Add(new Parametro("LegajoAlumno", unAlumno.LegajoAlumno));
            listaParametros.Add(new Parametro("Nombre", unAlumno.Nombre));
            listaParametros.Add(new Parametro("Apellido", unAlumno.Apellido));
            listaParametros.Add(new Parametro("Email", unAlumno.Email));
            listaParametros.Add(new Parametro("Sexo", unAlumno.Sexo));


            try
                {
                    unaConexion.ConexionIniciar();
                    unaConexion.TransaccionIniciar();

                    unaConexion.EjecutarSinResultado("UPDATE Alumno SET Nombre = (@Nombre), Apellido = (@Apellido), Email = (@Email), Sexo = (@Sexo) WHERE LegajoAlumno = (@LegajoAlumno)", listaParametros);
                    unaConexion.TransaccionAceptar();
                }
                catch (Exception ex)
                {
                    unaConexion.TransaccionCancelar();
                    MessageBox.Show("error modificando materia");
                }

                finally
                {
                    unaConexion.ConexionFinalizar();
                }
            
        }
        public void Eliminar(object unAlumno)
        {
        }


    }
}
