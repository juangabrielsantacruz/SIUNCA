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
    public class MateriaConCorrelativaDAO
    {
        public void Insertar(MateriaConCorrelativas UnaMateriaCC, List<DetallesCorrelativa> CorrelativasDetalles)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaDeParametros = new List<Parametro>();
            //listaDeParametros.Add(new Parametro("Nombre", Convert.ToString(UnaMateriaCC.Nombre)));
            listaDeParametros.Add(new Parametro("Nombre", UnaMateriaCC.Nombre));

            // listaDeParametros.Add(New Parametro("Horas", unaMateriaCC.horas))

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();
                unaConexion.EjecutarSinResultado("INSERT INTO MateriaConCorrelativas (Nombre) VALUES (@Nombre)", listaDeParametros);

                int IdMateriaCC = unaConexion.EjecutarEscalar<int>("SELECT MAX(IdMateriaCC) FROM MateriaConCorrelativas", new List<Parametro>());


                foreach (var item in CorrelativasDetalles)
                {
                    List<Parametro> listaParametrosCD = new List<Parametro>();


                    listaParametrosCD.Add(new Parametro("IdMateriaCC", IdMateriaCC));
                    listaParametrosCD.Add(new Parametro("IdMateria", item.IdMateria));
                    listaParametrosCD.Add(new Parametro("NombreMateria", item.NombreMateria));
                    listaParametrosCD.Add(new Parametro("NombreMateriaCC", item.NombreMateriaCC));

                    item.IdMateriaCC = IdMateriaCC;

                    unaConexion.EjecutarSinResultado("INSERT INTO DetallesCorrelativa (IdMateria, IdMateriaCC, NombreMateria, NombreMateriaCC) VALUES (@IdMateria, @IdMateriaCC, @NombreMateria, @NombreMateriaCC)", listaParametrosCD);
                }

                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                // EventViewer.RegistrarError("VB", "SQL", "ERROR AL PRODUCIR TRANSACCION", EventViewer.TipoEvento._Error)
                MessageBox.Show("error guardando correlatividad");
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }

        public List<DTODetallesCorrPlan> TraerTodo()
        {
            List<DTODetallesCorrPlan> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                //resultado = unaConexion.EjecutarTupla<DTODetallesCorrPlan>("SELECT m.IdMateriaCC, dpe.IdPlanDetalles, Nombre FROM MateriaConCorrelativas as m inner join DetallesPlanDeEstudio as dpe on m.IdMateriaCC = dpe.IdMateriaCC ", new List<Parametro>());
                resultado = unaConexion.EjecutarTupla<DTODetallesCorrPlan>(@"SELECT IdMateriaCC, Nombre FROM MateriaConCorrelativas", new List<Parametro>());
                // resultado = unaConexion.EjecutarTupla(Of MateriaConCorrelativas)("SELECT * FROM MateriaConCorrelativas", New List(Of Parametro))
                return resultado;
            }
            catch (Exception ex)
            {
                // Dim log As New EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error)
                //Interaction.MsgBox("error al traer materias con correlativas");
                MessageBox.Show("Error al traer materias", ex.Message.ToString());
                return null;
                //throw new ApplicationException("ERROOOOORR TRAER MATERIAS", ex);
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }

        public List<DTODetallesCorrPlan> TraerTodo(int iduser)
        {
            List<DTODetallesCorrPlan> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("iduser", iduser));
                //resultado = unaConexion.EjecutarTupla<DTODetallesCorrPlan>("SELECT m.IdMateriaCC, dpe.IdPlanDetalles, Nombre FROM MateriaConCorrelativas as m inner join DetallesPlanDeEstudio as dpe on m.IdMateriaCC = dpe.IdMateriaCC ", new List<Parametro>());
                resultado = unaConexion.EjecutarTupla<DTODetallesCorrPlan>(@"SELECT matcc.IdMateriaCC, matcc.Nombre FROM Profesor AS pro INNER JOIN                                                           tbl_user AS usr
                                                                             ON usr.iduser = pro.iduser INNER JOIN MateriaCC_Profesor AS matccpro
                                                                             ON pro.Legajo = matccpro.Legajo INNER JOIN MateriaConCorrelativas AS                                          matcc
                                                                             ON matccpro.IdMateriaCC = matcc.IdMateriaCC
                                                                             WHERE pro.iduser = (@iduser) ", listaParametrosCD);
                // resultado = unaConexion.EjecutarTupla(Of MateriaConCorrelativas)("SELECT * FROM MateriaConCorrelativas", New List(Of Parametro))
                return resultado;
            }
            catch (Exception ex)
            {
                // Dim log As New EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error)
                //Interaction.MsgBox("error al traer materias con correlativas");
                MessageBox.Show("Error al traer materias", ex.Message.ToString());
                return null;
                //throw new ApplicationException("ERROOOOORR TRAER MATERIAS", ex);
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }
    
        public List<DTODetallesCorrPlan> TraerTodo(Carrera UnaCarrera)
        {
            List<DTODetallesCorrPlan> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();


                listaParametrosCD.Add(new Parametro("Nombre", UnaCarrera.Nombre));

                resultado = unaConexion.EjecutarTupla<DTODetallesCorrPlan>("Select m.Nombre, m.IdMateriaCC, d.IdPlanDetalles from MateriaConCorrelativas m Inner join detallesplandeestudio d on d.idmateriacc = m.idmateriacc Inner join plandeestudio p on d.idplandeestudio = p.idplandeestudio inner join carrera c on p.IdCarrera = c.IdCarrera where c.Nombre = (@Nombre)", listaParametrosCD);
                return resultado;
            }
            catch (Exception ex)
            {
                // Dim log As New EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error)
                // Interaction.MsgBox("error al traer materias con correlativas");
                throw new ApplicationException("Host name could not be obtained", ex);
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }

        public void Modificar(DTODetallesCorrPlan unaMateria)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaParametros = new List<Parametro>();

            listaParametros.Add(new Parametro("Id", unaMateria.IdMateriaCC));
            listaParametros.Add(new Parametro("Nombre", unaMateria.Nombre));

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();

                unaConexion.EjecutarSinResultado("UPDATE MateriaConCorrelativas SET Nombre = (@Nombre) WHERE IdMateriaCC = (@Id)", listaParametros);
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

    }

}
