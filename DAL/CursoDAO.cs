using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;
using Framework.D_2015.Persistencia;
using BIZ.DTOs;

namespace DAL
{
    public class CursoDAO
    {
        public List<Curso> TraerTodo(DTODetallesCorrPlan unaMateria)
        {
            List<Curso> resultado = new List<Curso>();
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("IdMateriaCC", unaMateria.IdMateriaCC));

                resultado = unaConexion.EjecutarTupla<Curso>("SELECT IdCurso, FechaInicio, FechaFin, CuposMax, Turno FROM Curso c INNER JOIN MateriaConCorrelativas mcc on mcc.IdMateriaCC = c.IdMateriaCC WHERE DATEDIFF(d, FechaInicio, GETDATE()) <> 0 and c.CuposMax > 0 and mcc.IdMateriaCC = (@IdMateriaCC)", listaParametrosCD);

            }
            catch (Exception ex)
            {
                // EventViewer log = new EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error);
                //Interaction.MsgBox("error al traer el nombre y apellido del alumno");
                MessageBox.Show("error traer curso", ex.ToString());

            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
            return resultado;
        }

        public void Insertar(DTOCurso unDTOcurso, List<DTOCurso> listCurso)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaDeParametros = new List<Parametro>();
            listaDeParametros.Add(new Parametro("Nombre", unDTOcurso.nombreCurso));

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();


                foreach (var item in listCurso)
                {
                    List<Parametro> listaParametrosCD = new List<Parametro>();

                    //listaParametrosCD.Add(new Parametro("IdDetallesDetMatPlanCorrPlan", IdDetallesDetMatPlanCorrPlan));
                    listaParametrosCD.Add(new Parametro("IdMateriaCC", item.IdMateriaCC));
                    listaParametrosCD.Add(new Parametro("IdCarrera", item.IdCarrera));
                    listaParametrosCD.Add(new Parametro("FechaInicio", item.FechaInicio));
                    listaParametrosCD.Add(new Parametro("FechaFin", item.FechaFin));
                    listaParametrosCD.Add(new Parametro("Turno", item.Turno));
                    listaParametrosCD.Add(new Parametro("CuposMax", item.CuposMax));

                    //item.IdDetallesDetMatPlanCorrPlan = IdDetallesDetMatPlanCorrPlan;

                    unaConexion.EjecutarSinResultado("INSERT INTO Curso (IdMateriaCC, IdCarrera, FechaInicio, FechaFin, Turno, CuposMax) VALUES (@IdMateriaCC, @IdCarrera, @FechaInicio, @FechaFin, @Turno, @CuposMax)", listaParametrosCD);
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

        public List<Curso> TraerCuposCurso(Curso uncurso)
        {
            List<Curso> resultado = new List<Curso>();
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("IdCurso", uncurso.IdCurso));
                resultado = unaConexion.EjecutarTupla<Curso>("SELECT CuposMax FROM Curso WHERE IdCurso = (@IdCurso)", listaParametrosCD);

            }
            catch (Exception ex)
            {
                // EventViewer log = new EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error);
                //Interaction.MsgBox("error al traer el nombre y apellido del alumno");
                MessageBox.Show("error traer cupos curso", ex.ToString());

            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
            return resultado;
        }
    }
}
