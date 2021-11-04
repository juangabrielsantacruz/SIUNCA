using GUI.Seguridad;
using GUI.Seguridad.frmBitacora;
using GUI.Seguridad.frmBackup;
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
using BIZ.Seguridad;
using Interfaces;
using BLL;
using Framework.D_2015.Multiidioma;
using GUI.Seguridad.frmUsuarios;
using BLL.GestoresSeguridad;
using GUI.PlanDeEstudio;

namespace GUI
{
    public partial class frmInicio : Form, IObservador
    {
        ManejadorSesion sesion = ManejadorSesion.GetInstancia;
        public frmInicio()
        {
            InitializeComponent();
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            Actualizar(sesion.idioma);
            //HabilitarPermisos();
            //registro usercontrol y traigo idiomas
            cbIdioma.DataSource = GestorIdioma.ObtenerIdiomas();
            cbIdioma.DisplayMember = "Nombre";


            //PermisosBLL bllPermisos = new PermisosBLL();
            //bllPermisos.FillUserComponents(ManejadorSesion.GetInstancia._usuario);    

            ManejadorSesion.GetInstancia.RegistrarObservador(this);
            ValidarPermisos();
        }


        void ValidarPermisos()
        {
            if (ManejadorSesion.IsLogged())
            {
                //this.mnuEjemplo.Visible = ManejadorSesion.GetInstancia.IsInRole(TipoPermiso.PuedeHacerF);
                this.btnAlumnos.Visible = ManejadorSesion.GetInstancia.IsInRole(TipoPermiso.PuedeHacerA);
                this.btnExit.Enabled = ManejadorSesion.GetInstancia.IsInRole(TipoPermiso.PuedeHacerC);
                //this.mnuC.Enabled = ManejadorSesion.GetInstancia.IsInRole(TipoPermiso.PuedeHacerC);
                //this.mnuD.Enabled = ManejadorSesion.GetInstancia.IsInRole(TipoPermiso.PuedeHacerD);
                if (ManejadorSesion.GetInstancia.IsInRole(TipoPermiso.PuedeHacerE) == false)
                {
                    //MessageBox.Show("no tiene permiso de E");
                }
                //this.mnuE.Enabled = ManejadorSesion.GetInstancia.IsInRole(TipoPermiso.PuedeHacerE);
                this.btnBitacora.Enabled = ManejadorSesion.GetInstancia.IsInRole(TipoPermiso.PuedeVerFormVentas);

            }
            else
            {
                //this.btnAlumnos.Visible = false;
                //this.btn.Enabled = false;
                //this.mnuB.Enabled = false;
                //this.mnuC.Enabled = false;
                //this.mnuD.Enabled = false;
                //this.mnuE.Enabled = false;
                //this.mnuG.Enabled = false;
                MessageBox.Show("no esta logeado");

            }
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmPrincipalUsuarios"] as frmPrincipalUsuarios) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPrincipalUsuarios"].BringToFront();
            }
            else
            {
                frmPrincipalUsuarios f1 = new frmPrincipalUsuarios();
                f1.MdiParent = this;
                f1.Show();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
          
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmPlanDeEstudio"] as frmPlanDeEstudio) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPlanDeEstudio"].BringToFront();
            }
            else
            {
                frmPlanDeEstudio frmSegu = new frmPlanDeEstudio();
                frmSegu.MdiParent = this;
                frmSegu.Show();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmPrincipalPerfiles"] as frmPrincipalPerfiles) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPrincipalPerfiles"].BringToFront();
            }
            else
            {
                frmPrincipalPerfiles frmSegu = new frmPrincipalPerfiles();
                frmSegu.MdiParent = this;
                frmSegu.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {   
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmBitacora"] as frmBitacora) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPrincipalPerfiles"].BringToFront();
            }
            else
            {
                frmBitacora frmBitacora = new frmBitacora();
                frmBitacora.MdiParent = this;
                frmBitacora.Show();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmBackup"] as frmBackup) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPrincipalPerfiles"].BringToFront();
            }
            else
            {
                frmBackup frmBitacora = new frmBackup();
                frmBitacora.MdiParent = this;
                frmBitacora.Show();
            }
        }

       
     

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            if (ManejadorSesion.GetInstancia.IsInRole(TipoPermiso.PuedeHacerA))
            {
                frmBackup frm = new frmBackup();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("no tiene permisos");
            }
        }


        private void HabilitarPermisos()
        {
            Usuario unUsuario = ManejadorSesion.GetInstancia._usuario;

            // Modulo Seguridad
            btnUsuarios.Enabled = unUsuario.Perfil.Validar(1);
            btnPerfiles.Enabled = unUsuario.Perfil.Validar(2);
            btnBackup.Enabled = unUsuario.Perfil.Validar(3);
            btnBitacora.Enabled = unUsuario.Perfil.Validar(4);

            // Modulo Secretario
            btnPlanEstudios.Enabled = unUsuario.Perfil.Validar(30);
            btnAlumnos.Enabled = unUsuario.Perfil.Validar(31);
            btnCursos.Enabled = unUsuario.Perfil.Validar(32);
            btnMaterias.Enabled = unUsuario.Perfil.Validar(33);

            // Modulo Profesor
            btnAsistencias.Enabled = unUsuario.Perfil.Validar(60);
            btnParciales.Enabled = unUsuario.Perfil.Validar(61);
            btnRecuperatorios.Enabled = unUsuario.Perfil.Validar(62);
            btnFinales.Enabled = unUsuario.Perfil.Validar(63);

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
            foreach (Control btn in panelProfesor.Controls)
            {
                if (btn.Tag != null)
                {
                    var traduccion = idiomaObservado.BuscarTraduccion(btn.Tag.ToString());
                    btn.Text = traduccion;
                }
            }
            foreach (Control btn in panelSecretario.Controls)
            {
                if (btn.Tag != null)
                {
                    var traduccion = idiomaObservado.BuscarTraduccion(btn.Tag.ToString());
                    btn.Text = traduccion;
                }
            }
            foreach (Control btn in panelSeguridad.Controls)
            {
                if (btn.Tag != null)
                {
                    var traduccion = idiomaObservado.BuscarTraduccion(btn.Tag.ToString());
                    btn.Text = traduccion;
                }
            }
        }

        private void cbIdioma_SelectedValueChanged(object sender, EventArgs e)
        {
            {
                ManejadorSesion sesion = ManejadorSesion.GetInstancia;
                sesion.idioma = (Idioma)cbIdioma.SelectedItem;

                sesion.idioma.Traducciones = (GestorIdioma.ObtenerTraducciones2(sesion.idioma));
                sesion.CambiarIdioma(sesion.idioma);
            }
        }


    }

   

    
}
