using System.Collections.Generic;
using Framework.D_2015.Serializadores;
using Microsoft.VisualBasic.CompilerServices;

namespace Framework.D_2015.Persistencia
{
    public class Conexion
    {
        public enum EstrategiasDbEnum
        {
            SqlServer
        }

        private IProveedorBD _estrategiaConexion;

        public Conexion(EstrategiasDbEnum estrategiaElegida, string servidor, string catalogo, string usuario, string clave)
        {
            var configuracion = new ConfiguracionDB();
            configuracion.Catalogo = catalogo;
            configuracion.Clave = clave;
            configuracion.Servidor = servidor;
            configuracion.TipoDeConexion = ((int)estrategiaElegida).ToString();
            configuracion.Usuario = usuario;
            GenerarConexion(configuracion);
        }

        public Conexion(EstrategiasDbEnum estrategiaElegida, string servidor, string catalogo)
        {
            var configuracion = new ConfiguracionDB();
            configuracion.Catalogo = catalogo;
            configuracion.Servidor = servidor;
            configuracion.TipoDeConexion = ((int)estrategiaElegida).ToString();
            GenerarConexion(configuracion);
        }

        public Conexion(string archivo)
        {
            string archivoConf = System.IO.File.ReadAllText(archivo);
            var serializador = new SerializadorXml();
            var configuracion = serializador.Deserealizar<ConfiguracionDB>(archivoConf);
            GenerarConexion(configuracion);
        }

        public void GenerarConexion(ConfiguracionDB configuracion)
        {
            EstrategiasDbEnum estrategiaElegida = (EstrategiasDbEnum)Conversions.ToInteger(configuracion.TipoDeConexion);
            switch (estrategiaElegida)
            {
                case EstrategiasDbEnum.SqlServer:
                    {
                        _estrategiaConexion = new ProveedorSql(configuracion.Servidor, configuracion.Catalogo);
                        break;
                    }
            }
        }

        public static void GenerarArchivoConfiguracion(EstrategiasDbEnum estrategiaElegida, string servidor, string catalogo, string usuario, string clave)
        {
            var Configuracion = new ConfiguracionDB();
            Configuracion.TipoDeConexion = ((int)estrategiaElegida).ToString();
            Configuracion.Servidor = servidor;
            Configuracion.Catalogo = catalogo;
            Configuracion.Usuario = usuario;
            Configuracion.Clave = clave;
            var deserializador = new SerializadorXml();
            deserializador.Serializar(Configuracion);
        }

        public void ConexionIniciar()
        {
            _estrategiaConexion.ConexionIniciar();
        }

        public void ConexionFinalizar()
        {
            _estrategiaConexion.ConexionFinalizar();
        }

        public void TransaccionIniciar()
        {
            _estrategiaConexion.TransaccionIniciar();
        }

        public void TransaccionAceptar()
        {
            _estrategiaConexion.TransaccionAceptar();
        }

        public void TransaccionCancelar()
        {
            _estrategiaConexion.TransaccionCancelar();
        }

        public void EjecutarSinResultado(string query, List<Parametro> parametros)
        {
            _estrategiaConexion.EjecutarSinResultado(query, parametros);
        }

        public T EjecutarEscalar<T>(string query, List<Parametro> parametros)
        {
            return _estrategiaConexion.EjecutarEscalar<T>(query, parametros);
        }

        public List<T> EjecutarTupla<T>(string query, List<Parametro> parametros) where T : new()
        {
            return _estrategiaConexion.EjecutarTupla<T>(query, parametros);
        }
    }
}