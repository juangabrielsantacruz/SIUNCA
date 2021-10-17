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
            //List<Usuario> resultado = new List<Usuario>();
            //Usuario elUsuario = new Usuario();
            //Familia2 PatentesAFamilias = new Familia2();
            //Familia2 FamiliaconPatentes = new Familia2();

            //List<Patente2> ListaTodasPatentes = new List<Patente2>();
            //List<Familia2> ListaTodasFamilias = new List<Familia2>();

            //SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            //cs.InitialCatalog = "PruebaSIUNCA";
            //cs.DataSource = ".\\SQLEXPRESS";
            //cs.IntegratedSecurity = true;

            //SqlConnection sql = new SqlConnection();
            //sql.ConnectionString = cs.ConnectionString;
            //IDataReader reader = null;

            //try
            //{
            //    sql.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = sql;

            //    cmd.CommandText = @"SELECT * FROM tbl_user WHERE iduser = (@IdUsuario)  ";
            //    cmd.Parameters.AddWithValue("IdUsuario", unUsuario.iduser);
            //    //cmd.Parameters.AddWithValue("Contraseña", elUsuario.password);

            //    reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        elUsuario.iduser = Int32.Parse(reader["iduser"].ToString());

            //    }
            //    reader.Close();

            //    // Tomo el que debería ser el único usuario
            //    //elUsuario = resultado.First();


            //    SqlCommand cmd2 = new SqlCommand();
            //    cmd2.Connection = sql;
            //    cmd2.CommandText = @"SELECT * FROM UsuarioPatente WHERE IdUsuario = (@IdUsuario)  ";
            //    cmd2.Parameters.AddWithValue("IdUsuario", unUsuario.iduser);

            //    reader = cmd2.ExecuteReader();

            //    List<Permiso> ListaPatentesdelUsuario = new List<Permiso>();
            //    while (reader.Read())
            //    {
            //        var unaPatente = new Patente2();
            //        var unUsu = new Usuario();
            //        //unaPatente.IdPalabra_Traduccion = Int32.Parse(reader["username"].ToString());
            //        unaPatente.Id = Int32.Parse(reader["IdPatente"].ToString());
            //        unUsu.iduser = Int32.Parse(reader["IdUsuario"].ToString());
            //        ListaPatentesdelUsuario.Add(unaPatente);
            //        foreach (var item in ListaPatentesdelUsuario)
            //        {
            //            PatentesAFamilias.Agregar(item);
            //        }
            //        //elUsuario.Perfil = PatentesAFamilias;
            //        // hasta aca agregue al usuario sus patentes individuales , faltan las familias

            //    }
            //    reader.Close();

            //    SqlCommand cmd3 = new SqlCommand();
            //    cmd3.Connection = sql;
            //    cmd3.CommandText = @"SELECT * FROM UsuarioFamilia WHERE IdUsuario = (@IdUsuario)  ";
            //    cmd3.Parameters.AddWithValue("IdUsuario", unUsuario.iduser);

            //    reader = cmd3.ExecuteReader();

            //    List<Permiso> ListaFamiliasdelUsuario = new List<Permiso>();

            //    while (reader.Read())
            //    {
            //        var unaFamilia4 = new Familia2();
            //        var unUsu = new Usuario();
            //        //unaPatente.IdPalabra_Traduccion = Int32.Parse(reader["username"].ToString());
            //        unaFamilia4.Id = Int32.Parse(reader["IdFamilia"].ToString());
            //        unUsu.iduser = Int32.Parse(reader["IdUsuario"].ToString());
            //        ListaFamiliasdelUsuario.Add(unaFamilia4);
            //        foreach (var item in ListaFamiliasdelUsuario)
            //        {
            //            PatentesAFamilias.Agregar(item);
            //        }


            //    }
            //    reader.Close();
            //    // hasta aca agregue al perfil del usuario sus familias
            //    elUsuario.Perfil = PatentesAFamilias;

            //    //// 
            //    ///

            //    SqlCommand cmd4 = new SqlCommand();
            //    cmd4.Connection = sql;

            //    cmd4.CommandText = @"SELECT * FROM Familia";               
            //    //cmd.Parameters.AddWithValue("Contraseña", elUsuario.password);

            //    reader = cmd4.ExecuteReader();

            //    var unaFamilia3 = new Familia2();
            //    while (reader.Read())
            //    {

            //        unaFamilia3.Id = Int32.Parse(reader["Id"].ToString());
            //        unaFamilia3.Descripcion = reader["Descripcion"].ToString();
            //        ListaTodasFamilias.Add(unaFamilia3);
            //    }

            //    reader.Close();


            //    ///
            //    /// 

            //    /// 
            //    /// 
            //    /// 
            //    SqlCommand cmd6 = new SqlCommand();
            //    cmd6.Connection = sql;

            //    cmd6.CommandText = @"SELECT * FROM Patente";
            //    //cmd.Parameters.AddWithValue("Contraseña", elUsuario.password);

            //    reader = cmd6.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        var unaPatente = new Patente2();
            //        unaPatente.Id = Int32.Parse(reader["Id"].ToString());
            //        unaPatente.Descripcion = reader["Descripcion"].ToString();
            //        ListaTodasPatentes.Add(unaPatente);
            //    }

            //    reader.Close();
            //    /// 
            //    ///


            //    SqlCommand cmd5 = new SqlCommand();
            //    cmd5.Connection = sql;
            //    cmd5.CommandText = @"SELECT * FROM FamiliaPatente ";
            //    //cmd4.Parameters.AddWithValue("IdUsuario", unUsuario.iduser);

            //    reader = cmd5.ExecuteReader();

            //    List<Permiso> ListaPatentesenFamilias = new List<Permiso>();
            //    var unaFamilia2 = new Familia2();
            //    while (reader.Read())
            //    {
            //        //var unaFamilia = Familia();
            //        var unaPatente = new Patente2();
            //        //unaPatente.IdPalabra_Traduccion = Int32.Parse(reader["username"].ToString());
            //        unaFamilia2.Id = Int32.Parse(reader["IdFamilia"].ToString());
            //        unaPatente.Id = Int32.Parse(reader["IdPatente"].ToString());

            //        ListaPatentesenFamilias.Add(unaPatente);

            //        foreach (var item in ListaPatentesenFamilias)
            //        {
            //            unaFamilia2.Agregar(item);
            //            //var mm = ListaTodasPatentes.Find(x => x.Id == item.Id);
            //            ////ListaTodasFamilias.Find(o => o.Id == item.Id).Agregar(mm);
            //            //ListaTodasFamilias.Find(o => o.Id == item.Id).Agregar(mm);
            //        }
            //    }
            //    reader.Close();

            //    // agrego las patentes individuales y familias al perfil del usuario

            //    elUsuario.Perfil = PatentesAFamilias;
            //}
            //catch (Exception e)
            //{

            //    throw e;
            //}
            //finally
            //{

            //    //sql.Close();
            //    //if (reader != null)
            //    //    reader.Close();
            //    //if (sql != null)
            //    //    sql.Close();
            //}
            //return elUsuario;





            /////////
            Conexion unaConexion = new Conexion("config.xml");
            List<Usuario> resultado = new List<Usuario>();
            Usuario elUsuario = new Usuario();

            List<Patente2> TraerTodasPatentes = new List<Patente2>();
            List<Familia2> TraerTodasFamilias = new List<Familia2>();
            List<FamiliaPatente> TraerTodasFamiliaPatente = new List<FamiliaPatente>();
            List<FamiliaFamilia> TraerTodasFamiliaFamilia = new List<FamiliaFamilia>();

            List<UsuarioPatente> resultadoUsuarioPatente = new List<UsuarioPatente>();
            List<UsuarioFamilia> resultadoUsuarioFamilia = new List<UsuarioFamilia>();

            Familia2 PatentesAFamilias = new Familia2();

            List<Parametro> listaParametros = new List<Parametro>();


            try
            {
                unaConexion.ConexionIniciar();

                listaParametros.Add(new Parametro("@IdUsuario", unUsuario.iduser));
                listaParametros.Add(new Parametro("@Contraseña", unUsuario.password));

                resultado = unaConexion.EjecutarTupla<Usuario>
                    //
                    ("SELECT * FROM tbl_user WHERE iduser = (@IdUsuario) AND password = (@Contraseña)", listaParametros);

                // Tomo el que debería ser el único usuario
                //elUsuario = resultado.First;
                elUsuario = resultado.First();

                // Traigo todas las patentes
                TraerTodasPatentes = unaConexion.EjecutarTupla<Patente2>
                    ("SELECT * FROM Patente", new List<Parametro>());

                // Traigo las relaciones con Patente que tiene el Usuario 
                resultadoUsuarioPatente = unaConexion.EjecutarTupla<UsuarioPatente>
                    ("SELECT * FROM UsuarioPatente WHERE IdUsuario = (@IdUsuario)", listaParametros);


                foreach (var item in resultadoUsuarioPatente)
                {
                    // Guardo las Patentes que el Usuario tiene
                    var oo = TraerTodasPatentes.Find(y => y.Id == item.IdPatente);
                    //(!IsNothing(oo))
                    if (oo != null)
                        // Agrego la Patente a la Lista que será el Perfil del Usuario
                        PatentesAFamilias.Agregar(oo);
                }



                TraerTodasFamilias = unaConexion.EjecutarTupla<Familia2>
                    ("SELECT * FROM Familia", listaParametros);

                resultadoUsuarioFamilia = unaConexion.EjecutarTupla<UsuarioFamilia>
                    ("SELECT * FROM UsuarioFamilia WHERE IdUsuario = (@IdUsuario)", listaParametros);

                TraerTodasFamiliaPatente = unaConexion.EjecutarTupla<FamiliaPatente>
                   ("SELECT * FROM FamiliaPatente", new List<Parametro>());

                TraerTodasFamiliaFamilia = unaConexion.EjecutarTupla<FamiliaFamilia>(("SELECT * FROM FamiliaFamilia"), new List<Parametro>());


                foreach (var item in TraerTodasFamiliaPatente)
                {
                    // Guardo las relaciones de las Familias con las Patentes
                    var mm = TraerTodasPatentes.Find(x => x.Id == item.IdPatente);
                    // Agrego la Patente a la Familia
                    TraerTodasFamilias.Find(o => o.Id == item.IdFamilia).Agregar(mm);
                }


                foreach (var item in TraerTodasFamiliaFamilia)
                {
                    // Guardo las relaciones de las Familias con las Familias Hijas
                    var mm = TraerTodasFamilias.Find(x => x.Id == item.IdFamiliaHijo);
                    // Agrego la Familia hija a la Familia
                    TraerTodasFamilias.Find(o => o.Id == item.IdFamilia).Agregar(mm);
                }

                foreach (var item in resultadoUsuarioFamilia)
                {
                    // Guardo las relaciones de los Usuarios con las Familias
                    var xx = TraerTodasFamilias.Find(x => x.Id == item.IdFamilia);

                    if (xx != null)
                        // Agrego la Familia a la lista que será el Perfil del Usuario
                        PatentesAFamilias.Agregar(xx);
                }

                // Le pego el perfil al usuario
                elUsuario.Perfil = PatentesAFamilias;
            }
            catch (Exception ex)
            {
                return null;
            }

            finally
            {
            }
            return elUsuario;
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

                    if (Item.GetType() == typeof(Familia2))
                    {
                        listaParametros2.Add(new Parametro("@IdUsuario", unUsuario.iduser));
                        listaParametros2.Add(new Parametro("@IdFamilia", Item.Id));
                        unaConexion.EjecutarSinResultado("INSERT INTO UsuarioFamilia (IdUsuario, IdFamilia) VALUES (@IdUsuario, @IdFamilia)", listaParametros2);
                    }
                    else if (Item.GetType() == typeof(Patente2))
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




        ///nuevo
        ///
        //
        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = ".\\SQLEXPRESS";
            cs.InitialCatalog = "PruebaSIUNCA";
            return cs.ConnectionString;
        }

        public List<Usuario> GetAll()
        {
            var cnn = new SqlConnection(GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var sql = $@"select * from tbl_user;";

            cmd.CommandText = sql;

            var reader = cmd.ExecuteReader();

            var lista = new List<Usuario>();

            while (reader.Read())
            {
                Usuario c = new Usuario();
                c.iduser = reader.GetInt32(reader.GetOrdinal("iduser"));
                c.username = reader.GetString(reader.GetOrdinal("username"));
                lista.Add(c);
            }

            reader.Close();
            cnn.Close();

            //vinculo los usuarios con las patentes y familias que tiene configuradas.
            //foreach (var item in lista)
            //{
            //    repoPermisos.FillUserPermissions(item);
            //}



            return lista;
        }
        public void GuardarPermisos2(Usuario u)
        {

            try
            {
                var cnn = new SqlConnection(GetConnectionString());
                cnn.Open();

                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $@"delete from usuarios_permisos where id_usuario=@id;";
                cmd.Parameters.Add(new SqlParameter("id", u.iduser));
                cmd.ExecuteNonQuery();

                foreach (var item in u.Permisos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    cmd.CommandText = $@"insert into usuarios_permisos (id_usuario,id_permiso) values (@id_usuario,@id_permiso) "; ;
                    cmd.Parameters.Add(new SqlParameter("id_usuario", u.iduser));
                    cmd.Parameters.Add(new SqlParameter("id_permiso", item.Id));

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        ////
        ///

    }
}
