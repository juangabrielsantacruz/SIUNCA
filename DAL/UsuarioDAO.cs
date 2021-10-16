using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.D_2015.Persistencia;
using BIZ;
using BIZ.Seguridad;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UsuarioDAO
    {
        public Usuario traerUsuario(Usuario usuario)
        {
            var resultado = new List<Usuario>();

            var con = new Conexion("Config.xml");
            con.ConexionIniciar();

            List<Parametro> listaParametrosCD = new List<Parametro>();
            listaParametrosCD.Add(new Parametro("username", usuario.username));
            listaParametrosCD.Add(new Parametro("password", usuario.password));

            try
            {
                resultado = con.EjecutarTupla<Usuario>(@"SELECT iduser, username, password, email, rol FROM tbl_user
                                                           WHERE username = @username and password = @password ", listaParametrosCD);

                //firstordefault devuelve usuario o null
                return resultado.FirstOrDefault();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.ConexionFinalizar();
            }
        }
        public List<Usuario> TraerTodo()
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Usuario> resultado = new List<Usuario>();
            try
            {
                unaConexion.ConexionIniciar();

                resultado = unaConexion.EjecutarTupla<Usuario>("SELECT iduser, username, password, email, rol FROM tbl_user", new List<Parametro>());
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }

            return resultado;
        }

        public void eliminar(int idUsuario)
        {
            var conexion = new Conexion("Config.xml");

            try
            {
                conexion.ConexionIniciar();
                conexion.TransaccionIniciar();
                var parametros = new List<Parametro>();
                parametros.Add(new Parametro("iduser", idUsuario));

                conexion.EjecutarSinResultado("DELETE FROM tbl_user WHERE iduser = @iduser", parametros);

                conexion.TransaccionAceptar();
            }
            catch (Exception)
            {
                conexion.TransaccionCancelar();
            }
            finally
            {
                conexion.ConexionFinalizar();
            }
        }

   

        public Usuario TraerPermisos(Usuario unUsuario)
        {
            List<Usuario> resultado = new List<Usuario>();
            Usuario elUsuario = new Usuario();
            Familia PatentesAFamilias = new Familia();
            Familia FamiliaconPatentes = new Familia();
            List<Patente> ListaTodasPatentes = new List<Patente>();
            List<Familia> ListaTodasFamilias = new List<Familia>();

            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.InitialCatalog = "PruebaSIUNCA";
            cs.DataSource = ".\\SQLEXPRESS";
            cs.IntegratedSecurity = true;

            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = cs.ConnectionString;
            IDataReader reader1 = null;
            IDataReader reader2 = null;
            IDataReader reader3 = null;
            IDataReader reader4 = null;
            IDataReader reader5 = null;
            IDataReader reader6 = null;
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;

                cmd.CommandText = @"SELECT * FROM tbl_user WHERE iduser = (@IdUsuario)  ";
                cmd.Parameters.AddWithValue("IdUsuario", unUsuario.iduser);
                //cmd.Parameters.AddWithValue("Contraseña", elUsuario.password);

                reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    elUsuario.iduser = Int32.Parse(reader1["iduser"].ToString());

                }
                reader1.Close();
                //sql.Close();
                // Tomo el que debería ser el único usuario
                //elUsuario = resultado.First();


                //sql.Open();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = sql;
                cmd2.CommandText = @"SELECT * FROM UsuarioPatente WHERE IdUsuario = (@IdUsuario)  ";
                cmd2.Parameters.AddWithValue("IdUsuario", unUsuario.iduser);

                reader2 = cmd2.ExecuteReader();

                List<Permiso> ListaPatentesdelUsuario = new List<Permiso>();
                while (reader2.Read())
                {
                    var unaPatente = new Patente();
                    var unUsu = new Usuario();
                    //unaPatente.IdPalabra_Traduccion = Int32.Parse(reader["username"].ToString());
                    unaPatente.Id = Int32.Parse(reader2["IdPatente"].ToString());
                    unUsu.iduser = Int32.Parse(reader2["IdUsuario"].ToString());
                    ListaPatentesdelUsuario.Add(unaPatente);
                    foreach (var item in ListaPatentesdelUsuario)
                    {
                        PatentesAFamilias.Agregar(item);
                    }
                    //elUsuario.Perfil = PatentesAFamilias;
                    // hasta aca agregue al usuario sus patentes individuales , faltan las familias

                }
                reader2.Close();
                //sql.Open();
                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = sql;
                cmd3.CommandText = @"SELECT * FROM UsuarioFamilia WHERE IdUsuario = (@IdUsuario)  ";
                cmd3.Parameters.AddWithValue("IdUsuario", unUsuario.iduser);

                reader3 = cmd3.ExecuteReader();

                List<Permiso> ListaFamiliasdelUsuario = new List<Permiso>();
                while (reader3.Read())
                {
                    var unaFamilia = new Familia();
                    var unUsu = new Usuario();
                    //unaPatente.IdPalabra_Traduccion = Int32.Parse(reader["username"].ToString());
                    unaFamilia.Id = Int32.Parse(reader3["IdFamilia"].ToString());
                    unUsu.iduser = Int32.Parse(reader3["IdUsuario"].ToString());
                    ListaFamiliasdelUsuario.Add(unaFamilia);
                    foreach (var item in ListaFamiliasdelUsuario)
                    {
                        PatentesAFamilias.Agregar(item);
                    }
                    

                }
                reader3.Close();
                // hasta aca agregue al perfil del usuario sus familias
                elUsuario.Perfil = PatentesAFamilias;

                //// 
                ///

                SqlCommand cmd4 = new SqlCommand();
                cmd4.Connection = sql;

                cmd4.CommandText = @"SELECT * FROM Familia";               
                //cmd.Parameters.AddWithValue("Contraseña", elUsuario.password);

                reader4 = cmd4.ExecuteReader();
                
                while (reader4.Read())
                {
                    var unaFamilia = new Familia();
                    unaFamilia.Id = Int32.Parse(reader4["Id"].ToString());
                    unaFamilia.Descripcion = reader4["Descripcion"].ToString();
                    ListaTodasFamilias.Add(unaFamilia);
                }
                
                reader4.Close();


                ///
                /// 
                SqlCommand cmd6 = new SqlCommand();
                cmd6.Connection = sql;

                cmd6.CommandText = @"SELECT * FROM Patente";
                //cmd.Parameters.AddWithValue("Contraseña", elUsuario.password);

                reader6 = cmd6.ExecuteReader();

                while (reader6.Read())
                {
                    var unaPatente = new Patente();
                    unaPatente.Id = Int32.Parse(reader6["Id"].ToString());
                    unaPatente.Descripcion = reader6["Descripcion"].ToString();
                    ListaTodasPatentes.Add(unaPatente);
                }

                reader6.Close();
                /// 
                ///



                SqlCommand cmd5 = new SqlCommand();
                cmd5.Connection = sql;
                cmd5.CommandText = @"SELECT * FROM FamiliaPatente ";
                //cmd4.Parameters.AddWithValue("IdUsuario", unUsuario.iduser);

                reader5 = cmd5.ExecuteReader();

                List<Permiso> ListaPatentesenFamilia = new List<Permiso>();
                
                while (reader5.Read())
                {
                    var unaFamilia = new Familia();
                    var unaPatente = new Patente();
                    //unaPatente.IdPalabra_Traduccion = Int32.Parse(reader["username"].ToString());
                    unaFamilia.Id = Int32.Parse(reader5["IdFamilia"].ToString());
                    unaPatente.Id = Int32.Parse(reader5["IdPatente"].ToString());
                    ListaPatentesenFamilia.Add(unaFamilia);
                    foreach (var item in ListaPatentesenFamilia)
                    {
                        if (item.Id == unaFamilia.Id)
                        {
                            FamiliaconPatentes.Agregar(item);
                        }                        
                    }
                    
                }
                // agrego las patentes individuales y familias al perfil del usuario
                reader5.Close();
                elUsuario.Perfil = PatentesAFamilias;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                
                //sql.Close();
                //if (reader != null)
                //    reader.Close();
                //if (sql != null)
                //    sql.Close();
            }
            return elUsuario;





            /////////
            //Conexion unaConexion = new Conexion("config.xml");
            //List<Usuario> resultado = new List<Usuario>();
            //Usuario elUsuario = new Usuario();

            //List<Patente> TraerTodasPatentes = new List<Patente>();
            //List<Familia> TraerTodasFamilias = new List<Familia>();
            //List<FamiliaPatente> TraerTodasFamiliaPatente = new List<FamiliaPatente>();
            //List<FamiliaFamilia> TraerTodasFamiliaFamilia = new List<FamiliaFamilia>();

            //List<UsuarioPatente> resultadoUsuarioPatente = new List<UsuarioPatente>();
            //List<UsuarioFamilia> resultadoUsuarioFamilia = new List<UsuarioFamilia>();

            //Familia PatentesAFamilias = new Familia();

            //List<Parametro> listaParametros = new List<Parametro>();


            //try
            //{
            //    unaConexion.ConexionIniciar();

            //    listaParametros.Add(new Parametro("@IdUsuario", unUsuario.iduser));
            //    listaParametros.Add(new Parametro("@Contraseña", unUsuario.password));

            //    resultado = unaConexion.EjecutarTupla<Usuario>
            //        //
            //        ("SELECT * FROM tbl_user WHERE iduser = (@IdUsuario) AND password = (@Contraseña)", listaParametros);

            //    // Tomo el que debería ser el único usuario
            //    //elUsuario = resultado.First;
            //    elUsuario = resultado.First();

            //    // Traigo todas las patentes
            //    TraerTodasPatentes = unaConexion.EjecutarTupla<Patente>
            //        ("SELECT * FROM Patente", new List<Parametro>());

            //    // Traigo las relaciones con Patente que tiene el Usuario 
            //    resultadoUsuarioPatente = unaConexion.EjecutarTupla<UsuarioPatente>
            //        ("SELECT * FROM UsuarioPatente WHERE IdUsuario = (@IdUsuario)", listaParametros);


            //    foreach (var item in resultadoUsuarioPatente)
            //    {
            //        // Guardo las Patentes que el Usuario tiene
            //        var oo = TraerTodasPatentes.Find(y => y.Id == item.IdPatente);
            //        //(!IsNothing(oo))
            //        if (oo != null)
            //            // Agrego la Patente a la Lista que será el Perfil del Usuario
            //            PatentesAFamilias.Agregar(oo);
            //    }



            //    TraerTodasFamilias = unaConexion.EjecutarTupla<Familia>
            //        ("SELECT * FROM Familia", listaParametros);

            //    resultadoUsuarioFamilia = unaConexion.EjecutarTupla<UsuarioFamilia>
            //        ("SELECT * FROM UsuarioFamilia WHERE IdUsuario = (@IdUsuario)", listaParametros);

            //    TraerTodasFamiliaPatente = unaConexion.EjecutarTupla<FamiliaPatente>
            //       ("SELECT * FROM FamiliaPatente", new List<Parametro>());

            //    TraerTodasFamiliaFamilia = unaConexion.EjecutarTupla<FamiliaFamilia>(("SELECT * FROM FamiliaFamilia"), new List<Parametro>());


            //    foreach (var item in TraerTodasFamiliaPatente)
            //    {
            //        // Guardo las relaciones de las Familias con las Patentes
            //        var mm = TraerTodasPatentes.Find(x => x.Id == item.IdPatente);
            //        // Agrego la Patente a la Familia
            //        TraerTodasFamilias.Find(o => o.Id == item.IdFamilia).Agregar(mm);
            //    }


            //    foreach (var item in TraerTodasFamiliaFamilia)
            //    {
            //        // Guardo las relaciones de las Familias con las Familias Hijas
            //        var mm = TraerTodasFamilias.Find(x => x.Id == item.IdFamiliaHijo);
            //        // Agrego la Familia hija a la Familia
            //        TraerTodasFamilias.Find(o => o.Id == item.IdFamilia).Agregar(mm);
            //    }

            //    foreach (var item in resultadoUsuarioFamilia)
            //    {
            //        // Guardo las relaciones de los Usuarios con las Familias
            //        var xx = TraerTodasFamilias.Find(x => x.Id == item.IdFamilia);

            //        if (xx != null)
            //            // Agrego la Familia a la lista que será el Perfil del Usuario
            //            PatentesAFamilias.Agregar(xx);
            //    }

            //    // Le pego el perfil al usuario
            //    elUsuario.Perfil = PatentesAFamilias;
            //}
            //catch (Exception ex)
            //{
            //    return null;
            //}

            //finally
            //{
            //}
            //return elUsuario;
        }

        public void insertarUsuario(Usuario usuario)
        {
            var conexion = new Conexion("config.xml");

            try
            {
                conexion.ConexionIniciar();
                conexion.TransaccionIniciar();


                usuario.rol = "Profesor";
                var parametros = new List<Parametro>();
                parametros.Add(new Parametro("username", usuario.username));
                parametros.Add(new Parametro("password", usuario.password));
                parametros.Add(new Parametro("email", usuario.email));
                parametros.Add(new Parametro("rol", usuario.rol));

                conexion.EjecutarSinResultado("INSERT INTO tbl_user (username, password, email, rol) VALUES (@username, @password, @email, @rol)", parametros);

                conexion.TransaccionAceptar();
            }
            catch (Exception)
            {
                conexion.TransaccionCancelar();
            }
            finally
            {
                conexion.ConexionFinalizar();
            }
        }

        public void GuardarPermisos(Usuario unUsuario)
        {
            Conexion unaConexion = new Conexion("config.xml");


            try
            {
                unaConexion.ConexionIniciar();

                unaConexion.TransaccionIniciar();

                List<Parametro> listaParametros = new List<Parametro>();


                listaParametros.Add(new Parametro("@IdUsuario", unUsuario.iduser));

                // Borro todos los Perfiles
                unaConexion.EjecutarSinResultado("DELETE FROM UsuarioFamilia WHERE IdUsuario = (@IdUsuario); DELETE FROM UsuarioPatente WHERE IdUsuario = (@IdUsuario)", listaParametros);

                // Asigno las Familias

                foreach (var Item in unUsuario.Perfil.Lista)
                {
                    List<Parametro> listaParametros2 = new List<Parametro>();

                    if (Item.GetType() == typeof(Familia))
                    {
                        listaParametros2.Add(new Parametro("@IdUsuario", unUsuario.iduser));
                        listaParametros2.Add(new Parametro("@IdFamilia", Item.Id));
                        unaConexion.EjecutarSinResultado("INSERT INTO UsuarioFamilia (IdUsuario, IdFamilia) VALUES (@IdUsuario, @IdFamilia)", listaParametros2);
                    }
                    else if (Item.GetType() == typeof(Patente))
                    {
                        listaParametros2.Add(new Parametro("@IdUsuario", unUsuario.iduser));
                        listaParametros2.Add(new Parametro("@IdPatente", Item.Id));
                        unaConexion.EjecutarSinResultado("INSERT INTO UsuarioPatente (IdUsuario, IdPatente) VALUES (@IdUsuario, @IdPatente)", listaParametros2);
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

    }
}
