using Framework.D_2015.Multiidioma;
using Framework.D_2015.Persistencia;
using Interfaces;
using System;
using System.Collections.Generic;
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
