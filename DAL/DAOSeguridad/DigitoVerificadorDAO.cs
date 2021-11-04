using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAOSeguridad
{
    public class DigitoVerificadorDAO
    {
        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = ".\\SQLEXPRESS";
            cs.InitialCatalog = "SIUNCA";
            return cs.ConnectionString;
        }

        public int TraerDvv(string tabla)
        {
            IDataReader reader = null;
            try
            {
                var cnn = new SqlConnection(GetConnectionString());
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                SqlTransaction Transaction;
                Transaction = cnn.BeginTransaction();

                cmd.Parameters.AddWithValue("tabla", tabla);

                var sql = $@"select dvv from Dvv where nombreTabla = @tabla";

                cmd.CommandText = sql;
                cmd.Transaction = Transaction;
                reader = cmd.ExecuteReader();

                if (!reader.Read()) return 0;

                //var unaCadena = "";
                int dv = 0;
                //while (reader.Read())
                //{
                    dv = reader.GetInt32(0);
                //}
                reader.Close();
                return dv;

                cnn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }


            return default;
        }

        public void ActualizarDvv(string tabla, int valor)
        {          
            try
            {               
                var cnn = new SqlConnection(GetConnectionString());
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                SqlTransaction Transaction;
                Transaction = cnn.BeginTransaction();

                cmd.Parameters.AddWithValue("tabla", tabla);
                cmd.Parameters.AddWithValue("valor", valor);

                var sql = $@"UPDATE Dvv SET dvv = @valor where nombreTabla = @tabla";

                cmd.CommandText = sql;
                cmd.Transaction = Transaction;
                cmd.ExecuteNonQuery();
 
                Transaction.Commit();
                cnn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }


            //AbrirConec();
            //SqlTransaction Transaction;
            //Transaction = ConString.BeginTransaction();
            //try
            //{
            //    Command = new SqlCommand();
            //    Command.Connection = ConString;
            //    Command.Parameters.AddWithValue("tabla", tabla);
            //    Command.Parameters.AddWithValue("valor", valor);
            //    Command.CommandText = "UPDATE Dvv SET dvv = @valor where nombreTabla = @tabla";
            //    Command.CommandType = CommandType.Text;
            //    Command.Transaction = Transaction;
            //    Command.ExecuteNonQuery();
            //    Transaction.Commit();
            //    CerrarConec();
            //}
            //catch (SqlException ex)
            //{
            //    Transaction.Rollback();
            //    Interaction.MsgBox(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Transaction.Rollback();
            //    Interaction.MsgBox(ex);
            //}
        }
    }
}
