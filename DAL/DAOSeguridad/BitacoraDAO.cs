using BIZ.Seguridad;
using Framework.D_2015.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Framework.D_2015.Cache;

namespace DAL.DAOSeguridad
{
    public class BitacoraDAO
    {
        public List<string> TraerTodosEventos()
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Bitacora2> resultado = new List<Bitacora2>();
            List<string> cadenas = new List<string>();

            try
            {
                unaConexion.ConexionIniciar();
                resultado = unaConexion.EjecutarTupla<Bitacora2>("SELECT Mensaje FROM Bitacora", new List<Parametro>());
                foreach (var item in resultado)
                    cadenas.Add(item.Mensaje);

                cadenas = cadenas.Distinct().ToList();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                //Interaction.MsgBox(ex.Message.ToString());
                MessageBox.Show("Error al traer eventos", ex.ToString());
            }

            finally
            {
                unaConexion.ConexionFinalizar();
            }
            return cadenas;
        }

        public List<Bitacora2> ConsultarBitacora(DateTime unaFechaInicial, DateTime unaFechaFinal, int unTipoIdBitacora, int unIdUsuario, string unMensaje)
        {
            List<Bitacora2> resultado = new List<Bitacora2>();

            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaParametros = new List<Parametro>();


            listaParametros.Add(new Parametro("FechaInicial", unaFechaInicial));
            listaParametros.Add(new Parametro("FechaFinal", unaFechaFinal));
            listaParametros.Add(new Parametro("IdTipoBitacora", unTipoIdBitacora));
            listaParametros.Add(new Parametro("IdUsuario", unIdUsuario));
            listaParametros.Add(new Parametro("Mensaje", unMensaje));

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();
                // unaConexion.EjecutarSinResultado("SELECT * FROM Bitacora WHERE idTipoBitacora = (@IdTipoBitacora) AND IdUsuario = (@IdUsuario) AND FechaHora BETWEEN (@FechaInicial) AND (@FechaFinal)", listaParametros)
                resultado = unaConexion.EjecutarTupla<Bitacora2>("SELECT * FROM Bitacora WHERE idTipoBitacora = (@IdTipoBitacora) AND IdUsuario = (@IdUsuario) and Mensaje=(@Mensaje)", listaParametros);
                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                MessageBox.Show("Error al traer bitacoras", ex.ToString());
                //Interaction.MsgBox(ex.Message.ToString());
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }




            return resultado;
        }

        public List<Bitacora2> ConsultarBitacora(DateTime unaFechaInicial, DateTime unaFechaFinal, int unTipoIdBitacora, int unIdUsuario)
        {
            List<Bitacora2> resultado = new List<Bitacora2>();
           

            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaParametros = new List<Parametro>();


            listaParametros.Add(new Parametro("FechaInicial", unaFechaInicial));
            listaParametros.Add(new Parametro("FechaFinal", unaFechaFinal));
            listaParametros.Add(new Parametro("IdTipoBitacora", unTipoIdBitacora));
            listaParametros.Add(new Parametro("IdUsuario", unIdUsuario));

            try
            {

                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();
                // unaConexion.EjecutarSinResultado("SELECT * FROM Bitacora WHERE idTipoBitacora = (@IdTipoBitacora) AND IdUsuario = (@IdUsuario) AND FechaHora BETWEEN (@FechaInicial) AND (@FechaFinal)", listaParametros)
                //resultado = unaConexion.EjecutarTupla<Bitacora2>("SELECT * FROM Bitacora WHERE idTipoBitacora = (@IdTipoBitacora) AND IdUsuario = (@IdUsuario)", listaParametros);
                resultado = unaConexion.EjecutarTupla<Bitacora2>("SELECT * FROM Bitacora WHERE idTipoBitacora = (@IdTipoBitacora)AND IdUsuario = (@IdUsuario)AND FechaHora BETWEEN(@FechaInicial) AND(@FechaFinal)", listaParametros);
                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                MessageBox.Show("Error al traer bitacoras", ex.ToString());
                //Interaction.MsgBox(ex.Message.ToString());
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }




            return resultado;
        }

        // Sub Insertar(unUsuario As UsuarioDTO, unIdTipoBitacora As Integer, unaFecha As Date, unMensaje As String)
        public void Insertar(Bitacora2 unaBitacora)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaParametros = new List<Parametro>();
            

            listaParametros.Add(new Parametro("IdUsuario", unaBitacora.Usuario.iduser));
            listaParametros.Add(new Parametro("IdTipoBitacora", unaBitacora.TipoBitacora.IdTipoBitacora));
            listaParametros.Add(new Parametro("FechaHora", unaBitacora.FechaHora));
            listaParametros.Add(new Parametro("Mensaje", unaBitacora.Mensaje));


            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();
                unaConexion.EjecutarSinResultado("INSERT INTO Bitacora (IdUsuario,IdTipoBitacora,FechaHora,Mensaje) VALUES (@IdUsuario,@IdTipoBitacora,@FechaHora,@Mensaje)", listaParametros);
                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                MessageBox.Show("Error al insertar bitacoras", ex.ToString());
                //Interaction.MsgBox(ex.Message.ToString());
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }
        public void Insertar(int unIdUsuario, int unIdTipoBitacora, DateTime unaFechaHora, string unMensaje)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaParametros = new List<Parametro>();
          

            listaParametros.Add(new Parametro("IdUsuario", unIdUsuario));
            listaParametros.Add(new Parametro("IdTipoBitacora", unIdTipoBitacora));
            listaParametros.Add(new Parametro("FechaHora", unaFechaHora));
            listaParametros.Add(new Parametro("Mensaje", unMensaje));


            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();
                unaConexion.EjecutarSinResultado("INSERT INTO Bitacora (IdUsuario,IdTipoBitacora,FechaHora,Mensaje) VALUES (@IdUsuario,@IdTipoBitacora,@FechaHora,@Mensaje)", listaParametros);
                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                MessageBox.Show("Error al insertar bitacoras", ex.ToString());
                //Interaction.MsgBox(ex.Message.ToString());
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }

        public void EliminarBitacoras(List<Bitacora2> unaListaBitacora)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaParametros = new List<Parametro>();
           

            foreach (var item in unaListaBitacora)
            {
                listaParametros.Clear();
                listaParametros.Add(new Parametro("IdBitacora", item.IdBitacora));

                try
                {
                    unaConexion.ConexionIniciar();
                    unaConexion.TransaccionIniciar();
                    unaConexion.EjecutarSinResultado("DELETE FROM Bitacora WHERE IdBitacora = (@IdBitacora)", listaParametros);
                    unaConexion.TransaccionAceptar();
                }
                catch (Exception ex)
                {
                    unaConexion.TransaccionCancelar();
                    //Interaction.MsgBox(ex.Message.ToString());
                }
                finally
                {
                    unaConexion.ConexionFinalizar();
                }
            }
        }
    }
}
