using BIZ.Seguridad;
using GUI.Seguridad.frmPerfiles;
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

namespace GUI.Seguridad
{
    public partial class frmPrincipalPerfiles : Form, IObservador
    {
        ManejadorSesion sesion = ManejadorSesion.GetInstancia;
        public frmPrincipalPerfiles()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
           //Verfica que el form no este abierto
            if ((Application.OpenForms["frmPerfilUsuario"] as frmPerfilUsuario) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPerfilUsuario"].BringToFront();
            }
            else
            {
                frmPerfilUsuario f1 = new frmPerfilUsuario();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmPrincipalFamilias"] as frmPrincipalFamilias) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPrincipalFamilias"].BringToFront();
            }
            else
            {
                frmPrincipalFamilias f1 = new frmPrincipalFamilias();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verfica que el form no este abierto
            if ((Application.OpenForms["frmPrincipalPatentes"] as frmPrincipalPatentes) != null)
            {
                MessageBox.Show("Este formulario ya se encuenta abierto");
                Application.OpenForms["frmPrincipalPatentes"].BringToFront();
            }
            else
            {
                frmPrincipalPatentes f1 = new frmPrincipalPatentes();
                f1.MdiParent = this.MdiParent;
                f1.Show();
                this.MdiParent.MinimumSize = f1.Size;
            }
        }

        private void frmPrincipalPerfiles_Load(object sender, EventArgs e)
        {
            ManejadorSesion.GetInstancia.RegistrarObservador(this);
            Actualizar(sesion.idioma);     
            
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
    }
}
