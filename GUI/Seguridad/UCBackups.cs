using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.D_2015.Seguridad;
using System.Data.SqlClient;
using BLL.GestoresSeguridad;
using Framework.D_2015.Cache;

namespace GUI.Seguridad
{
    public partial class UCBackups : UserControl
    {
        public UCBackups()
        {
            InitializeComponent();
            
        }
        BackupSQL backup = new BackupSQL();
        private string cadenaConexion = null;
        private SqlConnection conexion;

        //public const string vbNewLine = vbCrLf;

        //public const string vbCrLf = vbCrLf;


        private void Button4_Click(object sender, EventArgs e)
        {
            backup.servidor = txtServidor.Text;

            // Debe haber un servidor seleccionado
            if (backup.servidor == "")
            {
                MessageBox.Show("Seleccione un servidor", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Autenticacion Windows
            if (rbWindows.Checked == true)
            {
                try
                {
                    // Prueba la conexion
                    cadenaConexion = "Server=" + backup.servidor + "; Integrated Security=SSPI";
                    conexion = new SqlConnection(cadenaConexion);
                    conexion.Open();
                    //txtStatus.AppendText("La prueba de conexion fue exitosa" + Constants.vbCrLf);
                    txtStatus.AppendText(" // La prueba de conexion fue exitosa // ");
                    conexion.Close();

                    //agrego bitacota
                    GestorBitacora unGestorBitacora = new GestorBitacora();
                    unGestorBitacora.AgregarBitacora1(CacheUsuario.iduser, 1, DateTime.Now, "Se probó una conexion con la base");
                }
                catch (Exception ex)
                {
                    //txtStatus.AppendText("Pueba de Conexion fallida" + Constants.vbCrLf);
                    txtStatus.AppendText(" // Prueba de Conexion fallida // ");
                    conexion.Close();
                    return;
                }
            }
            else if (rbWindows.Checked == false && rbSQL.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una autenticacion");
            }

            // Autenticacion SQL SERVER
            if (rbSQL.Checked == true)
            {
                if (txtUser.Text == "")
                {
                    // Request user to enter a password
                    MessageBox.Show("Ingrese el nombre de usuario", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Contraseña
                if (txtContrasenia.Text == "")
                {
                    MessageBox.Show("Ingrese la contraseña del usuario ", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Prueba la conexion
                    cadenaConexion = "Server=" + backup.servidor + "; Integrated Security=False;" + "User ID=" + txtUser.Text + "; " + "Password=" + txtContrasenia.Text;
                    conexion = new SqlConnection(cadenaConexion);
                    conexion.Open();
                }
                catch (SqlException ex)
                {
                   // txtStatus.AppendText("Prueba de Conexion fallida" + Constants.vbCrLf);
                    txtStatus.AppendText(" // Prueba de Conexion fallida // ");
                    conexion.Close();
                    return;
                }
            }


            
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            backup.servidor = txtServidor.Text;
            backup.baseDatos = cbBD.Text;


            if (rbWindows.Checked)
                cadenaConexion = "Data Source=" + backup.servidor + ";Integrated Security=SSPI";


            if (rbSQL.Checked)
                cadenaConexion = "Data Source=" + backup.servidor + "; Integrated Security=False;" + "User ID=" + txtUser.Text + "; " + "Password=" + txtContrasenia.Text;

            // Se elige la ruta de destino del backup

            SaveFileDialog cuadroDialogo = new SaveFileDialog();
            cuadroDialogo.FileName = backup.baseDatos;
            cuadroDialogo.ShowDialog();
            backup.ruta = cuadroDialogo.FileName;

            try
            {
                txtStatus.AppendText("Backup de la Base de Datos " + backup.baseDatos + " en progreso...");

                // REALIZA EL BACKUP
                backup.realizarBackup(cadenaConexion);

                //mensajes


                txtStatus.AppendText("Base de Datos " + backup.baseDatos + " copiado exitosamente / ");
                MessageBox.Show("Base de Datos " + backup.baseDatos + " copiado exitosamente", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtStatus.AppendText("Backup de " + backup.baseDatos + " exitoso / ");
            }

            catch (ApplicationException ex)
            {
                txtStatus.AppendText("Backup de " + backup.baseDatos + " fallido / " );
                MessageBox.Show("Backup de la Base de Datos " + backup.baseDatos + " fallido", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("Error al realizar backup", ex.Message.ToString());
            }

            catch (AccessViolationException ex)
            {
                txtStatus.AppendText("Backup de " + backup.baseDatos + " fallido / " );
                MessageBox.Show("Backup de la Base de Datos " + backup.baseDatos + " fallido", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                MessageBox.Show("Error al realizar backup", ex.Message.ToString());
            }

            catch (SqlException ex)
            {
                txtStatus.AppendText("Backup de " + backup.baseDatos + " fallido / " );
                MessageBox.Show("Backup de la Base de Datos " + backup.baseDatos + " fallido", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("Error al realizar backup", ex.Message.ToString());
            }


        }

        private void BtnBasesDeDatos_Click(object sender, EventArgs e)
        {
            try
            {
                cbBD.Items.Clear();
                // asignamos la lista de servidores como origen de datos del combobox
                string consulta;

                cadenaConexion = "data source=" + txtServidor.Text + " ;integrated security=true;initial catalog=master";

                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    // abrimos la conexión
                    con.Open();
                    // obtenemos los nombres de las bases de datos que haya en el servidor
                    consulta = "select name from sys.databases;";
                    SqlCommand com = new SqlCommand(consulta, con);
                    SqlDataReader dr = com.ExecuteReader();

                    while ((dr.Read()))
                        cbBD.Items.Add(dr[0].ToString());
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error al buscar base de datos", ex.Message.ToString());
            }
           
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            backup.servidor = txtServidor.Text;


            if (rbWindows.Checked)
                cadenaConexion = "Data Source=" + backup.servidor + ";Integrated Security=SSPI";


            if (rbSQL.Checked)
                cadenaConexion = "Data Source=" + backup.servidor + "; Integrated Security=False;" + "User ID=" + txtUser.Text + "; " + "Password=" + txtContrasenia.Text;


            // Se elige la ruta donde está el archivo a restaurar
            OpenFileDialog cuadroDialogo = new OpenFileDialog();
            cuadroDialogo.ShowDialog();

            // Se obtiene sólo el nombre sin la extensión .bak , para que no dé error en la query
            backup.baseDatos = System.IO.Path.GetFileNameWithoutExtension(cuadroDialogo.FileName);
            backup.ruta = cuadroDialogo.FileName;

            try
            {
                txtStatus.AppendText("Restauracion de la Base de Datos " + backup.baseDatos + " en progreso... ");

                // RESTAURA LA BASE DE DATOS
                backup.restaurarBackup(cadenaConexion);

                //mensaje de restore
                txtStatus.AppendText("Base de Datos " + backup.baseDatos + " restaurada exitosamente / ");
                MessageBox.Show("Base de Datos " + backup.baseDatos + " restaurada exitosamente", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ApplicationException ex)
            {
                txtStatus.AppendText("Restauracion de la Base de Datos " + backup.baseDatos + " fallido / " );
                MessageBox.Show("Restauracion de la Base de Datos " + backup.baseDatos + " fallido", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("Error al realizar restore", ex.Message.ToString());
            }

            catch (AccessViolationException ex)
            {
                txtStatus.AppendText("Restauracion de la Base de Datos " + backup.baseDatos + " fallido / " );
                MessageBox.Show("Restauracion de la Base de Datos " + backup.baseDatos + " fallido", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("Error al realizar restore", ex.Message.ToString());
            }

            catch (SqlException ex)
            {
                txtStatus.AppendText("Restauracion de la Base de Datos " + backup.baseDatos + " fallido / " );
                MessageBox.Show("Restauracion de la Base de Datos " + backup.baseDatos + " fallido", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("Error al realizar restore, el archivo .bak debe llamarse igual a la base de datos.", ex.Message.ToString());
            }

        }
    }
}
