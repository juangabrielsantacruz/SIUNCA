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
    public class FamiliaDAO
    {
        public List<Familia> TraerTodo()
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Familia> TraerTodasFamilias = new List<Familia>();

            Familia PatentesAFamilias = new Familia();

            List<Patente> TraerTodasPatentes = new List<Patente>();

            List<FamiliaPatente> TraerTodasFamiliaPatente = new List<FamiliaPatente>();

            List<FamiliaFamilia> TraerTodasFamiliaFamilia = new List<FamiliaFamilia>();

            try
            {
                unaConexion.ConexionIniciar();


                TraerTodasFamilias = unaConexion.EjecutarTupla<Familia>
                    ("SELECT Id, Descripcion FROM Familia", new List<Parametro>());

                TraerTodasPatentes = unaConexion.EjecutarTupla<Patente>
                    ("SELECT Id, Descripcion FROM Patente", new List<Parametro>());

                TraerTodasFamiliaPatente = unaConexion.EjecutarTupla<FamiliaPatente>(("SELECT IdFamilia, IdPatente FROM FamiliaPatente"), new List<Parametro>());

                TraerTodasFamiliaFamilia = unaConexion.EjecutarTupla<FamiliaFamilia>(("SELECT IdFamilia, IdFamiliaHijo FROM FamiliaFamilia"), new List<Parametro>());


                foreach (var item in TraerTodasFamiliaPatente)
                {
                    // Busco y guardo la patente que contiene el item Familia
                    var mm = TraerTodasPatentes.Find(x => x.Id == item.IdPatente);
                    // Y pego/agrego la Patente en la lista de todas las Familias
                    TraerTodasFamilias.Find(o => o.Id == item.IdFamilia).Agregar(mm);
                }

                foreach (var item in TraerTodasFamiliaFamilia)
                {
                    // Busco y guardo la Familia hija que contiene la Familia "padre"
                    var mm = TraerTodasFamilias.Find(x => x.Id == item.IdFamiliaHijo);
                    // Y pego/agrego la Familia hija a la Familia Padre
                    TraerTodasFamilias.Find(o => o.Id == item.IdFamilia).Agregar(mm);
                }
            }

            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                MessageBox.Show("error traer familias");
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }

            return TraerTodasFamilias;
        }

        public void GuardarPermisos(Familia unaFamilia)
        {
            Conexion unaConexion = new Conexion("config.xml");

            try
            {
                unaConexion.ConexionIniciar();

                unaConexion.TransaccionIniciar();

                List<Parametro> listaParametros = new List<Parametro>();

                listaParametros.Add(new Parametro("@IdFamilia", unaFamilia.Id));

                // Borro todos los Perfiles que tenía la Familia

                // unaConexion.EjecutarSinResultado("DELETE FROM FamiliaPatente WHERE IdFamilia = (@IdFamilia); DELETE FROM UsuarioFamilia WHERE IdFamilia = (@IdFamilia); DELETE FROM FamiliaFamilia WHERE IdFamilia = (@IdFamilia)", listaParametros)
                unaConexion.EjecutarSinResultado("DELETE FROM FamiliaPatente WHERE IdFamilia = (@IdFamilia); DELETE FROM FamiliaFamilia WHERE IdFamilia = (@IdFamilia)", listaParametros);

                // Asigno las Familias

                foreach (var Item in unaFamilia.Lista)
                {
                    List<Parametro> listaParametros2 = new List<Parametro>();

                    if (Item.GetType() == typeof(Familia))
                    {
                        listaParametros2.Add(new Parametro("@IdFamilia", unaFamilia.Id));
                        listaParametros2.Add(new Parametro("@IdFamiliaHijo", Item.Id));
                        unaConexion.EjecutarSinResultado("INSERT INTO FamiliaFamilia (IdFamilia, IdFamiliaHijo) VALUES (@IdFamilia, @IdFamiliaHijo)", listaParametros2);
                    }
                    else if (Item.GetType() == typeof(Patente))
                    {
                        listaParametros2.Add(new Parametro("@IdFamilia", unaFamilia.Id));
                        listaParametros2.Add(new Parametro("@IdPatente", Item.Id));
                        unaConexion.EjecutarSinResultado("INSERT INTO FamiliaPatente (IdFamilia, IdPatente) VALUES (@IdFamilia, @IdPatente)", listaParametros2);
                    }
                }

                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                throw;
            }

            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }

        public void Insertar(Familia unaFamilia)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaParametros = new List<Parametro>();

            listaParametros.Add(new Parametro("Id", unaFamilia.Id));
            listaParametros.Add(new Parametro("Descripcion", unaFamilia.Descripcion));

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();
                unaConexion.EjecutarSinResultado("INSERT INTO Familia (Id, Descripcion) VALUES (@Id, @Descripcion)", listaParametros);
                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                MessageBox.Show("error insertar Familia");
            }

            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }

        public void Quitar(Familia unaFamilia)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaParametros = new List<Parametro>();

            listaParametros.Add(new Parametro("IdFamilia", unaFamilia.Id));

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();
                // Acá borro todas las relaciones que tenga la Familia con otras Familias, Patentes, etc.
                unaConexion.EjecutarSinResultado("DELETE FROM FamiliaPatente WHERE IdFamilia = (@IdFamilia); DELETE FROM UsuarioFamilia WHERE IdFamilia = (@IdFamilia); DELETE FROM FamiliaFamilia WHERE IdFamilia = (@IdFamilia) OR IdFamiliaHijo = (@IdFamilia); DELETE FROM Familia WHERE Id = (@IdFamilia)", listaParametros);
                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                MessageBox.Show("error Quitar Familia");
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }

        public void Modificar(Familia unaFamilia)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaParametros = new List<Parametro>();

            listaParametros.Add(new Parametro("IdFamilia", unaFamilia.Id));
            listaParametros.Add(new Parametro("Descripcion", unaFamilia.Descripcion));

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();
                unaConexion.EjecutarSinResultado("UPDATE Familia SET Descripcion = (@Descripcion) WHERE Id = (@IdFamilia)", listaParametros);
                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                MessageBox.Show("error Modificar Familia");
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }

    }
}
