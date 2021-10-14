using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.GestoresSeguridad
{
    public class DigitoVerificadorDAO
    {
        public int TraerDvv(string tabla)
        {
            //try
            //{
            //    AbrirConec();
            //    Command = new SqlCommand();
            //    Command.Connection = ConString;
            //    Command.Parameters.AddWithValue("tabla", tabla);
            //    Command.CommandText = "select dvv from Dvv where nombreTabla = @tabla";
            //    Command.CommandType = CommandType.Text;
            //    var reader = Command.ExecuteReader();
            //    var dv = default(int);
            //    while (reader.Read())
            //    {
            //        dv = new int();
            //        dv = Conversions.ToInteger(reader[0]);
            //    }

            //    reader.Close();
            //    CerrarConec();
            //    return dv;
            //}
            //catch (SqlException ex)
            //{
            //    Interaction.MsgBox(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Interaction.MsgBox(ex);
            //}

            return default;
        }

        public void ActualizarDvv(string tabla, int valor)
        {
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
