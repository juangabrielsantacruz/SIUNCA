using GUI.UserControlSecretarioAcademico;
using GUI.Seguridad;
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

namespace GUI
{
    
    public partial class frmSeguridad : Form
    {

        //variables para la funcion arrastrarForm(e, x, y)
        int x = 0, y = 0;

        //instancias necesarias para el metodo seleccionaUserontrol(UserControl)
        UCMaterias ucmaterias = new UCMaterias();
        UCPlanDeEstudio ucplandeestudio = new UCPlanDeEstudio();
        UCAlumnos ucalumnos = new UCAlumnos();
        UCCursos uccursos = new UCCursos();
        UCPerfilesUsuarios ucperfilesusuarios = new UCPerfilesUsuarios();
        UCBackups ucbackups = new UCBackups();
        UCBitacora ucbitacora = new UCBitacora();
        UCUsuarios ucusuarios = new UCUsuarios();

        public frmSeguridad()
        {
            InitializeComponent();
            seleccionarUserControl(ucperfilesusuarios);
            this.lblNombre.Text = CacheUsuario.username;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void BtnPlanDeEstudio_Click(object sender, EventArgs e)
        {
            moverSlider(btnPerfiles.Height, btnPerfiles.Top);

            seleccionarUserControl(ucperfilesusuarios);
        }

        private void BtnMaterias_Click(object sender, EventArgs e)
        {
            moverSlider(btnBackups.Height, btnBackups.Top);

            seleccionarUserControl(ucbackups);
        }

        private void BtnCursos_Click_1(object sender, EventArgs e)
        {
            moverSlider(btnBitacora.Height, btnBitacora.Top);

            seleccionarUserControl(ucbitacora);
        }

        private void BtnAlumnos_Click_1(object sender, EventArgs e)
        {
            moverSlider(btnGestionUsuarios.Height, btnGestionUsuarios.Top);

            seleccionarUserControl(ucusuarios);
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

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Hide();
        }

        private void BtnMaximizar_Click_1(object sender, EventArgs e)
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
    }
}
