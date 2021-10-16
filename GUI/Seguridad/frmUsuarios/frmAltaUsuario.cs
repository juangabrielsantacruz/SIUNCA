using BIZ;
using BIZ.Seguridad;
using BLL;
using BLL.GestoresSeguridad;
using Framework.D_2015.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Seguridad.frmUsuarios
{
    public partial class frmAltaUsuario : Form
    {
        GestorUsuario gestorusuario = new GestorUsuario();
        GestorBitacora unGestorBitacora = new GestorBitacora();
        ManejadorSesion sesion = ManejadorSesion.GetInstancia;
        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            try
            {
                usuario.username = txtUsername.Text;
            usuario.password = Hash.getSHA256(txtPasword.Text);
            usuario.email = txtMail.Text;

            gestorusuario.guardarUsuario(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuario.");
            }
            finally
            {   
                //agrego bitacota                
                //unGestorBitacora.AgregarBitacora1(sesion.usuario.iduser, 1, DateTime.Now, "Se probó una conexion con la base");
                unGestorBitacora.AgregarBitacora1(sesion._usuario.iduser, 1, DateTime.Now, $"Se agrego el usuario {usuario.username}");
                MessageBox.Show("El usuario ha sido guardado con exito");
            }
           

            //Limpiar textbox
            txtMail.Text = "";
            txtPasword.Text = "";
            txtUsername.Text = "";
        }
    }
}
