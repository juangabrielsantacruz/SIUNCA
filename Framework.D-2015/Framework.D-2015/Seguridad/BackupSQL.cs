using System.Data.SqlClient;

namespace Framework.D_2015.Seguridad
{
    public class BackupSQL
    {
        public string servidor { get; set; }
        public string baseDatos { get; set; }
        public string ruta { get; set; }

        /// <summary>
        /// Realiza un Backup full de la Base de Datos
        /// </summary>
        /// <param name="cadenaConexion"></param>
        /// <remarks></remarks>
        public void realizarBackup(string cadenaConexion)
        {
            var con = new SqlConnection(cadenaConexion);
            con.Open();
            string strQuery = "backup database " + baseDatos + " to disk='" + ruta + "'";
            SqlCommand cmd;
            cmd = new SqlCommand(strQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Realiza una restauración de la Base de Datos
        /// </summary>
        /// <param name="cadenaConexion"></param>
        /// <remarks></remarks>
        public void restaurarBackup(string cadenaConexion)
        {
            var con = new SqlConnection(cadenaConexion);
            con.Open();

            // 'Dim strQuery = "RESTORE DATABASE " & baseDatos & " FROM disk='" & ruta & "'"
            string strQuery = "ALTER DATABASE " + baseDatos + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;  RESTORE DATABASE " + baseDatos + " FROM disk='" + ruta + "'";
            SqlCommand cmd;
            cmd = new SqlCommand(strQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}