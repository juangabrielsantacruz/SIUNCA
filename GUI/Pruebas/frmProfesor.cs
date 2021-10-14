using System;
using System.Windows.Forms;
using GUI.UserControlProfesor;
using System.Threading;
using System.Globalization;
using Framework.D_2015.Idiomas;
using Framework.D_2015.Cache;

namespace GUI
{
    public partial class frmProfesor : Form
    {
        //variables para la funcion arrastrarForm(e, x, y)
        int x = 0, y = 0;

        //Instancias necesarias para el metodo seleccionaUserontrol(UserControl)
        UCAsistencias ucasistencias = new UCAsistencias();
        UCParciales ucparciales = new UCParciales();
        UCRecuperatorios ucrecuperatorios = new UCRecuperatorios();
        UCFinales ucfinales = new UCFinales();

        public frmProfesor()
        {
            InitializeComponent();

            seleccionarUserControl(ucasistencias);

            this.lblNombreProfesor.Text = CacheUsuario.username;

            //IdiomaViejo.cambiarIdioma(IdiomaViejo.cacheIdioma, IdiomaPorDefecto);
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

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            moverSlider(btnAsistencias.Height, btnAsistencias.Top);
            seleccionarUserControl(ucasistencias);
        }

        private void btnParciales_Click(object sender, EventArgs e)
        {
            moverSlider(btnParciales.Height, btnParciales.Top);
            seleccionarUserControl(ucparciales);
        }

        private void btnRecuperatorios_Click(object sender, EventArgs e)
        {
            moverSlider(btnRecuperatorios.Height, btnRecuperatorios.Top);
            seleccionarUserControl(ucrecuperatorios);
        }

        private void btnFinales_Click(object sender, EventArgs e)
        {
            moverSlider(btnFinales.Height, btnFinales.Top);
            seleccionarUserControl(ucfinales);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Hide();
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

        //void IdiomaPorDefecto()
        //{
        //    lblProfesor.Text = Res.lblProfesor;
        //    btnAsistencias.Text = Res.btnAsistencias;
        //    btnFinales.Text = Res.btnFinales;
        //    btnParciales.Text = Res.btnParciales;
        //    btnRecuperatorios.Text = Res.btnRecuperatorios;
        //}
    }
}
