using BIZ.Seguridad;
using Framework.D_2015.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.DAOSeguridad
{
    public class PatenteDAO
    {
        public List<Patente2> TraerTodo()
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Patente2> resultado = new List<Patente2>();

            List<Patente2> TraerTodasPatentes = new List<Patente2>();


            try
            {
                unaConexion.ConexionIniciar();

                resultado = unaConexion.EjecutarTupla<Patente2>
                    ("SELECT Id, Descripcion FROM Patente", new List<Parametro>());
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                MessageBox.Show("error traer patente");
            }

            finally
            {
                unaConexion.ConexionFinalizar();
            }

            return resultado;
        }

        public void Insertar(Patente2 unaPatente)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaParametros = new List<Parametro>();

            listaParametros.Add(new Parametro("Id", unaPatente.Id));
            listaParametros.Add(new Parametro("Descripcion", unaPatente.Descripcion));

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();

                unaConexion.EjecutarSinResultado("INSERT INTO Patente (Id, Descripcion) VALUES (@Id, @Descripcion)", listaParametros);
                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                MessageBox.Show("error insertando patente");
            }

            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }

        public void Quitar(Patente2 unaPatente)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaParametros = new List<Parametro>();

            listaParametros.Add(new Parametro("IdPatente", unaPatente.Id));

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();
                unaConexion.EjecutarSinResultado("DELETE FROM UsuarioPatente WHERE IdPatente = (@IdPatente); DELETE FROM FamiliaPatente WHERE IdPatente = (@IdPatente); DELETE FROM Patente WHERE Id = (@IdPatente)", listaParametros);
                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                MessageBox.Show("error quitando patente");
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }


        public void Modificar(Patente2 unaPatente)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaParametros = new List<Parametro>();

            listaParametros.Add(new Parametro("Id", unaPatente.Id));
            listaParametros.Add(new Parametro("Descripcion", unaPatente.Descripcion));

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();

                unaConexion.EjecutarSinResultado("UPDATE Patente SET Descripcion = (@Descripcion) WHERE Id = (@Id)", listaParametros);
                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                MessageBox.Show("error modificando patente");
            }

            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }

    }
}
