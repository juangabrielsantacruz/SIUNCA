using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;
using Framework.D_2015;
using BLL;
//Using necesarios para el idioma
using System.Threading;
using System.Globalization;
using GUI.Idiomas.Login;
using Framework.D_2015.Idiomas;
using Framework.D_2015.Seguridad;
using Framework.D_2015.Cache;
using BIZ.Seguridad;
using Framework.D_2015.Generadores;
using Framework.D_2015.Multiidioma;

namespace GUI
{
    public partial class Login : Form
    {
        //variables para la funcion arrastrarForm(e, x , y)
        int x = 0, y = 0;

        public Login()
        {
            InitializeComponent();
            lblError.Visible = false;
            cboIdioma.SelectedIndex = IdiomaViejo.cacheIdioma == "Español" ? 0 : 1;
            cboRol.SelectedIndex = 2;
            IdiomaViejo.cambiarIdioma(IdiomaViejo.cacheIdioma, IdiomaPorDefecto);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var usuario = new Usuario();

            usuario.email = txtUsuario.Text;
            usuario.password = Hash.getSHA256(txtContraseña.Text);
            usuario.rol = cboRol.Text;

            var gestorUsuario = new GestorUsuario();
            var resultadoUser = gestorUsuario.traerUsuario(usuario);

            //traigo el usuario de la sesion logueada
            var UsuarioSingleton = SesionSingleton.Instancia.usuario;

            if (resultadoUser != null)
            {
                //GestorUsuario unGestorUsuario = new GestorUsuario();

                // Logueo (traigo perfil) del Usuario
                //var resultadoUserPerfil = unGestorUsuario.Login(resultadoUser);

                // En base a las Id de las Patenteas voy validando la visibilidad de los controles
                // porque .Validar devuelve un boolean.
                // En este caso usé Id como Integer, pero podría usarse Strings cambiando la
                // BD y los DTO en consecuencia
                // Si tiene Patente 1 puede ver boton 1
                // 
                
                // SI usuario TIENE ID 1 (de patente) button 3.visible=true
                // button3.visible = usuarioSimulado.Perfil.Validar(1)

                //instancio los formularios
                frmSecretarioAcademico frmAdministrativo = new frmSecretarioAcademico();
                frmProfesor frmProfe = new frmProfesor();


                //validar permisos en la bll
                //UNBLL.habilitarpermisos(resultadoUser);

                //si usuario tiene la Patente de ID 1 muestra form secretario
                frmAdministrativo.Visible = SesionSingleton.Instancia.usuario.Perfil.Validar(1);
                //si usuario tiene la Patente de ID 9 muestra form profesor
                frmProfe.Visible = UsuarioSingleton.Perfil.Validar(9);


                //button1.Visible = resultadoUser.Perfil.Validar(1);
                //button2.Visible = resultadoUser.Perfil.Validar(2);
                //button8.Visible = resultadoUser.Perfil.Validar(3);
                //button9.Visible = resultadoUser.Perfil.Validar(4);
                //button10.Visible = resultadoUser.Perfil.Validar(10);
            }
            else
            {
                lblError.Visible = true;
                
            }



        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            arrastrarForm(e, ref x, ref y);
        }

        private void panelFooter_MouseMove(object sender, MouseEventArgs e)
        {
            arrastrarForm(e, ref x, ref y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            arrastrarForm(e, ref x, ref y);
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdiomaViejo.cacheIdioma = cboIdioma.Text;
            IdiomaViejo.cambiarIdioma(IdiomaViejo.cacheIdioma, IdiomaPorDefecto);
        }

        /// <summary>
        /// El idioma por defecto es español, el archivo por defecto es Res.resx
        /// </summary>
        void IdiomaPorDefecto()
        {
            lblIdioma.Text = Res.lblIdioma;
            lblInicioDeSesion.Text = Res.lblInicioDeSesion;
            lblUsuario.Text = Res.lblUsuario;
            lblContraseña.Text = Res.lblContraseña;
            lblRol.Text = Res.lblRol;
            lblError.Text = Res.lblError;
            btnLogin.Text = Res.btnLogin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var unaConexion= new Conexion(Conexion.EstrategiasDbEnum.SqlServer, "pruebaservidor", "catalogo", "usuario", "clave");
            //unaConexion.GenerarArchivoConfiguracion(Conexion.EstrategiasDbEnum.SqlServer, "pruebaservidor", "catalogo", "usuario", "clave");
            //var ungenerador = new GeneradorXML();
            //ungenerador.GeneradorXMLDBConfig("tipodb", "server", "catarloggo", "usuarioo", "contrasena");




        }

        /// <summary>
        /// Metodo para arrastrar el form desde cualquier parte del loguin
        /// </summary>
        /// <param name="e">evento MouseEventArgs</param>
        /// <param name="x">valor por referencia del eje horizontal</param>
        /// <param name="y">valor por referencia del eje vertical</param>
        public void arrastrarForm(MouseEventArgs e, ref int x, ref int y)
        {
            if (e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else
            {
                Left = Left + (e.X - x);
                Top = Top + (e.Y - y);
            }
        }
    }
}
