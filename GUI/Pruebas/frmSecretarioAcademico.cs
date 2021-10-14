using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.D_2015.Cache;
using Framework.D_2015.Idiomas;
using GUI.UserControlSecretarioAcademico;
using GUI.Seguridad;
using BLL;
using BIZ;
using BIZ.Seguridad;

namespace GUI
{
    public partial class frmSecretarioAcademico : Form
    {

        //variables para la funcion arrastrarForm(e, x, y)
        int x = 0, y = 0;

        //instancias necesarias para el metodo seleccionaUserontrol(UserControl)
        UCMaterias ucmaterias = new UCMaterias();
        UCPlanDeEstudio ucplandeestudio = new UCPlanDeEstudio();
        UCAlumnos ucalumnos = new UCAlumnos();
        UCCursos uccursos = new UCCursos();
        UCPerfilesUsuarios ucperfilesusuarios = new UCPerfilesUsuarios();


        public frmSecretarioAcademico()
        {
            InitializeComponent();
            seleccionarUserControl(ucplandeestudio);
            this.lblSecretarioAcademico.Text = ManejadorSesion.GetInstancia.usuario.email;

            //IdiomaViejo.cambiarIdioma(IdiomaViejo.cacheIdioma, IdiomaPorDefecto);


            //aca deberia traer el usuario de sesion singleton

            //var usuario = new Usuario();

            //usuario.iduser = CacheUsuario.iduser;
            //usuario.password = CacheUsuario.password;

            //GestorUsuario unGestorUsuario = new GestorUsuario();
            // var resultadoUser = unGestorUsuario.traerUsuario(usuario);            

            // Logueo (traigo perfil) del Usuario
            //var resultadoUserPerfil = unGestorUsuario.Login(usuario);

            // En base a las Id de las Patenteas voy validando la visibilidad de los controles
            // porque .Validar devuelve un boolean.
            // En este caso usé Id como Integer, pero podría usarse Strings cambiando la
            // BD y los DTO en consecuencia
            // Si tiene Patente 1 puede ver boton 1

            // SI usuario TIENE ID 1 (de patente) button 3.visible=true
            // button3.visible = usuarioSimulado.Perfil.Validar(1)

            //aca deberia llamar al usuario singleton
            //habilitarbotones()
            btnUSUARIOS.Visible = ManejadorSesion.GetInstancia.usuario.Perfil.Validar(3);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
            this.WindowState = FormWindowState.Maximized;
            }
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    
        

        /// <summary>
        /// Metodo para desilzar slider sobre el menu
        /// </summary>
        /// <param name="height">parametro de la altura del boton</param>
        /// <param name="top">parametro para la el tope del boton</param>
        public void moverSlider(int height, int top)
        {
            ////codigo para selector de menu///
            slideMenu.Height = height;
            slideMenu.Top = top;
        }


        /// <summary>
        /// Metodo para arrastrar el form desde el menu lateral y el header
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


        private void button1_Click(object sender, EventArgs e)
        {
            moverSlider(btnPlanDeEstudio.Height, btnPlanDeEstudio.Top);

            seleccionarUserControl(ucplandeestudio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moverSlider(btnMaterias.Height, btnMaterias.Top);

            seleccionarUserControl(ucmaterias);
        }
        private void btnCursos_Click(object sender, EventArgs e)
        {
            moverSlider(btnCursos.Height, btnCursos.Top);

            seleccionarUserControl(uccursos);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            moverSlider(btnAlumnos.Height, btnAlumnos.Top);

            seleccionarUserControl(ucalumnos);
        }

        private void panelHeader2_MouseMove(object sender, MouseEventArgs e)
        {
            arrastrarForm(e, ref x, ref y);
        }

        private void panelMenu_MouseMove(object sender, MouseEventArgs e)
        {
            arrastrarForm(e, ref x, ref y);
        }


        private void panelHeader1_MouseMove(object sender, MouseEventArgs e)
        {
            arrastrarForm(e, ref x, ref y);
        }

        private void PanelHeader1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SlideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PanelHeader2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Hide();
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }



        /// <summary>
        /// metodo para traer al panelcontenedor el usercontrol seleccionado en
        /// el menu lateral
        /// </summary>
        /// <param name="uc">instancia de un usercontrol</param>
        public void seleccionarUserControl(UserControl uc)
        {
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(uc);
        }

        private void BtnUSUARIOS_Click(object sender, EventArgs e)
        {
            moverSlider(btnMaterias.Height, btnMaterias.Top);

            seleccionarUserControl(ucperfilesusuarios);
        }

        //void IdiomaPorDefecto()
        //{
        //    btnPlanDeEstudio.Text = Res.btnPlanDeEstudio;
        //    btnMaterias.Text = Res.btnMaterias;
        //    btnCursos.Text = Res.btnCursos;
        //    btnAlumnos.Text = Res.btnAlumnos;
 
        //    //lblProfesor.Text = Res.lblProfesor;
        //    //btnAsistencias.Text = Res.btnAsistencias;
        //    //btnFinales.Text = Res.btnFinales;
        //    //btnParciales.Text = Res.btnParciales;
        //    //btnRecuperatorios.Text = Res.btnRecuperatorios;
        //}
    }
}
