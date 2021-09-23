using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Framework.D_2015.Persistencia
{
    public class ProveedorSql : IProveedorBD
    {
        private SqlConnection _sqlConnection;
        private SqlTransaction _sqlTransansaction;
        private string _servidor;
        private string _catalogo;

        public ProveedorSql(string servidor, string catalogo)
        {
            _servidor = servidor;
            _catalogo = catalogo;
        }

        public ProveedorSql()
        {
        }

        /// <summary>
        /// Metodo que obtiene la cadena de conexion (servidor, nombreBD, etc) desde el archivo
        /// app.config para iniciar la conexion a la BD
        /// </summary>
        public void ConexionIniciar()
        {
            string ObtenerConnectionString = ConfigurationManager.ConnectionStrings["default"].ToString();
            // '_sqlConnection = New SqlConnection(ObtenerConnectionString) ''Me.ObtenerCadenaConexion(_servidor, _catalogo))
            _sqlConnection = new SqlConnection(ObtenerCadenaConexion(_servidor, _catalogo));
            _sqlConnection.Open();
        }

        public void ConexionFinalizar()
        {
            _sqlConnection.Close();
        }

        public void TransaccionIniciar()
        {
            _sqlTransansaction = _sqlConnection.BeginTransaction();
        }

        public void TransaccionAceptar()
        {
            _sqlTransansaction.Commit();
        }

        public void TransaccionCancelar()
        {
            _sqlTransansaction.Rollback();
        }

        public void EjecutarSinResultado(string query, List<Parametro> parametros)
        {
            var unComando = new SqlCommand();

            // Preconfig...
            unComando.Connection = _sqlConnection;
            unComando.Transaction = _sqlTransansaction;
            unComando.CommandType = CommandType.Text;
            unComando.CommandText = query;
            foreach (var item in parametros)
            {
                var unParametro = new SqlParameter(item.NombreParametro, item.Valor);
                unComando.Parameters.Add(unParametro);
            }

            // Ejecucion...
            unComando.ExecuteNonQuery();
        }

        public T EjecutarEscalar<T>(string query, List<Parametro> parametros)
        {
            var unComando = new SqlCommand();

            // Preconfig...
            unComando.Connection = _sqlConnection;
            unComando.Transaction = _sqlTransansaction;
            unComando.CommandType = CommandType.Text;
            unComando.CommandText = query;
            foreach (var item in parametros)
            {
                var unParametro = new SqlParameter(item.NombreParametro, item.Valor);
                unComando.Parameters.Add(unParametro);
            }

            // Ejecucion...
            return (T)unComando.ExecuteScalar();
        }

        public List<T> EjecutarTupla<T>(string query, List<Parametro> parametros) where T : new()
        {
            var unComando = new SqlCommand();

            // Preconfig...
            unComando.Connection = _sqlConnection;
            unComando.Transaction = _sqlTransansaction;
            unComando.CommandType = CommandType.Text;
            unComando.CommandText = query;
            foreach (var item in parametros)
            {
                var unParametro = new SqlParameter(item.NombreParametro, item.Valor);
                unComando.Parameters.Add(unParametro);
            }

            // Ejecucion...
            var resultadoDataReader = unComando.ExecuteReader();
            return MappearResultado<T>(resultadoDataReader);
        }

        private string ObtenerCadenaConexion(string server, string catalogo, string usuario, string clave)
        {
            return string.Format("Server={0};Database={1};User Id={2};Password={3};", server, catalogo, usuario, clave);
        }

        private string ObtenerCadenaConexion(string server, string catalogo)
        {
            return string.Format("Server={0};Database={1};Trusted_Connection=True;", server, catalogo);
        }

        private List<T> MappearResultado<T>(SqlDataReader resultadoDataReader) where T : new()
        {
            var resultado = new List<T>();

            // Recorro todos los rows.
            while (resultadoDataReader.Read())
            {

                // Creo un T.
                var unT = new T();

                // Recorro las columnas de la tabla.
                for (int i = 0, loopTo = resultadoDataReader.FieldCount - 1; i <= loopTo; i++)
                {

                    // A una instancia de T, pegarle cada una de estas propiedades...
                    string nombreColumna = resultadoDataReader.GetName(i);

                    // Obtengo la property
                    var propiedadInfo = unT.GetType().GetProperty(nombreColumna);

                    // Le pego el valor a esa property.
                    propiedadInfo.SetValue(unT, resultadoDataReader.GetValue(i));
                }

                resultado.Add(unT);
            }

            resultadoDataReader.Close();
            return resultado;
        }

        public IDictionary<T, T> EjecutarTupla2<T>(string query, List<Parametro> parametros) where T : new()
        {
            var unComando = new SqlCommand();

            // Preconfig...
            unComando.Connection = _sqlConnection;
            unComando.Transaction = _sqlTransansaction;
            unComando.CommandType = CommandType.Text;
            unComando.CommandText = query;
            foreach (var item in parametros)
            {
                var unParametro = new SqlParameter(item.NombreParametro, item.Valor);
                unComando.Parameters.Add(unParametro);
            }

            // Ejecucion...
            var resultadoDataReader = unComando.ExecuteReader();
            return MappearResultado2<T>(resultadoDataReader);
        }

        private IDictionary<T, T> MappearResultado2<T>(SqlDataReader resultadoDataReader) where T : new()
        {
            var resultado = new List<T>();

            // Recorro todos los rows.
            while (resultadoDataReader.Read())
            {

                // Creo un T.
                var unT = new T();

                // Recorro las columnas de la tabla.
                for (int i = 0, loopTo = resultadoDataReader.FieldCount - 1; i <= loopTo; i++)
                {

                    // A una instancia de T, pegarle cada una de estas propiedades...
                    string nombreColumna = resultadoDataReader.GetName(i);

                    // Obtengo la property
                    var propiedadInfo = unT.GetType().GetProperty(nombreColumna);

                    // Le pego el valor a esa property.
                    propiedadInfo.SetValue(unT, resultadoDataReader.GetValue(i));
                }

                resultado.Add(unT);
            }

            resultadoDataReader.Close();
            return (IDictionary<T, T>)resultado;
        }
    }
}