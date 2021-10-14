using BIZ;
using BIZ.Seguridad;
using BLL;
using Framework.D_2015.Multiidioma;
using Framework.D_2015.Seguridad;
using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        Usuario unUsuario = new Usuario();
        GestorUsuario gestorUsuario = new GestorUsuario();
        Idioma unidioma = new Idioma();

        public frmLogin()
        {
            InitializeComponent();
            txtContrasena.Text = "a";
            txtUsuario.Text = "admin";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            unUsuario.username = txtUsuario.Text;
            unUsuario.password = txtContrasena.Text;

            // Logueo (traigo perfil y creo sesion) del Usuario
            Usuario resultadoUser = gestorUsuario.IniciarSesion(unUsuario);                  

            if (resultadoUser != null)
            {
                ManejadorSesion.GetInstancia.CambiarIdioma(unidioma);
                frmInicio frmINICIO = new frmInicio();
                frmINICIO.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrecta");
            }
        }

        private void cboIdioma_SelectedValueChanged(object sender, EventArgs e)
        {
            unidioma = (Idioma)cbIdioma.SelectedItem;
            unidioma.Traducciones = GestorIdioma.ObtenerTraducciones2(unidioma);

            Actualizar(unidioma);
        }

        public void Actualizar(IIdioma idiomaObservado)
        {
            //Recorro todos los controles en el UserControl
            foreach (Control item in this.Controls)
            {
                if (item.Tag != null)
                {
                    item.Text = idiomaObservado.BuscarTraduccion(item.Tag.ToString());
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {            
            cbIdioma.DataSource = GestorIdioma.ObtenerIdiomas();
            cbIdioma.DisplayMember = "Nombre";
            unidioma.Traducciones = GestorIdioma.ObtenerTraducciones2((Idioma)cbIdioma.SelectedItem);

            Actualizar(unidioma);
        }
    }
}
