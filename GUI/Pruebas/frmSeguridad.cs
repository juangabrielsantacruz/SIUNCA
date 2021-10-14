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
using Interfaces;
using BIZ.Seguridad;
using Framework.D_2015.Multiidioma;
using BLL;

namespace GUI
{
    
    public partial class frmSeguridad : Form, IObservador
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

        private void button20_Click(object sender, EventArgs e)
        {
            



            ManejadorSesion sesion = ManejadorSesion.GetInstancia;

            sesion.idioma = (Idioma)cbIdioma.SelectedItem;

            //sesion.idioma.Traducciones = (GestorIdioma.ObtenerTraducciones1(sesion.idioma));

            sesion.idioma.Traducciones = (GestorIdioma.ObtenerTraducciones2(sesion.idioma));
            sesion.CambiarIdioma(sesion.idioma);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //load
            //registro usercontrol y traigo idiomas
            cbIdioma.DataSource = GestorIdioma.ObtenerIdiomas();
            cbIdioma.DisplayMember = "Nombre";
            ManejadorSesion.GetInstancia.RegistrarObservador(this);
            //cierroload

        }

        public void Actualizar(IIdioma idiomaObservado)
        {
            //Recorro todos los controles en el Form
            foreach (Control item in this.Controls)
            {
                //Pregunto si el form tiene controles hijos
                if (item.HasChildren) this.RecControles(item, idiomaObservado);
                if (item.Tag != null)
                {                   
                    item.Text = idiomaObservado.BuscarTraduccion(item.Tag.ToString());
                }
            }       
        }
        //Recorremos con un ciclo for each cada control que hay en la colección Controls
        public void RecControles(Control control, IIdioma idiomaObservado)
        {
            //Recorremos con un ciclo for each cada control que hay en la colección Controls
            foreach (Control contHijo in control.Controls)
            {
                //Preguntamos si el control tiene uno o mas controles dentro del mismo con la propiedad 'HasChildren'
                //Si el control tiene 1 o más controles, entonces llamamos al procedimiento de forma recursiva, para que siga recorriendo los demás controles
                if (contHijo.HasChildren) this.RecControles(contHijo, idiomaObservado);
                //Aqui va la lógica de lo queramos hacer
                if (contHijo.Tag != null)
                {
                    contHijo.Text = idiomaObservado.BuscarTraduccion(contHijo.Tag.ToString());
                }
            }
        }

        //private void BuscarControles()
        //{
        //    for (int i = 0; i < this.tabControl.TabPages.Count; i++)
        //    {
        //        this.Recorrer(this.tabControl.TabPages[i].Controls);
        //    }
        //}

        //private void Recorrer(Control.ControlCollection controls)
        //{
        //    for (int i = 0; i < controls.Count; i++)
        //    {
        //        if (controls[i].Controls != null && controls[i].Controls.Count > 0)
        //        {
        //            this.Recorrer(controls[i].Controls);
        //        }
        //        else
        //        {
        //            ListBox LB = controls[i] as ListBox;

        //            if (LB != null)
        //            {
        //                Clipboard.SetText(LB.SelectedItem.ToString());
        //            }

        //            //Aqui podes agregar codigo para los demas tipos de control
        //        }
        //    }
        //}

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
