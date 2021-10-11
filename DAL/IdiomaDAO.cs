using Framework.D_2015.Multiidioma;
using Framework.D_2015.Persistencia;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DAL
{
    public class IdiomaDAO
    {
        public List<Idioma> ListarIdiomas()
        {
            List<Idioma> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                resultado = unaConexion.EjecutarTupla<Idioma>("SELECT Id, Nombre FROM Idioma", new List<Parametro>());
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            // Dim log As New EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error)
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }


        public static void CargarDiccionario(Idioma pIdioma)
        {
            //"select Palabra_Texto, Traduccion_Palabra from Palabra inner join Traduccion on IdPalabra = IdPalabra_Traduccion where IdIdioma = " + pIdioma.IdIdioma;

        }

        public static List<Traduccion> ObtenerTraducciones(IIdioma idioma)
        {
            List<Traduccion> resultado_traducciones = new List<Traduccion>();
            var con = new Conexion("config.xml");
            con.ConexionIniciar();


            List<Parametro> listaParametrosCD = new List<Parametro>();
            listaParametrosCD.Add(new Parametro("Id", idioma.Id));

            try
            {
                //aca deberia hacer un TRADUCCIONDTO para mapear palabra_texto Traduccionpalabra)
                resultado_traducciones = con.EjecutarTupla<Traduccion>(@"select Palabra_Texto, PalabraTraducida from Palabra inner join 
                                                                        Traduccion on IdPalabra = IdPalabra_Traduccion where IdIdioma = @Id ", listaParametrosCD);

                //select Palabra_Texto, PalabraTraducida from Palabra inner join Traduccion on IdPalabra = IdPalabra_Traduccion where IdIdioma = @Id

                                                       
                return resultado_traducciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al traer traducciones" + ex);
                return null;
            }
            finally
            {
                con.ConexionFinalizar();
            }
        }

        public static List<ITraduccion> ObtenerTraducciones2(IIdioma idioma)
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.InitialCatalog = "PruebaSIUNCA";
            cs.DataSource = ".\\SQLEXPRESS";
            cs.IntegratedSecurity = true;

            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = cs.ConnectionString;
            IDataReader reader = null;
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = @"select Palabra_Texto, PalabraTraducida from Palabra inner join 
                                                                        Traduccion on IdPalabra = IdPalabra_Traduccion where IdIdioma = @Id  ";
                cmd.Parameters.AddWithValue("Id", idioma.Id);

                reader = cmd.ExecuteReader();

                var listaTraducciones = new List<Traduccion>();
                while (reader.Read())
                {
                    var unaTraduccion = new Traduccion();
                    //unaTraduccion.IdPalabra_Traduccion = Int32.Parse(reader["username"].ToString());
                    unaTraduccion.PalabraTraducida = reader["PalabraTraducida"].ToString();
                    unaTraduccion.Palabra_Texto = reader["Palabra_Texto"].ToString();
                    listaTraducciones.Add(unaTraduccion);

                }
                return listaTraducciones.ConvertAll(o => (ITraduccion)o);
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (sql != null)
                    sql.Close();
            }
        }

        public static List<ITraduccion> ObtenerTraducciones1(IIdioma idioma)
        {
            List<Traduccion> resultado_traducciones1 = new List<Traduccion>();

            //var foo = Traduccion as ITraduccion;
            var con = new Conexion("config.xml");
            con.ConexionIniciar();


            List<Parametro> listaParametrosCD = new List<Parametro>();
            listaParametrosCD.Add(new Parametro("Id", idioma.Id));

            try
            {
                //aca deberia hacer un TRADUCCIONDTO para mapear palabra_texto Traduccionpalabra)
                resultado_traducciones1 = con.EjecutarTupla<Traduccion>(@"select Palabra_Texto, PalabraTraducida from Palabra inner join 
                                                                        Traduccion on IdPalabra = IdPalabra_Traduccion where IdIdioma = @Id ", listaParametrosCD);

                //select Palabra_Texto, PalabraTraducida from Palabra inner join Traduccion on IdPalabra = IdPalabra_Traduccion where IdIdioma = @Id

                //convierto el resultado en ITraduccion
                return resultado_traducciones1.ConvertAll(o => (ITraduccion)o);
                //resultado_traducciones.Add(resultado_traducciones1);
                //return resultado_traducciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al traer traducciones" + ex);
                return null;
            }
            finally
            {
                con.ConexionFinalizar();
            }
        }

        public List<Palabra> TraerPalabrasBase()
        {
            throw new NotImplementedException();
        }

        public string BuscarTraduccionPalabraIdioma(int idPalabra, int idIdioma)
        {
            throw new NotImplementedException();
        }



        public void AgregarIdioma(Idioma idioma)
        {
            throw new NotImplementedException();
        }

        public void AgregarTraduccion(int idPalabra, int idIdioma, string traduccion)
        {
            throw new NotImplementedException();
        }

        public bool ComprobarExistenciaTraduccion(int idPalabra, int idIdioma)
        {
            throw new NotImplementedException();
        }

        public void CambiarIdiomaUsuario(string nombreUsuario, int idIdioma)
        {
            throw new NotImplementedException();
        }

        public static Idioma ObtenerIdiomaPorId(int id)
        {
            List<Idioma> resultado = new List<Idioma>();

            Idioma resultado2 = new Idioma();
            int ID;
            Idioma unIdioma = new Idioma();
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("Id", id));
                resultado = unaConexion.EjecutarTupla<Idioma>("SELECT Nombre FROM Idioma WHERE Id = (@Id)", listaParametrosCD);

                resultado2 = unaConexion.EjecutarEscalar<Idioma>("SELECT Nombre FROM Idioma WHERE Id = (@Id)", new List<Parametro>());
                //CacheUsuario.iduser = listaUsuario.Select(x => x.iduser).FirstOrDefault();
                //unIdioma.Id = resultado.Select(x => x.Id).FirstOrDefault();
                var asd = unIdioma.Id;
            }
            catch (Exception ex)
            {
                // EventViewer log = new EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error);
                //Interaction.MsgBox("error al traer el nombre y apellido del alumno");
                MessageBox.Show("error traer idioma", ex.ToString());

            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
            return resultado2;
        }

    }
}
